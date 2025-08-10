using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InventoryManagement.MyForms.UserControls.TransactionUC;
using InventoryManagement.BLL;
using InventoryManagement.DAL;
using InventoryManagement.ConnectionString;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace InventoryManagement.MyForms.InnerUserControls
{
    public partial class subTranscation : UserControl
    {
        TransactionsOperations_DAL.Header headerDAL = new TransactionsOperations_DAL.Header();
        TransactionsOperations_DAL.Body BodyDAL = new TransactionsOperations_DAL.Body();
        private DataTable dt;
        private TransactionMode _mode;

        public subTranscation()
        {
            InitializeComponent();
        }
        public subTranscation(TransactionMode mode)
        {
            InitializeComponent();
            if(TransactionMode.Supply == mode || TransactionMode.SupplyReturn == mode)
            {
                supplier_Customer.Text = "supplier";
                LoadSuppliers();
            }
            else 
            {
                supplier_Customer.Text = "Exchange";
                LoadCustomers();
            }
        }

        private void subTranscation_Load(object sender, EventArgs e)
        {
           
            dateTimePicker1_ValueChanged(null, null);

            LoadItemComboInGrid();
            dgv_ItemDetails.CellValueChanged += dgvItems_CellValueChanged;
            dgv_ItemDetails.CurrentCellDirtyStateChanged += dgvItems_CurrentCellDirtyStateChanged;
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            dgv_ItemDetails.Rows.Add();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveTransactionWithDetails();
        }

        private void SaveTransactionWithDetails()
        {
            // التحقق إذا كان مربع نص رقم العملية فارغ أو يحتوي فقط على مسافات
            if (string.IsNullOrWhiteSpace(txt_OrderNo.Text))
            {
                MessageBox.Show("يرجى إدخال رقم العملية يدويًا.");
                return; // إيقاف التنفيذ إذا الشرط تحقق
            }

            int transactionID; // متغير لتخزين رقم العملية

            // محاولة تحويل النص المدخل إلى رقم صحيح
            if (!int.TryParse(txt_OrderNo.Text, out transactionID))
            {
                MessageBox.Show("رقم العملية يجب أن يكون رقمًا صحيحًا.");
                return; // إيقاف التنفيذ إذا التحويل فشل
            }

            // إنشاء اتصال مع قاعدة البيانات
            using (SqlConnection conn = DBConnection.GetConnectionString())
            {
                conn.Open(); // فتح الاتصال
                SqlTransaction trans = conn.BeginTransaction(); // بدء معاملة (Transaction) لربط كل العمليات معًا

                try
                {
                    // التحقق إذا كان رقم العملية موجود مسبقًا في جدول InventoryTransactions
                    SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM InventoryTransactions WHERE Transaction_ID = @ID",
                        conn, trans
                    );
                    checkCmd.Parameters.AddWithValue("@ID", transactionID);
                    int count = (int)checkCmd.ExecuteScalar(); // إرجاع عدد النتائج (إذا > 0 يعني موجود)

                    if (count > 0)
                    {
                        MessageBox.Show("رقم العملية موجود مسبقًا، يرجى استخدام رقم مختلف.");
                        trans.Rollback(); // التراجع عن المعاملة
                        return;
                    }

                    // إنشاء أمر SQL لإدخال بيانات العملية في الجدول الرئيسي
                    SqlCommand cmdHeader = new SqlCommand(@"
                INSERT INTO InventoryTransactions 
                (Transaction_ID, TransactionType_ID, TransactionDate, Supplier_ID, Customer_ID, User_ID)
                VALUES 
                (@ID, @TypeID, @Date, @SupplierID, @CustomerID, @UserID);
            ", conn, trans);

                    int transactionTypeID = 1; // رقم نوع العملية (1 = توريد)

                    // تمرير القيم إلى الاستعلام
                    cmdHeader.Parameters.AddWithValue("@ID", transactionID);
                    cmdHeader.Parameters.AddWithValue("@TypeID", transactionTypeID);
                    cmdHeader.Parameters.AddWithValue("@Date", dateTimePicker1.Value); // التاريخ من DateTimePicker
                    cmdHeader.Parameters.AddWithValue("@SupplierID", cmb_Supplier_Customer.SelectedValue); // المورد المختار
                    cmdHeader.Parameters.AddWithValue("@CustomerID", DBNull.Value); // لا يوجد عميل
                    cmdHeader.Parameters.AddWithValue("@UserID", 1); // المستخدم الحالي (ثابت في هذا المثال)

                    cmdHeader.ExecuteNonQuery(); // تنفيذ أمر الإدخال

                    // حلقة تمر على جميع الصفوف في DataGridView الخاصة بتفاصيل الأصناف
                    foreach (DataGridViewRow row in dgv_ItemDetails.Rows)
                    {
                        if (row.IsNewRow) continue; // تخطي الصف الجديد الفارغ

                        // الحصول على قيمة العمود "Item_Name" كـ ComboBoxCell
                        var comboCell = row.Cells["Item_Name"] as DataGridViewComboBoxCell;
                        if (comboCell == null || comboCell.Value == null) continue; // إذا الخلية فارغة يتم التخطي

                        string itemID = comboCell.Value.ToString(); // رقم الصنف
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value); // الكمية
                        DateTime expiry = Convert.ToDateTime(row.Cells["ExpiryDate"].Value); // تاريخ الانتهاء

                        // أمر SQL لإدخال تفاصيل الصنف في جدول التفاصيل
                        SqlCommand cmdDetail = new SqlCommand(@"
                    INSERT INTO InventoryTransactionDetails 
                    (Transaction_ID, Item_ID, Quantity, ExpiryDate)
                    VALUES 
                    (@TransactionID, @ItemID, @Quantity, @ExpiryDate);
                ", conn, trans);

                        // تمرير القيم إلى الاستعلام
                        cmdDetail.Parameters.AddWithValue("@TransactionID", transactionID);
                        cmdDetail.Parameters.AddWithValue("@ItemID", itemID);
                        cmdDetail.Parameters.AddWithValue("@Quantity", quantity);
                        cmdDetail.Parameters.AddWithValue("@ExpiryDate", expiry);

                        cmdDetail.ExecuteNonQuery(); // تنفيذ الإدخال
                    }

                    trans.Commit(); // حفظ جميع التغييرات في قاعدة البيانات
                    MessageBox.Show("تم الحفظ بنجاح. رقم العملية: " + transactionID);
                }
                catch (Exception ex)
                {
                    trans.Rollback(); // التراجع عن كل العمليات في حال وجود خطأ
                    MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // دالة تحميل قائمة الأصناف داخل DataGridView على شكل ComboBox
        private void LoadItemComboInGrid()
        {
            using (SqlConnection conn = DBConnection.GetConnectionString())
            {
                // فتح الاتصال بقاعدة البيانات
                conn.Open();

                // جلب بيانات الأصناف (رقم الصنف + اسم الصنف) من جدول Items
                SqlCommand cmd = new SqlCommand("SELECT Item_ID, Item_Name FROM Items", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtItems = new DataTable();
                da.Fill(dtItems); // تعبئة البيانات في DataTable

                dgv_ItemDetails.Columns.Clear(); // مسح أي أعمدة موجودة مسبقًا

                // إنشاء عمود ComboBox لعرض الأصناف
                DataGridViewComboBoxColumn colItem = new DataGridViewComboBoxColumn();
                colItem.Name = "Item_Name"; // اسم العمود
                colItem.HeaderText = "اسم الصنف"; // عنوان العمود
                colItem.DataSource = dtItems; // ربط العمود ببيانات الأصناف
                colItem.DisplayMember = "Item_Name"; // ما سيُعرض للمستخدم
                colItem.ValueMember = "Item_ID"; // القيمة الفعلية المرتبطة
                colItem.Width = 200; // عرض العمود
                dgv_ItemDetails.Columns.Add(colItem); // إضافة العمود إلى الجدول

                // إضافة أعمدة أخرى (فئة، وحدة، كمية، تاريخ انتهاء)
                dgv_ItemDetails.Columns.Add("Category", "الفئة");
                dgv_ItemDetails.Columns["Category"].ReadOnly = true; // للقراءة فقط

                dgv_ItemDetails.Columns.Add("Unit", "الوحدة");
                dgv_ItemDetails.Columns["Unit"].ReadOnly = true; // للقراءة فقط

                dgv_ItemDetails.Columns.Add("Quantity", "الكمية");
                dgv_ItemDetails.Columns.Add("ExpiryDate", "تاريخ الانتهاء");
            }
        }

        // عند تغيير قيمة الخلية (مثلاً اختيار صنف جديد)
        private void dgvItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // التأكد أن التغيير حصل في عمود "اسم الصنف" وفي صف صحيح
            if (e.ColumnIndex == dgv_ItemDetails.Columns["Item_Name"].Index && e.RowIndex >= 0)
            {
                var row = dgv_ItemDetails.Rows[e.RowIndex]; // الصف الحالي
                var selectedValue = row.Cells["Item_Name"].Value; // القيمة المختارة

                if (selectedValue == null) return; // إذا لم يتم اختيار أي صنف

                string itemID = selectedValue.ToString(); // رقم الصنف المختار

                using (SqlConnection conn = DBConnection.GetConnectionString())
                {
                    conn.Open();
                    // جلب اسم الفئة والوحدة بناءً على رقم الصنف
                    SqlCommand cmd = new SqlCommand(@"
                SELECT C.Category_Name, U.Unit_Name
                FROM Items I
                LEFT JOIN Categories C ON I.Category_ID = C.Category_ID
                LEFT JOIN Units U ON I.Unit_ID = U.Unit_ID
                WHERE I.Item_ID = @ItemID
            ", conn);
                    cmd.Parameters.AddWithValue("@ItemID", itemID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // تعبئة عمود الفئة والوحدة في الصف الحالي
                        row.Cells["Category"].Value = reader["Category_Name"].ToString();
                        row.Cells["Unit"].Value = reader["Unit_Name"].ToString();
                    }
                }
            }
        }

        // هذه الدالة لضمان تحديث القيمة فور اختيارها من الـ ComboBox
        private void dgvItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_ItemDetails.IsCurrentCellDirty)
                dgv_ItemDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        // تحميل بيانات الموردين إلى ComboBox
        private void LoadSuppliers()
        {
            using (SqlConnection conn = DBConnection.GetConnectionString())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Supplier_ID, Supplier_Name FROM Suppliers", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtSuppliers = new DataTable();
                da.Fill(dtSuppliers);

                cmb_Supplier_Customer.DataSource = dtSuppliers;
                cmb_Supplier_Customer.DisplayMember = "Supplier_Name"; // اسم المورد
                cmb_Supplier_Customer.ValueMember = "Supplier_ID"; // رقم المورد
            }
        }

        // تحميل بيانات العملاء إلى ComboBox
        private void LoadCustomers()
        {
            using (SqlConnection conn = DBConnection.GetConnectionString())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Customer_ID, Customer_Name FROM Customers", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtSuppliers = new DataTable();
                da.Fill(dtSuppliers);

                cmb_Supplier_Customer.DataSource = dtSuppliers;
                cmb_Supplier_Customer.DisplayMember = "Customer_Name"; // اسم العميل
                cmb_Supplier_Customer.ValueMember = "Customer_ID"; // رقم العميل
            }
        }

        // حدث الرسم للـ Panel (لا يحتوي أي كود حاليًا)
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        // عند تغيير التاريخ في DateTimePicker
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dt = headerDAL.GetAllHeader(); // جلب جميع بيانات الترويسة من قاعدة البيانات

            if (dt.Rows.Count > 0)
            {
                // تحديث قيمة التاريخ بأول تاريخ موجود في البيانات
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["TransactionDate"]);
            }
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_ItemDetails.SelectedRows.Count > 0) // التأكد أن هناك صف محدد
            {
                foreach (DataGridViewRow row in dgv_ItemDetails.SelectedRows)
                {
                    if (!row.IsNewRow) // التأكد أنه ليس صف الإدخال الجديد
                    {
                        dgv_ItemDetails.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("يرجى تحديد صف أولاً قبل الحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
