namespace BAOTANG
{
    partial class FrmRestore
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_linkRestore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuyPhucHoi = new System.Windows.Forms.Button();
            this.txb_linkRestore = new System.Windows.Forms.TextBox();
            this.btnPhucHoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.btn_linkRestore);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnHuyPhucHoi);
            this.panelControl1.Controls.Add(this.txb_linkRestore);
            this.panelControl1.Controls.Add(this.btnPhucHoi);
            this.panelControl1.Location = new System.Drawing.Point(580, 170);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1030, 450);
            this.panelControl1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đường Dẫn";
            // 
            // btn_linkRestore
            // 
            this.btn_linkRestore.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_linkRestore.Location = new System.Drawing.Point(727, 179);
            this.btn_linkRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btn_linkRestore.Name = "btn_linkRestore";
            this.btn_linkRestore.Size = new System.Drawing.Size(232, 47);
            this.btn_linkRestore.TabIndex = 8;
            this.btn_linkRestore.Text = "Chọn đường dẫn";
            this.btn_linkRestore.UseVisualStyleBackColor = true;
            this.btn_linkRestore.Click += new System.EventHandler(this.btn_linkRestore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "RESTORE";
            // 
            // btnHuyPhucHoi
            // 
            this.btnHuyPhucHoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPhucHoi.Location = new System.Drawing.Point(505, 304);
            this.btnHuyPhucHoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyPhucHoi.Name = "btnHuyPhucHoi";
            this.btnHuyPhucHoi.Size = new System.Drawing.Size(152, 54);
            this.btnHuyPhucHoi.TabIndex = 9;
            this.btnHuyPhucHoi.Text = "Hủy";
            this.btnHuyPhucHoi.UseVisualStyleBackColor = true;
            this.btnHuyPhucHoi.Click += new System.EventHandler(this.btnHuyPhucHoi_Click);
            // 
            // txb_linkRestore
            // 
            this.txb_linkRestore.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_linkRestore.Location = new System.Drawing.Point(249, 186);
            this.txb_linkRestore.Name = "txb_linkRestore";
            this.txb_linkRestore.Size = new System.Drawing.Size(408, 34);
            this.txb_linkRestore.TabIndex = 0;
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhucHoi.Location = new System.Drawing.Point(249, 304);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(152, 54);
            this.btnPhucHoi.TabIndex = 1;
            this.btnPhucHoi.Text = "Phục Hồi";
            this.btnPhucHoi.UseVisualStyleBackColor = true;
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // FrmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 828);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmRestore";
            this.Text = "Hồi Phục Dữ Liệu";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btn_linkRestore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyPhucHoi;
        private System.Windows.Forms.TextBox txb_linkRestore;
        private System.Windows.Forms.Button btnPhucHoi;
        private System.Windows.Forms.Label label3;
    }
}