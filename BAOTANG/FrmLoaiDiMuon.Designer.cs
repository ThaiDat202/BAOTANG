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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDetail = new DevExpress.XtraEditors.PanelControl();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtNgayTra = new DevExpress.XtraEditors.DateEdit();
            this.dtNgayMuon = new DevExpress.XtraEditors.DateEdit();
            this.txtMATPNT = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BAOTANGDataSet = new BAOTANG.BAOTANGDataSet();
            this.tableAdapterManager = new BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.BOSUUTAPTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.BOSUUTAPTableAdapter();
            this.BOSUUTAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIDIMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIDIMUONTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.LOAIDIMUONTableAdapter();
            this.cmbBST = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayTra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMuon.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMATPNT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOSUUTAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDIMUONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thông Tin Về TPNT Loại Đi Mượn";
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.cmbBST);
            this.pnlDetail.Controls.Add(this.btnUpdate);
            this.pnlDetail.Controls.Add(this.btnAdd);
            this.pnlDetail.Controls.Add(this.dtNgayTra);
            this.pnlDetail.Controls.Add(this.dtNgayMuon);
            this.pnlDetail.Controls.Add(this.txtMATPNT);
            this.pnlDetail.Controls.Add(this.label5);
            this.pnlDetail.Controls.Add(this.label4);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1310, 520);
            this.pnlDetail.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(642, 434);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 52);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(508, 434);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 52);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.EditValue = null;
            this.dtNgayTra.Location = new System.Drawing.Point(803, 344);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayTra.Properties.Appearance.Options.UseFont = true;
            this.dtNgayTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayTra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayTra.Size = new System.Drawing.Size(296, 32);
            this.dtNgayTra.TabIndex = 18;
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.EditValue = null;
            this.dtNgayMuon.Location = new System.Drawing.Point(264, 344);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayMuon.Properties.Appearance.Options.UseFont = true;
            this.dtNgayMuon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayMuon.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayMuon.Size = new System.Drawing.Size(250, 32);
            this.dtNgayMuon.TabIndex = 17;
            // 
            // txtMATPNT
            // 
            this.txtMATPNT.Location = new System.Drawing.Point(264, 216);
            this.txtMATPNT.Name = "txtMATPNT";
            this.txtMATPNT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMATPNT.Properties.Appearance.Options.UseFont = true;
            this.txtMATPNT.Properties.ReadOnly = true;
            this.txtMATPNT.Size = new System.Drawing.Size(250, 32);
            this.txtMATPNT.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(608, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "NGAYTRA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "NGAYMUON:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "TENBST:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "MATPNT:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1310, 133);
            this.panelControl1.TabIndex = 23;
            // 
            // BAOTANGDataSet
            // 
            this.BAOTANGDataSet.DataSetName = "BAOTANGDataSet";
            this.BAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = this.BOSUUTAPTableAdapter;
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
            // BOSUUTAPTableAdapter
            // 
            this.BOSUUTAPTableAdapter.ClearBeforeFill = true;
            // 
            // BOSUUTAPBindingSource
            // 
            this.BOSUUTAPBindingSource.DataMember = "BOSUUTAP";
            this.BOSUUTAPBindingSource.DataSource = this.BAOTANGDataSet;
            // 
            // lOAIDIMUONBindingSource
            // 
            this.lOAIDIMUONBindingSource.DataMember = "LOAIDIMUON";
            this.lOAIDIMUONBindingSource.DataSource = this.BAOTANGDataSet;
            // 
            // lOAIDIMUONTableAdapter
            // 
            this.lOAIDIMUONTableAdapter.ClearBeforeFill = true;
            // 
            // cmbBST
            // 
            this.cmbBST.DataSource = this.BOSUUTAPBindingSource;
            this.cmbBST.DisplayMember = "TENBST";
            this.cmbBST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBST.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBST.FormattingEnabled = true;
            this.cmbBST.Location = new System.Drawing.Point(803, 213);
            this.cmbBST.Name = "cmbBST";
            this.cmbBST.Size = new System.Drawing.Size(296, 36);
            this.cmbBST.TabIndex = 21;
            this.cmbBST.ValueMember = "IDBST";
            // 
            // FrmLoaiDiMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 520);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pnlDetail);
            this.Name = "FrmLoaiDiMuon";
            this.Text = "Loại Đi Mượn";
            this.Load += new System.EventHandler(this.FrmLoaiDiMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayTra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMuon.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMATPNT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOSUUTAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDIMUONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BAOTANGDataSet BAOTANGDataSet;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BAOTANGDataSetTableAdapters.BOSUUTAPTableAdapter BOSUUTAPTableAdapter;
        private System.Windows.Forms.BindingSource BOSUUTAPBindingSource;
        private DevExpress.XtraEditors.PanelControl pnlDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.TextEdit txtMATPNT;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnAdd;
        public DevExpress.XtraEditors.DateEdit dtNgayTra;
        public DevExpress.XtraEditors.DateEdit dtNgayMuon;
        private System.Windows.Forms.BindingSource lOAIDIMUONBindingSource;
        private BAOTANGDataSetTableAdapters.LOAIDIMUONTableAdapter lOAIDIMUONTableAdapter;
        public System.Windows.Forms.ComboBox cmbBST;
    }
}