namespace InventoryManagement.MyForms.UserControls
{
    partial class ReportsUC
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
            this.pic_transactions_repo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_transactions_repo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_transactions_repo
            // 
            this.pic_transactions_repo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_transactions_repo.Location = new System.Drawing.Point(123, 104);
            this.pic_transactions_repo.Name = "pic_transactions_repo";
            this.pic_transactions_repo.Size = new System.Drawing.Size(100, 120);
            this.pic_transactions_repo.TabIndex = 0;
            this.pic_transactions_repo.TabStop = false;
            this.pic_transactions_repo.Click += new System.EventHandler(this.pic_transactions_repo_Click);
            // 
            // ReportsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_transactions_repo);
            this.Name = "ReportsUC";
            this.Size = new System.Drawing.Size(885, 646);
            ((System.ComponentModel.ISupportInitialize)(this.pic_transactions_repo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_transactions_repo;
    }
}
