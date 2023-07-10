namespace BAOTANG
{
    partial class FrmMenuLoai
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLoaiDiMuon = new System.Windows.Forms.Button();
            this.btnLoaiSoHuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(195, 85);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(442, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CHỌN LOẠI TÀI SẢN CỦA TPNT";
            // 
            // btnLoaiDiMuon
            // 
            this.btnLoaiDiMuon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiDiMuon.Location = new System.Drawing.Point(47, 206);
            this.btnLoaiDiMuon.Name = "btnLoaiDiMuon";
            this.btnLoaiDiMuon.Size = new System.Drawing.Size(261, 72);
            this.btnLoaiDiMuon.TabIndex = 1;
            this.btnLoaiDiMuon.Text = "Loại Đi Mượn";
            this.btnLoaiDiMuon.UseVisualStyleBackColor = true;
            // 
            // btnLoaiSoHuu
            // 
            this.btnLoaiSoHuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiSoHuu.Location = new System.Drawing.Point(465, 206);
            this.btnLoaiSoHuu.Name = "btnLoaiSoHuu";
            this.btnLoaiSoHuu.Size = new System.Drawing.Size(261, 72);
            this.btnLoaiSoHuu.TabIndex = 2;
            this.btnLoaiSoHuu.Text = "Loại Sở Hữu";
            this.btnLoaiSoHuu.UseVisualStyleBackColor = true;
            // 
            // FrmMenuLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoaiSoHuu);
            this.Controls.Add(this.btnLoaiDiMuon);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmMenuLoai";
            this.Text = "Menu Loại";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.Button btnLoaiDiMuon;
        public System.Windows.Forms.Button btnLoaiSoHuu;
    }
}