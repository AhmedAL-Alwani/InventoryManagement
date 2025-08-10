namespace InventoryManagement.MyForms.UserControls
{
    partial class TransactionUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.SuspendLayout();
            // 
            // TransactionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TransactionUC";
            this.Size = new System.Drawing.Size(1011, 646);
=======
            this.btn_ExchangeReturn = new System.Windows.Forms.Button();
            this.btn_SupplyReturn = new System.Windows.Forms.Button();
            this.btn_Exchange = new System.Windows.Forms.Button();
            this.btn_Supply = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ExchangeReturn
            // 
            this.btn_ExchangeReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ExchangeReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExchangeReturn.Location = new System.Drawing.Point(40, 312);
            this.btn_ExchangeReturn.Name = "btn_ExchangeReturn";
            this.btn_ExchangeReturn.Size = new System.Drawing.Size(145, 48);
            this.btn_ExchangeReturn.TabIndex = 0;
            this.btn_ExchangeReturn.Text = "Exchange Return";
            this.btn_ExchangeReturn.UseVisualStyleBackColor = false;
            this.btn_ExchangeReturn.Click += new System.EventHandler(this.btn_ExchangeReturn_Click);
            // 
            // btn_SupplyReturn
            // 
            this.btn_SupplyReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SupplyReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SupplyReturn.Location = new System.Drawing.Point(217, 312);
            this.btn_SupplyReturn.Name = "btn_SupplyReturn";
            this.btn_SupplyReturn.Size = new System.Drawing.Size(145, 48);
            this.btn_SupplyReturn.TabIndex = 1;
            this.btn_SupplyReturn.Text = "Supply Return";
            this.btn_SupplyReturn.UseVisualStyleBackColor = false;
            this.btn_SupplyReturn.Click += new System.EventHandler(this.btn_SupplyReturn_Click);
            // 
            // btn_Exchange
            // 
            this.btn_Exchange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Exchange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exchange.Location = new System.Drawing.Point(394, 312);
            this.btn_Exchange.Name = "btn_Exchange";
            this.btn_Exchange.Size = new System.Drawing.Size(145, 48);
            this.btn_Exchange.TabIndex = 2;
            this.btn_Exchange.Text = "Exchange";
            this.btn_Exchange.UseVisualStyleBackColor = false;
            this.btn_Exchange.Click += new System.EventHandler(this.btn_Exchange_Click);
            // 
            // btn_Supply
            // 
            this.btn_Supply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Supply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supply.Location = new System.Drawing.Point(571, 312);
            this.btn_Supply.Name = "btn_Supply";
            this.btn_Supply.Size = new System.Drawing.Size(145, 48);
            this.btn_Supply.TabIndex = 3;
            this.btn_Supply.Text = "Supply";
            this.btn_Supply.UseVisualStyleBackColor = false;
            this.btn_Supply.Click += new System.EventHandler(this.btn_Supply_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox4.Image = global::InventoryManagement.Properties.Resources.Supply;
            this.pictureBox4.Location = new System.Drawing.Point(571, 172);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 110);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox3.Image = global::InventoryManagement.Properties.Resources.ExchangeReturn1;
            this.pictureBox3.Location = new System.Drawing.Point(394, 172);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Image = global::InventoryManagement.Properties.Resources.SupplyReturn;
            this.pictureBox2.Location = new System.Drawing.Point(217, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Image = global::InventoryManagement.Properties.Resources.ExchangeReturn;
            this.pictureBox1.Location = new System.Drawing.Point(40, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TransactionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Supply);
            this.Controls.Add(this.btn_Exchange);
            this.Controls.Add(this.btn_SupplyReturn);
            this.Controls.Add(this.btn_ExchangeReturn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TransactionUC";
            this.Size = new System.Drawing.Size(758, 525);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
>>>>>>> 560d346428c99d5576ad73d7fdbf828c372fff2e
            this.ResumeLayout(false);

        }

        #endregion
<<<<<<< HEAD
=======

        private System.Windows.Forms.Button btn_ExchangeReturn;
        private System.Windows.Forms.Button btn_SupplyReturn;
        private System.Windows.Forms.Button btn_Exchange;
        private System.Windows.Forms.Button btn_Supply;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
>>>>>>> 560d346428c99d5576ad73d7fdbf828c372fff2e
    }
}
