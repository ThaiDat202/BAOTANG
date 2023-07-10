namespace BAOTANG
{
    partial class FrmThongKeTPNTCTL
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
            System.Windows.Forms.Label nGAYKTLabel;
            System.Windows.Forms.Label nGAYBDLabel;
            this.bAOTANGDataSet = new BAOTANG.BAOTANGDataSet();
            this.tPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.TPNTTableAdapter();
            this.tableAdapterManager = new BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.deFrom = new DevExpress.XtraEditors.DateEdit();
            this.deTo = new DevExpress.XtraEditors.DateEdit();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            nGAYKTLabel = new System.Windows.Forms.Label();
            nGAYBDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nGAYKTLabel
            // 
            nGAYKTLabel.AutoSize = true;
            nGAYKTLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nGAYKTLabel.Location = new System.Drawing.Point(532, 207);
            nGAYKTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYKTLabel.Name = "nGAYKTLabel";
            nGAYKTLabel.Size = new System.Drawing.Size(109, 26);
            nGAYKTLabel.TabIndex = 10;
            nGAYKTLabel.Text = "NGAYKT:";
            // 
            // nGAYBDLabel
            // 
            nGAYBDLabel.AutoSize = true;
            nGAYBDLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nGAYBDLabel.Location = new System.Drawing.Point(130, 207);
            nGAYBDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYBDLabel.Name = "nGAYBDLabel";
            nGAYBDLabel.Size = new System.Drawing.Size(110, 26);
            nGAYBDLabel.TabIndex = 9;
            nGAYBDLabel.Text = "NGAYBD:";
            // 
            // bAOTANGDataSet
            // 
            this.bAOTANGDataSet.DataSetName = "BAOTANGDataSet";
            this.bAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tPNTBindingSource
            // 
            this.tPNTBindingSource.DataMember = "TPNT";
            this.tPNTBindingSource.DataSource = this.bAOTANGDataSet;
            // 
            // tPNTTableAdapter
            // 
            this.tPNTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = null;
            this.tableAdapterManager.CT_CUOCTRIENLAMTableAdapter = null;
            this.tableAdapterManager.CUOCTRIENLAMTableAdapter = null;
            this.tableAdapterManager.DIEUKHACVATACTUONGTableAdapter = null;
            this.tableAdapterManager.HOIHOATableAdapter = null;
            this.tableAdapterManager.LOAIDIMUONTableAdapter = null;
            this.tableAdapterManager.LOAIHINHKHACTableAdapter = null;
            this.tableAdapterManager.LOAISOHUUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TPNTTableAdapter = this.tPNTTableAdapter;
            this.tableAdapterManager.UpdateOrder = BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // deFrom
            // 
            this.deFrom.EditValue = null;
            this.deFrom.Location = new System.Drawing.Point(281, 204);
            this.deFrom.Margin = new System.Windows.Forms.Padding(5);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deFrom.Properties.Appearance.Options.UseFont = true;
            this.deFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Size = new System.Drawing.Size(177, 32);
            this.deFrom.TabIndex = 0;
            // 
            // deTo
            // 
            this.deTo.EditValue = null;
            this.deTo.Location = new System.Drawing.Point(704, 204);
            this.deTo.Margin = new System.Windows.Forms.Padding(5);
            this.deTo.Name = "deTo";
            this.deTo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deTo.Properties.Appearance.Options.UseFont = true;
            this.deTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Size = new System.Drawing.Size(177, 32);
            this.deTo.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXem.Location = new System.Drawing.Point(201, 326);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(301, 58);
            this.btnXem.TabIndex = 11;
            this.btnXem.Text = "Xem Danh Sách CTL";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(611, 326);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(182, 58);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thông Tin TPNT Của Các Cuộc Triển Lãm";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(this.deFrom);
            this.panelControl1.Controls.Add(nGAYKTLabel);
            this.panelControl1.Controls.Add(this.deTo);
            this.panelControl1.Controls.Add(nGAYBDLabel);
            this.panelControl1.Location = new System.Drawing.Point(580, 170);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1030, 450);
            this.panelControl1.TabIndex = 16;
            // 
            // FrmThongKeTPNTCTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmThongKeTPNTCTL";
            this.Text = "Thống Kê Các Cuộc Triển Lãm";
            this.Load += new System.EventHandler(this.FrmThongKeTPNTCTL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BAOTANGDataSet bAOTANGDataSet;
        private System.Windows.Forms.BindingSource tPNTBindingSource;
        private BAOTANGDataSetTableAdapters.TPNTTableAdapter tPNTTableAdapter;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.DateEdit deFrom;
        private DevExpress.XtraEditors.DateEdit deTo;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}