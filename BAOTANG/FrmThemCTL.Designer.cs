namespace BAOTANG
{
    partial class FrmThemCTL
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
            System.Windows.Forms.Label iDCTLLabel;
            System.Windows.Forms.Label tENTRIENLAMLabel;
            System.Windows.Forms.Label nGAYBATDAULabel;
            System.Windows.Forms.Label nGAYKETTHUCLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemCTL));
            this.gcnTPNT = new DevExpress.XtraGrid.GridControl();
            this.vIEWTPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAOTANGDataSet = new BAOTANG.BAOTANGDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMATPNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTPNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTACGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHUDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vIEW_TPNTTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.VIEW_TPNTTableAdapter();
            this.pcnDetail = new DevExpress.XtraEditors.PanelControl();
            this.deTo = new DevExpress.XtraEditors.DateEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemTPNT = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaTPNT = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.deFrom = new DevExpress.XtraEditors.DateEdit();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.txtIDCTL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cUOCTRIENLAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUOCTRIENLAMTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.CUOCTRIENLAMTableAdapter();
            this.tableAdapterManager = new BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.tPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.TPNTTableAdapter();
            this.gcnTP = new System.Windows.Forms.DataGridView();
            iDCTLLabel = new System.Windows.Forms.Label();
            tENTRIENLAMLabel = new System.Windows.Forms.Label();
            nGAYBATDAULabel = new System.Windows.Forms.Label();
            nGAYKETTHUCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcnTPNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWTPNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcnDetail)).BeginInit();
            this.pcnDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUOCTRIENLAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcnTP)).BeginInit();
            this.SuspendLayout();
            // 
            // iDCTLLabel
            // 
            iDCTLLabel.AutoSize = true;
            iDCTLLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            iDCTLLabel.Location = new System.Drawing.Point(40, 141);
            iDCTLLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDCTLLabel.Name = "iDCTLLabel";
            iDCTLLabel.Size = new System.Drawing.Size(84, 26);
            iDCTLLabel.TabIndex = 19;
            iDCTLLabel.Text = "IDCTL:";
            // 
            // tENTRIENLAMLabel
            // 
            tENTRIENLAMLabel.AutoSize = true;
            tENTRIENLAMLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tENTRIENLAMLabel.Location = new System.Drawing.Point(716, 141);
            tENTRIENLAMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENTRIENLAMLabel.Name = "tENTRIENLAMLabel";
            tENTRIENLAMLabel.Size = new System.Drawing.Size(175, 26);
            tENTRIENLAMLabel.TabIndex = 20;
            tENTRIENLAMLabel.Text = "TENTRIENLAM:";
            // 
            // nGAYBATDAULabel
            // 
            nGAYBATDAULabel.AutoSize = true;
            nGAYBATDAULabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nGAYBATDAULabel.Location = new System.Drawing.Point(40, 246);
            nGAYBATDAULabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYBATDAULabel.Name = "nGAYBATDAULabel";
            nGAYBATDAULabel.Size = new System.Drawing.Size(168, 26);
            nGAYBATDAULabel.TabIndex = 21;
            nGAYBATDAULabel.Text = "NGAYBATDAU:";
            // 
            // nGAYKETTHUCLabel
            // 
            nGAYKETTHUCLabel.AutoSize = true;
            nGAYKETTHUCLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nGAYKETTHUCLabel.Location = new System.Drawing.Point(709, 246);
            nGAYKETTHUCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYKETTHUCLabel.Name = "nGAYKETTHUCLabel";
            nGAYKETTHUCLabel.Size = new System.Drawing.Size(182, 26);
            nGAYKETTHUCLabel.TabIndex = 22;
            nGAYKETTHUCLabel.Text = "NGAYKETTHUC:";
            // 
            // gcnTPNT
            // 
            this.gcnTPNT.DataSource = this.vIEWTPNTBindingSource;
            this.gcnTPNT.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcnTPNT.Location = new System.Drawing.Point(25, 105);
            this.gcnTPNT.MainView = this.gridView1;
            this.gcnTPNT.Margin = new System.Windows.Forms.Padding(4);
            this.gcnTPNT.Name = "gcnTPNT";
            this.gcnTPNT.Size = new System.Drawing.Size(632, 393);
            this.gcnTPNT.TabIndex = 0;
            this.gcnTPNT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vIEWTPNTBindingSource
            // 
            this.vIEWTPNTBindingSource.DataMember = "VIEW_TPNT";
            this.vIEWTPNTBindingSource.DataSource = this.bAOTANGDataSet;
            // 
            // bAOTANGDataSet
            // 
            this.bAOTANGDataSet.DataSetName = "BAOTANGDataSet";
            this.bAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMATPNT,
            this.colTENTPNT,
            this.colTENTACGIA,
            this.colCHUDE});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcnTPNT;
            this.gridView1.Name = "gridView1";
            // 
            // colMATPNT
            // 
            this.colMATPNT.FieldName = "MATPNT";
            this.colMATPNT.MinWidth = 31;
            this.colMATPNT.Name = "colMATPNT";
            this.colMATPNT.Visible = true;
            this.colMATPNT.VisibleIndex = 0;
            this.colMATPNT.Width = 117;
            // 
            // colTENTPNT
            // 
            this.colTENTPNT.FieldName = "TENTPNT";
            this.colTENTPNT.MinWidth = 31;
            this.colTENTPNT.Name = "colTENTPNT";
            this.colTENTPNT.Visible = true;
            this.colTENTPNT.VisibleIndex = 1;
            this.colTENTPNT.Width = 117;
            // 
            // colTENTACGIA
            // 
            this.colTENTACGIA.FieldName = "TENTACGIA";
            this.colTENTACGIA.MinWidth = 31;
            this.colTENTACGIA.Name = "colTENTACGIA";
            this.colTENTACGIA.Visible = true;
            this.colTENTACGIA.VisibleIndex = 2;
            this.colTENTACGIA.Width = 117;
            // 
            // colCHUDE
            // 
            this.colCHUDE.FieldName = "CHUDE";
            this.colCHUDE.MinWidth = 31;
            this.colCHUDE.Name = "colCHUDE";
            this.colCHUDE.Visible = true;
            this.colCHUDE.VisibleIndex = 3;
            this.colCHUDE.Width = 117;
            // 
            // vIEW_TPNTTableAdapter
            // 
            this.vIEW_TPNTTableAdapter.ClearBeforeFill = true;
            // 
            // pcnDetail
            // 
            this.pcnDetail.Controls.Add(this.deTo);
            this.pcnDetail.Controls.Add(this.deFrom);
            this.pcnDetail.Controls.Add(this.txtTenTL);
            this.pcnDetail.Controls.Add(this.txtIDCTL);
            this.pcnDetail.Controls.Add(nGAYKETTHUCLabel);
            this.pcnDetail.Controls.Add(nGAYBATDAULabel);
            this.pcnDetail.Controls.Add(tENTRIENLAMLabel);
            this.pcnDetail.Controls.Add(iDCTLLabel);
            this.pcnDetail.Controls.Add(this.label7);
            this.pcnDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcnDetail.Enabled = false;
            this.pcnDetail.Location = new System.Drawing.Point(0, 498);
            this.pcnDetail.Margin = new System.Windows.Forms.Padding(4);
            this.pcnDetail.Name = "pcnDetail";
            this.pcnDetail.Size = new System.Drawing.Size(1493, 340);
            this.pcnDetail.TabIndex = 2;
            // 
            // deTo
            // 
            this.deTo.EditValue = null;
            this.deTo.Location = new System.Drawing.Point(1032, 243);
            this.deTo.Margin = new System.Windows.Forms.Padding(4);
            this.deTo.MenuManager = this.barManager1;
            this.deTo.Name = "deTo";
            this.deTo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deTo.Properties.Appearance.Options.UseFont = true;
            this.deTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Size = new System.Drawing.Size(314, 32);
            this.deTo.TabIndex = 26;
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
            this.btnThemTPNT,
            this.btnXoaTPNT,
            this.btnReload,
            this.btnThoat,
            this.btnThem});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemTPNT),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaTPNT),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar1.Text = "Tools";
            // 
            // btnThemTPNT
            // 
            this.btnThemTPNT.Caption = "Thêm TPNT";
            this.btnThemTPNT.Enabled = false;
            this.btnThemTPNT.Id = 0;
            this.btnThemTPNT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTPNT.ImageOptions.Image")));
            this.btnThemTPNT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemTPNT.ImageOptions.LargeImage")));
            this.btnThemTPNT.Name = "btnThemTPNT";
            this.btnThemTPNT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThemTPNT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemTPNT_ItemClick);
            // 
            // btnXoaTPNT
            // 
            this.btnXoaTPNT.Caption = "Bỏ TPNT";
            this.btnXoaTPNT.Enabled = false;
            this.btnXoaTPNT.Id = 1;
            this.btnXoaTPNT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTPNT.ImageOptions.Image")));
            this.btnXoaTPNT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaTPNT.ImageOptions.LargeImage")));
            this.btnXoaTPNT.Name = "btnXoaTPNT";
            this.btnXoaTPNT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoaTPNT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaTPNT_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 2;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm Cuộc TL";
            this.btnThem.Enabled = false;
            this.btnThem.Id = 4;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 3;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1493, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 838);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1493, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 808);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1493, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 808);
            // 
            // deFrom
            // 
            this.deFrom.EditValue = null;
            this.deFrom.Location = new System.Drawing.Point(340, 243);
            this.deFrom.Margin = new System.Windows.Forms.Padding(4);
            this.deFrom.MenuManager = this.barManager1;
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deFrom.Properties.Appearance.Options.UseFont = true;
            this.deFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Size = new System.Drawing.Size(296, 32);
            this.deFrom.TabIndex = 25;
            // 
            // txtTenTL
            // 
            this.txtTenTL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenTL.Location = new System.Drawing.Point(1032, 138);
            this.txtTenTL.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(313, 34);
            this.txtTenTL.TabIndex = 24;
            // 
            // txtIDCTL
            // 
            this.txtIDCTL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIDCTL.Location = new System.Drawing.Point(340, 138);
            this.txtIDCTL.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDCTL.Name = "txtIDCTL";
            this.txtIDCTL.Size = new System.Drawing.Size(295, 34);
            this.txtIDCTL.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(39, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(455, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "CHI TIẾT CỦA CUỘC TRIỂN LÃM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "CHI TIẾT CÁC TÁC PHẨM NGHỆ THUẬT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(747, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "CÁC TPNT TRONG CUỘC TRIỂN LÃM";
            // 
            // cUOCTRIENLAMBindingSource
            // 
            this.cUOCTRIENLAMBindingSource.DataMember = "CUOCTRIENLAM";
            this.cUOCTRIENLAMBindingSource.DataSource = this.bAOTANGDataSet;
            // 
            // cUOCTRIENLAMTableAdapter
            // 
            this.cUOCTRIENLAMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = null;
            this.tableAdapterManager.CT_CUOCTRIENLAMTableAdapter = null;
            this.tableAdapterManager.CUOCTRIENLAMTableAdapter = this.cUOCTRIENLAMTableAdapter;
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
            // tPNTBindingSource
            // 
            this.tPNTBindingSource.DataMember = "TPNT";
            this.tPNTBindingSource.DataSource = this.bAOTANGDataSet;
            // 
            // tPNTTableAdapter
            // 
            this.tPNTTableAdapter.ClearBeforeFill = true;
            // 
            // gcnTP
            // 
            this.gcnTP.AllowUserToAddRows = false;
            this.gcnTP.AllowUserToDeleteRows = false;
            this.gcnTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gcnTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcnTP.Location = new System.Drawing.Point(753, 105);
            this.gcnTP.Name = "gcnTP";
            this.gcnTP.ReadOnly = true;
            this.gcnTP.RowHeadersWidth = 51;
            this.gcnTP.RowTemplate.Height = 24;
            this.gcnTP.Size = new System.Drawing.Size(648, 393);
            this.gcnTP.TabIndex = 36;
            // 
            // FrmThemCTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1514, 832);
            this.Controls.Add(this.gcnTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcnDetail);
            this.Controls.Add(this.gcnTPNT);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmThemCTL";
            this.Text = "Thêm Cuộc Triển Lãm";
            this.Load += new System.EventHandler(this.FrmThemCTL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcnTPNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWTPNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcnDetail)).EndInit();
            this.pcnDetail.ResumeLayout(false);
            this.pcnDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUOCTRIENLAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcnTP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcnTPNT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BAOTANGDataSet bAOTANGDataSet;
        private System.Windows.Forms.BindingSource vIEWTPNTBindingSource;
        private BAOTANGDataSetTableAdapters.VIEW_TPNTTableAdapter vIEW_TPNTTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMATPNT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTPNT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTACGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colCHUDE;
        private DevExpress.XtraEditors.PanelControl pcnDetail;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThemTPNT;
        private DevExpress.XtraBars.BarButtonItem btnXoaTPNT;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource cUOCTRIENLAMBindingSource;
        private BAOTANGDataSetTableAdapters.CUOCTRIENLAMTableAdapter cUOCTRIENLAMTableAdapter;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.DateEdit deTo;
        private DevExpress.XtraEditors.DateEdit deFrom;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.TextBox txtIDCTL;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private System.Windows.Forms.BindingSource tPNTBindingSource;
        private BAOTANGDataSetTableAdapters.TPNTTableAdapter tPNTTableAdapter;
        private System.Windows.Forms.DataGridView gcnTP;
    }
}