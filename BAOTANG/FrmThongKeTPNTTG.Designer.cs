namespace BAOTANG
{
    partial class FrmThongKeTPNTTG
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
            System.Windows.Forms.Label iDTACGIALabel;
            this.bAOTANGDataSet = new BAOTANG.BAOTANGDataSet();
            this.tPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.TPNTTableAdapter();
            this.tableAdapterManager = new BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.btnXem = new System.Windows.Forms.Button();
            this.tACGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tACGIATableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.TACGIATableAdapter();
            this.fKTACGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tACGIABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbxIDTG = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            iDTACGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTACGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDTACGIALabel
            // 
            iDTACGIALabel.AutoSize = true;
            iDTACGIALabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            iDTACGIALabel.Location = new System.Drawing.Point(269, 186);
            iDTACGIALabel.Name = "iDTACGIALabel";
            iDTACGIALabel.Size = new System.Drawing.Size(125, 26);
            iDTACGIALabel.TabIndex = 1;
            iDTACGIALabel.Text = "IDTACGIA:";
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
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXem.Location = new System.Drawing.Point(205, 302);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(301, 58);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem Danh Sách TP";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // tACGIABindingSource
            // 
            this.tACGIABindingSource.DataMember = "TACGIA";
            this.tACGIABindingSource.DataSource = this.bAOTANGDataSet;
            // 
            // tACGIATableAdapter
            // 
            this.tACGIATableAdapter.ClearBeforeFill = true;
            // 
            // fKTACGIABindingSource
            // 
            this.fKTACGIABindingSource.DataMember = "FK_TACGIA";
            this.fKTACGIABindingSource.DataSource = this.tACGIABindingSource;
            // 
            // tACGIABindingSource1
            // 
            this.tACGIABindingSource1.DataMember = "TACGIA";
            this.tACGIABindingSource1.DataSource = this.bAOTANGDataSet;
            // 
            // cbxIDTG
            // 
            this.cbxIDTG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tACGIABindingSource, "IDTACGIA", true));
            this.cbxIDTG.DataSource = this.tACGIABindingSource1;
            this.cbxIDTG.DisplayMember = "IDTACGIA";
            this.cbxIDTG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIDTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxIDTG.FormattingEnabled = true;
            this.cbxIDTG.Location = new System.Drawing.Point(466, 180);
            this.cbxIDTG.Name = "cbxIDTG";
            this.cbxIDTG.Size = new System.Drawing.Size(261, 37);
            this.cbxIDTG.TabIndex = 4;
            this.cbxIDTG.ValueMember = "IDTACGIA";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(597, 302);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(182, 58);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thông Tin TPNT Của Tác Giả";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.cbxIDTG);
            this.panelControl1.Controls.Add(iDTACGIALabel);
            this.panelControl1.Location = new System.Drawing.Point(580, 170);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1030, 450);
            this.panelControl1.TabIndex = 15;
            // 
            // FrmThongKeTPNTTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmThongKeTPNTTG";
            this.Text = "Thống Kê TPNT Tác Giả";
            this.Load += new System.EventHandler(this.FrmThongKeTPNTTG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTACGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource1)).EndInit();
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
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.BindingSource tACGIABindingSource;
        private BAOTANGDataSetTableAdapters.TACGIATableAdapter tACGIATableAdapter;
        private System.Windows.Forms.BindingSource fKTACGIABindingSource;
        private System.Windows.Forms.BindingSource tACGIABindingSource1;
        private System.Windows.Forms.ComboBox cbxIDTG;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}