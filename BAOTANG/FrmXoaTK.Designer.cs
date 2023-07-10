namespace BAOTANG
{
    partial class FrmXoaTK
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
            this.components = new System.ComponentModel.Container();
            this.mANVLabel = new System.Windows.Forms.Label();
            this.hOTENLabel = new System.Windows.Forms.Label();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.bAOTANGDataSet = new BAOTANG.BAOTANGDataSet();
            this.xOA_LOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xOA_LOGINTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.XOA_LOGINTableAdapter();
            this.tableAdapterManager = new BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.mANVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTENComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOA_LOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            this.mANVLabel.AutoSize = true;
            this.mANVLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANVLabel.Location = new System.Drawing.Point(110, 312);
            this.mANVLabel.Name = "mANVLabel";
            this.mANVLabel.Size = new System.Drawing.Size(83, 26);
            this.mANVLabel.TabIndex = 3;
            this.mANVLabel.Text = "MANV:";
            // 
            // hOTENLabel
            // 
            this.hOTENLabel.AutoSize = true;
            this.hOTENLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOTENLabel.Location = new System.Drawing.Point(110, 194);
            this.hOTENLabel.Name = "hOTENLabel";
            this.hOTENLabel.Size = new System.Drawing.Size(93, 26);
            this.hOTENLabel.TabIndex = 4;
            this.hOTENLabel.Text = "HOTEN:";
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.Location = new System.Drawing.Point(115, 427);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(177, 45);
            this.btnXoaTK.TabIndex = 0;
            this.btnXoaTK.Text = "Xóa tài khoản";
            this.btnXoaTK.UseVisualStyleBackColor = true;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(395, 427);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 45);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // bAOTANGDataSet
            // 
            this.bAOTANGDataSet.DataSetName = "BAOTANGDataSet";
            this.bAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xOA_LOGINBindingSource
            // 
            this.xOA_LOGINBindingSource.DataMember = "XOA_LOGIN";
            this.xOA_LOGINBindingSource.DataSource = this.bAOTANGDataSet;
            // 
            // xOA_LOGINTableAdapter
            // 
            this.xOA_LOGINTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_CUOCTRIENLAMTableAdapter = null;
            this.tableAdapterManager.CUOCTRIENLAMTableAdapter = null;
            this.tableAdapterManager.DIEUKHACVATACTUONGTableAdapter = null;
            this.tableAdapterManager.HOIHOATableAdapter = null;
            this.tableAdapterManager.LOAIDIMUONTableAdapter = null;
            this.tableAdapterManager.LOAIHINHKHACTableAdapter = null;
            this.tableAdapterManager.LOAISOHUUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TPNTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mANVTextEdit
            // 
            this.mANVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xOA_LOGINBindingSource, "MANV", true));
            this.mANVTextEdit.Enabled = false;
            this.mANVTextEdit.Location = new System.Drawing.Point(277, 309);
            this.mANVTextEdit.Name = "mANVTextEdit";
            this.mANVTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANVTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mANVTextEdit.Size = new System.Drawing.Size(243, 32);
            this.mANVTextEdit.TabIndex = 4;
            // 
            // hOTENComboBox
            // 
            this.hOTENComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xOA_LOGINBindingSource, "HOTEN", true));
            this.hOTENComboBox.DataSource = this.xOA_LOGINBindingSource;
            this.hOTENComboBox.DisplayMember = "HOTEN";
            this.hOTENComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hOTENComboBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOTENComboBox.FormattingEnabled = true;
            this.hOTENComboBox.Location = new System.Drawing.Point(277, 191);
            this.hOTENComboBox.Name = "hOTENComboBox";
            this.hOTENComboBox.Size = new System.Drawing.Size(243, 34);
            this.hOTENComboBox.TabIndex = 5;
            this.hOTENComboBox.ValueMember = "MANV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xóa Tài Khoản";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.mANVLabel);
            this.panelControl1.Controls.Add(this.btnXoaTK);
            this.panelControl1.Controls.Add(this.hOTENLabel);
            this.panelControl1.Controls.Add(this.mANVTextEdit);
            this.panelControl1.Controls.Add(this.hOTENComboBox);
            this.panelControl1.Location = new System.Drawing.Point(765, 134);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(632, 541);
            this.panelControl1.TabIndex = 7;
            // 
            // FrmXoaTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 894);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmXoaTK";
            this.Text = "Xóa Tài Khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmXoaTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOA_LOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Button btnThoat;
        private BAOTANGDataSet bAOTANGDataSet;
        private System.Windows.Forms.BindingSource xOA_LOGINBindingSource;
        private BAOTANGDataSetTableAdapters.XOA_LOGINTableAdapter xOA_LOGINTableAdapter;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit mANVTextEdit;
        private System.Windows.Forms.ComboBox hOTENComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mANVLabel;
        private System.Windows.Forms.Label hOTENLabel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}