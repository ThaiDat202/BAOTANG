namespace BAOTANG
{
    partial class FrmLoaiDiMuon
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtMATPNT = new System.Windows.Forms.TextBox();
            this.dtNgayTra = new DevExpress.XtraEditors.DateEdit();
            this.dtNgayMuon = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bOSUUTAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAOTANGDataSet = new BAOTANG.BAOTANGDataSet();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bOSUUTAPTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.BOSUUTAPTableAdapter();
            this.lOAIDIMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIDIMUONTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.LOAIDIMUONTableAdapter();
            this.tableAdapterManager = new BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.cmbBST = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayTra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMuon.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOSUUTAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDIMUONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1408, 139);
            this.panelControl1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thông Tin Về TPNT Loại Đi Mượn";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cmbBST);
            this.panelControl2.Controls.Add(this.txtMATPNT);
            this.panelControl2.Controls.Add(this.dtNgayTra);
            this.panelControl2.Controls.Add(this.dtNgayMuon);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.btnUpdate);
            this.panelControl2.Controls.Add(this.btnAdd);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 139);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1408, 433);
            this.panelControl2.TabIndex = 7;
            // 
            // txtMATPNT
            // 
            this.txtMATPNT.Enabled = false;
            this.txtMATPNT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMATPNT.Location = new System.Drawing.Point(392, 110);
            this.txtMATPNT.Name = "txtMATPNT";
            this.txtMATPNT.Size = new System.Drawing.Size(219, 34);
            this.txtMATPNT.TabIndex = 28;
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.EditValue = null;
            this.dtNgayTra.Location = new System.Drawing.Point(916, 248);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayTra.Properties.Appearance.Options.UseFont = true;
            this.dtNgayTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayTra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayTra.Size = new System.Drawing.Size(255, 32);
            this.dtNgayTra.TabIndex = 27;
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.EditValue = null;
            this.dtNgayMuon.Location = new System.Drawing.Point(392, 248);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayMuon.Properties.Appearance.Options.UseFont = true;
            this.dtNgayMuon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayMuon.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayMuon.Size = new System.Drawing.Size(219, 32);
            this.dtNgayMuon.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(743, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "NGAYTRA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "NGAYMUON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(785, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "IDBST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "MATPNT";
            // 
            // bOSUUTAPBindingSource
            // 
            this.bOSUUTAPBindingSource.DataMember = "BOSUUTAP";
            this.bOSUUTAPBindingSource.DataSource = this.bAOTANGDataSet;
            // 
            // bAOTANGDataSet
            // 
            this.bAOTANGDataSet.DataSetName = "BAOTANGDataSet";
            this.bAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(656, 353);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 52);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(522, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 52);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            // 
            // bOSUUTAPTableAdapter
            // 
            this.bOSUUTAPTableAdapter.ClearBeforeFill = true;
            // 
            // lOAIDIMUONBindingSource
            // 
            this.lOAIDIMUONBindingSource.DataMember = "LOAIDIMUON";
            this.lOAIDIMUONBindingSource.DataSource = this.bAOTANGDataSet;
            // 
            // lOAIDIMUONTableAdapter
            // 
            this.lOAIDIMUONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = this.bOSUUTAPTableAdapter;
            this.tableAdapterManager.CT_CUOCTRIENLAMTableAdapter = null;
            this.tableAdapterManager.CUOCTRIENLAMTableAdapter = null;
            this.tableAdapterManager.DIEUKHACVATACTUONGTableAdapter = null;
            this.tableAdapterManager.HOIHOATableAdapter = null;
            this.tableAdapterManager.LOAIDIMUONTableAdapter = this.lOAIDIMUONTableAdapter;
            this.tableAdapterManager.LOAIHINHKHACTableAdapter = null;
            this.tableAdapterManager.LOAISOHUUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TPNTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbBST
            // 
            this.cmbBST.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAIDIMUONBindingSource, "IDBST", true));
            this.cmbBST.DataSource = this.bOSUUTAPBindingSource;
            this.cmbBST.DisplayMember = "TENBST";
            this.cmbBST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBST.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBST.FormattingEnabled = true;
            this.cmbBST.Location = new System.Drawing.Point(916, 113);
            this.cmbBST.Name = "cmbBST";
            this.cmbBST.Size = new System.Drawing.Size(255, 34);
            this.cmbBST.TabIndex = 29;
            this.cmbBST.ValueMember = "IDBST";
            // 
            // FrmLoaiDiMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 572);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmLoaiDiMuon";
            this.Text = "Loại Đi Mượn";
            this.Load += new System.EventHandler(this.FrmLoaiDiMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayTra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMuon.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOSUUTAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDIMUONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource bOSUUTAPBindingSource;
        private BAOTANGDataSet bAOTANGDataSet;
        private BAOTANGDataSetTableAdapters.BOSUUTAPTableAdapter bOSUUTAPTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMATPNT;
        public DevExpress.XtraEditors.DateEdit dtNgayMuon;
        public DevExpress.XtraEditors.DateEdit dtNgayTra;
        private System.Windows.Forms.BindingSource lOAIDIMUONBindingSource;
        private BAOTANGDataSetTableAdapters.LOAIDIMUONTableAdapter lOAIDIMUONTableAdapter;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.ComboBox cmbBST;
    }
}