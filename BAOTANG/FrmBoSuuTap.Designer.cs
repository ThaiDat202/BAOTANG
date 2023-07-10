namespace BAOTANG
{
    partial class FrmBoSuuTap
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
            System.Windows.Forms.Label iDBSTLabel;
            System.Windows.Forms.Label tENBSTLabel;
            System.Windows.Forms.Label hINHTHUCSUUTAPLabel;
            System.Windows.Forms.Label mANVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBoSuuTap));
            this.pnlDetail = new DevExpress.XtraEditors.PanelControl();
            this.cmbMANV = new System.Windows.Forms.ComboBox();
            this.bdsBST = new System.Windows.Forms.BindingSource(this.components);
            this.BAOTANGDataSet = new BAOTANG.BAOTANGDataSet();
            this.NHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHTST = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtTenBST = new DevExpress.XtraEditors.TextEdit();
            this.txtIDBST = new DevExpress.XtraEditors.TextEdit();
            this.tableAdapterManager = new BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.LOAIDIMUONTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.LOAIDIMUONTableAdapter();
            this.NHANVIENTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.NHANVIENTableAdapter();
            this.LOAIDIMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BOSUUTAPTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.BOSUUTAPTableAdapter();
            this.gctBST = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDBST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENBST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHINHTHUCSUUTAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            iDBSTLabel = new System.Windows.Forms.Label();
            tENBSTLabel = new System.Windows.Forms.Label();
            hINHTHUCSUUTAPLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHTST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDBST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOAIDIMUONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctBST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDBSTLabel
            // 
            iDBSTLabel.AutoSize = true;
            iDBSTLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDBSTLabel.Location = new System.Drawing.Point(244, 97);
            iDBSTLabel.Name = "iDBSTLabel";
            iDBSTLabel.Size = new System.Drawing.Size(82, 26);
            iDBSTLabel.TabIndex = 0;
            iDBSTLabel.Text = "IDBST:";
            // 
            // tENBSTLabel
            // 
            tENBSTLabel.AutoSize = true;
            tENBSTLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENBSTLabel.Location = new System.Drawing.Point(985, 94);
            tENBSTLabel.Name = "tENBSTLabel";
            tENBSTLabel.Size = new System.Drawing.Size(101, 26);
            tENBSTLabel.TabIndex = 2;
            tENBSTLabel.Text = "TENBST:";
            // 
            // hINHTHUCSUUTAPLabel
            // 
            hINHTHUCSUUTAPLabel.AutoSize = true;
            hINHTHUCSUUTAPLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hINHTHUCSUUTAPLabel.Location = new System.Drawing.Point(111, 216);
            hINHTHUCSUUTAPLabel.Name = "hINHTHUCSUUTAPLabel";
            hINHTHUCSUUTAPLabel.Size = new System.Drawing.Size(215, 26);
            hINHTHUCSUUTAPLabel.TabIndex = 4;
            hINHTHUCSUUTAPLabel.Text = "HINHTHUCSUUTAP:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(1003, 216);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(83, 26);
            mANVLabel.TabIndex = 7;
            mANVLabel.Text = "MANV:";
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(mANVLabel);
            this.pnlDetail.Controls.Add(this.cmbMANV);
            this.pnlDetail.Controls.Add(hINHTHUCSUUTAPLabel);
            this.pnlDetail.Controls.Add(this.txtHTST);
            this.pnlDetail.Controls.Add(tENBSTLabel);
            this.pnlDetail.Controls.Add(this.txtTenBST);
            this.pnlDetail.Controls.Add(iDBSTLabel);
            this.pnlDetail.Controls.Add(this.txtIDBST);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetail.Enabled = false;
            this.pnlDetail.Location = new System.Drawing.Point(0, 223);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(8);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1924, 353);
            this.pnlDetail.TabIndex = 1;
            // 
            // cmbMANV
            // 
            this.cmbMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBST, "MANV", true));
            this.cmbMANV.DataSource = this.NHANVIENBindingSource;
            this.cmbMANV.DisplayMember = "MANV";
            this.cmbMANV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMANV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMANV.FormattingEnabled = true;
            this.cmbMANV.Location = new System.Drawing.Point(1157, 213);
            this.cmbMANV.Name = "cmbMANV";
            this.cmbMANV.Size = new System.Drawing.Size(282, 34);
            this.cmbMANV.TabIndex = 8;
            this.cmbMANV.ValueMember = "MANV";
            // 
            // bdsBST
            // 
            this.bdsBST.DataMember = "BOSUUTAP";
            this.bdsBST.DataSource = this.BAOTANGDataSet;
            // 
            // BAOTANGDataSet
            // 
            this.BAOTANGDataSet.DataSetName = "BAOTANGDataSet";
            this.BAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NHANVIENBindingSource
            // 
            this.NHANVIENBindingSource.DataMember = "NHANVIEN";
            this.NHANVIENBindingSource.DataSource = this.BAOTANGDataSet;
            // 
            // txtHTST
            // 
            this.txtHTST.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBST, "HINHTHUCSUUTAP", true));
            this.txtHTST.Location = new System.Drawing.Point(397, 213);
            this.txtHTST.MenuManager = this.barManager1;
            this.txtHTST.Name = "txtHTST";
            this.txtHTST.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHTST.Properties.Appearance.Options.UseFont = true;
            this.txtHTST.Size = new System.Drawing.Size(324, 32);
            this.txtHTST.TabIndex = 5;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnItemAdd,
            this.btnItemEdit,
            this.btnItemDelete,
            this.btnItemSave,
            this.btnItemReload,
            this.btnItemUndo,
            this.btnItemExit});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Caption = "Thêm";
            this.btnItemAdd.Enabled = false;
            this.btnItemAdd.Id = 0;
            this.btnItemAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemAdd.ImageOptions.Image")));
            this.btnItemAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemAdd.ImageOptions.LargeImage")));
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemAdd_ItemClick);
            // 
            // btnItemEdit
            // 
            this.btnItemEdit.Caption = "Sửa";
            this.btnItemEdit.Enabled = false;
            this.btnItemEdit.Id = 1;
            this.btnItemEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemEdit.ImageOptions.Image")));
            this.btnItemEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemEdit.ImageOptions.LargeImage")));
            this.btnItemEdit.Name = "btnItemEdit";
            this.btnItemEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemEdit_ItemClick);
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.Caption = "Xóa";
            this.btnItemDelete.Enabled = false;
            this.btnItemDelete.Id = 2;
            this.btnItemDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemDelete.ImageOptions.Image")));
            this.btnItemDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemDelete.ImageOptions.LargeImage")));
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemDelete_ItemClick);
            // 
            // btnItemSave
            // 
            this.btnItemSave.Caption = "Lưu";
            this.btnItemSave.Enabled = false;
            this.btnItemSave.Id = 3;
            this.btnItemSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemSave.ImageOptions.Image")));
            this.btnItemSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemSave.ImageOptions.LargeImage")));
            this.btnItemSave.Name = "btnItemSave";
            this.btnItemSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemSave_ItemClick);
            // 
            // btnItemReload
            // 
            this.btnItemReload.Caption = "Reload";
            this.btnItemReload.Id = 4;
            this.btnItemReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemReload.ImageOptions.Image")));
            this.btnItemReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemReload.ImageOptions.LargeImage")));
            this.btnItemReload.Name = "btnItemReload";
            this.btnItemReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemReload_ItemClick);
            // 
            // btnItemUndo
            // 
            this.btnItemUndo.Caption = "Undo";
            this.btnItemUndo.Enabled = false;
            this.btnItemUndo.Id = 5;
            this.btnItemUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemUndo.ImageOptions.Image")));
            this.btnItemUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemUndo.ImageOptions.LargeImage")));
            this.btnItemUndo.Name = "btnItemUndo";
            this.btnItemUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemUndo_ItemClick);
            // 
            // btnItemExit
            // 
            this.btnItemExit.Caption = "Thoát";
            this.btnItemExit.Id = 6;
            this.btnItemExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemExit.ImageOptions.Image")));
            this.btnItemExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemExit.ImageOptions.LargeImage")));
            this.btnItemExit.Name = "btnItemExit";
            this.btnItemExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 576);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 546);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 546);
            // 
            // txtTenBST
            // 
            this.txtTenBST.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBST, "TENBST", true));
            this.txtTenBST.Location = new System.Drawing.Point(1157, 94);
            this.txtTenBST.MenuManager = this.barManager1;
            this.txtTenBST.Name = "txtTenBST";
            this.txtTenBST.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBST.Properties.Appearance.Options.UseFont = true;
            this.txtTenBST.Size = new System.Drawing.Size(282, 32);
            this.txtTenBST.TabIndex = 3;
            // 
            // txtIDBST
            // 
            this.txtIDBST.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBST, "IDBST", true));
            this.txtIDBST.Location = new System.Drawing.Point(397, 88);
            this.txtIDBST.MenuManager = this.barManager1;
            this.txtIDBST.Name = "txtIDBST";
            this.txtIDBST.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBST.Properties.Appearance.Options.UseFont = true;
            this.txtIDBST.Size = new System.Drawing.Size(324, 32);
            this.txtIDBST.TabIndex = 1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = null;
            this.tableAdapterManager.CT_CUOCTRIENLAMTableAdapter = null;
            this.tableAdapterManager.CUOCTRIENLAMTableAdapter = null;
            this.tableAdapterManager.DIEUKHACVATACTUONGTableAdapter = null;
            this.tableAdapterManager.HOIHOATableAdapter = null;
            this.tableAdapterManager.LOAIDIMUONTableAdapter = this.LOAIDIMUONTableAdapter;
            this.tableAdapterManager.LOAIHINHKHACTableAdapter = null;
            this.tableAdapterManager.LOAISOHUUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.NHANVIENTableAdapter;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TPNTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LOAIDIMUONTableAdapter
            // 
            this.LOAIDIMUONTableAdapter.ClearBeforeFill = true;
            // 
            // NHANVIENTableAdapter
            // 
            this.NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // BOSUUTAPTableAdapter
            // 
            this.BOSUUTAPTableAdapter.ClearBeforeFill = true;
            // 
            // gctBST
            // 
            this.gctBST.DataSource = this.bdsBST;
            this.gctBST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctBST.Location = new System.Drawing.Point(0, 30);
            this.gctBST.MainView = this.gridView1;
            this.gctBST.MenuManager = this.barManager1;
            this.gctBST.Name = "gctBST";
            this.gctBST.Size = new System.Drawing.Size(1924, 193);
            this.gctBST.TabIndex = 9;
            this.gctBST.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDBST,
            this.colTENBST,
            this.colHINHTHUCSUUTAP,
            this.colMANV});
            this.gridView1.GridControl = this.gctBST;
            this.gridView1.Name = "gridView1";
            // 
            // colIDBST
            // 
            this.colIDBST.FieldName = "IDBST";
            this.colIDBST.MinWidth = 25;
            this.colIDBST.Name = "colIDBST";
            this.colIDBST.Visible = true;
            this.colIDBST.VisibleIndex = 0;
            this.colIDBST.Width = 94;
            // 
            // colTENBST
            // 
            this.colTENBST.FieldName = "TENBST";
            this.colTENBST.MinWidth = 25;
            this.colTENBST.Name = "colTENBST";
            this.colTENBST.Visible = true;
            this.colTENBST.VisibleIndex = 1;
            this.colTENBST.Width = 94;
            // 
            // colHINHTHUCSUUTAP
            // 
            this.colHINHTHUCSUUTAP.FieldName = "HINHTHUCSUUTAP";
            this.colHINHTHUCSUUTAP.MinWidth = 25;
            this.colHINHTHUCSUUTAP.Name = "colHINHTHUCSUUTAP";
            this.colHINHTHUCSUUTAP.Visible = true;
            this.colHINHTHUCSUUTAP.VisibleIndex = 2;
            this.colHINHTHUCSUUTAP.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // FrmBoSuuTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 576);
            this.Controls.Add(this.gctBST);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmBoSuuTap";
            this.Text = "Bộ Sưu Tập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBoSuuTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHTST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDBST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOAIDIMUONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctBST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlDetail;
        private BAOTANGDataSet BAOTANGDataSet;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BAOTANGDataSetTableAdapters.LOAIDIMUONTableAdapter LOAIDIMUONTableAdapter;
        private System.Windows.Forms.BindingSource LOAIDIMUONBindingSource;
        private BAOTANGDataSetTableAdapters.NHANVIENTableAdapter NHANVIENTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource NHANVIENBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnItemAdd;
        private DevExpress.XtraBars.BarButtonItem btnItemEdit;
        private DevExpress.XtraBars.BarButtonItem btnItemDelete;
        private DevExpress.XtraBars.BarButtonItem btnItemSave;
        private DevExpress.XtraBars.BarButtonItem btnItemReload;
        private DevExpress.XtraBars.BarButtonItem btnItemUndo;
        private DevExpress.XtraBars.BarButtonItem btnItemExit;
        private System.Windows.Forms.BindingSource bdsBST;
        private BAOTANGDataSetTableAdapters.BOSUUTAPTableAdapter BOSUUTAPTableAdapter;
        private DevExpress.XtraGrid.GridControl gctBST;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDBST;
        private DevExpress.XtraGrid.Columns.GridColumn colTENBST;
        private DevExpress.XtraGrid.Columns.GridColumn colHINHTHUCSUUTAP;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraEditors.TextEdit txtHTST;
        private DevExpress.XtraEditors.TextEdit txtTenBST;
        private DevExpress.XtraEditors.TextEdit txtIDBST;
        private System.Windows.Forms.ComboBox cmbMANV;
    }
}