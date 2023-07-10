namespace BAOTANG
{
    partial class FrmCuocTrienLam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCuocTrienLam));
            this.gcnCTL = new DevExpress.XtraGrid.GridControl();
            this.cUOCTRIENLAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAOTANGDataSet = new BAOTANG.BAOTANGDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDCTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTRIENLAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYKETTHUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cUOCTRIENLAMTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.CUOCTRIENLAMTableAdapter();
            this.pcnDetail = new DevExpress.XtraEditors.PanelControl();
            this.deTo = new DevExpress.XtraEditors.DateEdit();
            this.deFrom = new DevExpress.XtraEditors.DateEdit();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.txtIDCLT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.TPNTTableAdapter();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcnTPNT = new DevExpress.XtraGrid.GridControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            iDCTLLabel = new System.Windows.Forms.Label();
            tENTRIENLAMLabel = new System.Windows.Forms.Label();
            nGAYBATDAULabel = new System.Windows.Forms.Label();
            nGAYKETTHUCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcnCTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUOCTRIENLAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcnDetail)).BeginInit();
            this.pcnDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcnTPNT)).BeginInit();
            this.SuspendLayout();
            // 
            // iDCTLLabel
            // 
            iDCTLLabel.AutoSize = true;
            iDCTLLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            iDCTLLabel.Location = new System.Drawing.Point(90, 117);
            iDCTLLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            iDCTLLabel.Name = "iDCTLLabel";
            iDCTLLabel.Size = new System.Drawing.Size(84, 26);
            iDCTLLabel.TabIndex = 18;
            iDCTLLabel.Text = "IDCTL:";
            // 
            // tENTRIENLAMLabel
            // 
            tENTRIENLAMLabel.AutoSize = true;
            tENTRIENLAMLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tENTRIENLAMLabel.Location = new System.Drawing.Point(968, 117);
            tENTRIENLAMLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tENTRIENLAMLabel.Name = "tENTRIENLAMLabel";
            tENTRIENLAMLabel.Size = new System.Drawing.Size(175, 26);
            tENTRIENLAMLabel.TabIndex = 19;
            tENTRIENLAMLabel.Text = "TENTRIENLAM:";
            // 
            // nGAYBATDAULabel
            // 
            nGAYBATDAULabel.AutoSize = true;
            nGAYBATDAULabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nGAYBATDAULabel.Location = new System.Drawing.Point(90, 216);
            nGAYBATDAULabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nGAYBATDAULabel.Name = "nGAYBATDAULabel";
            nGAYBATDAULabel.Size = new System.Drawing.Size(168, 26);
            nGAYBATDAULabel.TabIndex = 20;
            nGAYBATDAULabel.Text = "NGAYBATDAU:";
            // 
            // nGAYKETTHUCLabel
            // 
            nGAYKETTHUCLabel.AutoSize = true;
            nGAYKETTHUCLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nGAYKETTHUCLabel.Location = new System.Drawing.Point(961, 216);
            nGAYKETTHUCLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nGAYKETTHUCLabel.Name = "nGAYKETTHUCLabel";
            nGAYKETTHUCLabel.Size = new System.Drawing.Size(182, 26);
            nGAYKETTHUCLabel.TabIndex = 21;
            nGAYKETTHUCLabel.Text = "NGAYKETTHUC:";
            // 
            // gcnCTL
            // 
            this.gcnCTL.DataSource = this.cUOCTRIENLAMBindingSource;
            this.gcnCTL.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcnCTL.Location = new System.Drawing.Point(15, 110);
            this.gcnCTL.MainView = this.gridView1;
            this.gcnCTL.Margin = new System.Windows.Forms.Padding(6);
            this.gcnCTL.Name = "gcnCTL";
            this.gcnCTL.Size = new System.Drawing.Size(618, 401);
            this.gcnCTL.TabIndex = 0;
            this.gcnCTL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcnCTL.Click += new System.EventHandler(this.gcnCTL_Click);
            // 
            // cUOCTRIENLAMBindingSource
            // 
            this.cUOCTRIENLAMBindingSource.DataMember = "CUOCTRIENLAM";
            this.cUOCTRIENLAMBindingSource.DataSource = this.bAOTANGDataSet;
            // 
            // bAOTANGDataSet
            // 
            this.bAOTANGDataSet.DataSetName = "BAOTANGDataSet";
            this.bAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDCTL,
            this.colTENTRIENLAM,
            this.colNGAYBATDAU,
            this.colNGAYKETTHUC});
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.gcnCTL;
            this.gridView1.Name = "gridView1";
            // 
            // colIDCTL
            // 
            this.colIDCTL.FieldName = "IDCTL";
            this.colIDCTL.MinWidth = 39;
            this.colIDCTL.Name = "colIDCTL";
            this.colIDCTL.Visible = true;
            this.colIDCTL.VisibleIndex = 0;
            this.colIDCTL.Width = 146;
            // 
            // colTENTRIENLAM
            // 
            this.colTENTRIENLAM.FieldName = "TENTRIENLAM";
            this.colTENTRIENLAM.MinWidth = 39;
            this.colTENTRIENLAM.Name = "colTENTRIENLAM";
            this.colTENTRIENLAM.Visible = true;
            this.colTENTRIENLAM.VisibleIndex = 1;
            this.colTENTRIENLAM.Width = 146;
            // 
            // colNGAYBATDAU
            // 
            this.colNGAYBATDAU.FieldName = "NGAYBATDAU";
            this.colNGAYBATDAU.MinWidth = 39;
            this.colNGAYBATDAU.Name = "colNGAYBATDAU";
            this.colNGAYBATDAU.Visible = true;
            this.colNGAYBATDAU.VisibleIndex = 2;
            this.colNGAYBATDAU.Width = 146;
            // 
            // colNGAYKETTHUC
            // 
            this.colNGAYKETTHUC.FieldName = "NGAYKETTHUC";
            this.colNGAYKETTHUC.MinWidth = 39;
            this.colNGAYKETTHUC.Name = "colNGAYKETTHUC";
            this.colNGAYKETTHUC.Visible = true;
            this.colNGAYKETTHUC.VisibleIndex = 3;
            this.colNGAYKETTHUC.Width = 146;
            // 
            // cUOCTRIENLAMTableAdapter
            // 
            this.cUOCTRIENLAMTableAdapter.ClearBeforeFill = true;
            // 
            // pcnDetail
            // 
            this.pcnDetail.Controls.Add(nGAYKETTHUCLabel);
            this.pcnDetail.Controls.Add(this.deTo);
            this.pcnDetail.Controls.Add(nGAYBATDAULabel);
            this.pcnDetail.Controls.Add(this.deFrom);
            this.pcnDetail.Controls.Add(tENTRIENLAMLabel);
            this.pcnDetail.Controls.Add(this.txtTenTL);
            this.pcnDetail.Controls.Add(iDCTLLabel);
            this.pcnDetail.Controls.Add(this.txtIDCLT);
            this.pcnDetail.Controls.Add(this.label7);
            this.pcnDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcnDetail.Enabled = false;
            this.pcnDetail.Location = new System.Drawing.Point(0, 557);
            this.pcnDetail.Margin = new System.Windows.Forms.Padding(6);
            this.pcnDetail.Name = "pcnDetail";
            this.pcnDetail.Size = new System.Drawing.Size(1726, 271);
            this.pcnDetail.TabIndex = 2;
            // 
            // deTo
            // 
            this.deTo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cUOCTRIENLAMBindingSource, "NGAYKETTHUC", true));
            this.deTo.EditValue = null;
            this.deTo.Location = new System.Drawing.Point(1273, 213);
            this.deTo.Margin = new System.Windows.Forms.Padding(6);
            this.deTo.Name = "deTo";
            this.deTo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deTo.Properties.Appearance.Options.UseFont = true;
            this.deTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Size = new System.Drawing.Size(304, 32);
            this.deTo.TabIndex = 22;
            // 
            // deFrom
            // 
            this.deFrom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cUOCTRIENLAMBindingSource, "NGAYBATDAU", true));
            this.deFrom.EditValue = null;
            this.deFrom.Location = new System.Drawing.Point(438, 213);
            this.deFrom.Margin = new System.Windows.Forms.Padding(6);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deFrom.Properties.Appearance.Options.UseFont = true;
            this.deFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Size = new System.Drawing.Size(316, 32);
            this.deFrom.TabIndex = 21;
            // 
            // txtTenTL
            // 
            this.txtTenTL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUOCTRIENLAMBindingSource, "TENTRIENLAM", true));
            this.txtTenTL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenTL.Location = new System.Drawing.Point(1274, 114);
            this.txtTenTL.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(303, 34);
            this.txtTenTL.TabIndex = 20;
            // 
            // txtIDCLT
            // 
            this.txtIDCLT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUOCTRIENLAMBindingSource, "IDCTL", true));
            this.txtIDCLT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIDCLT.Location = new System.Drawing.Point(439, 114);
            this.txtIDCLT.Margin = new System.Windows.Forms.Padding(5);
            this.txtIDCLT.Name = "txtIDCLT";
            this.txtIDCLT.Size = new System.Drawing.Size(315, 34);
            this.txtIDCLT.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(18, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(455, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "CHI TIẾT CỦA CUỘC TRIỂN LÃM";
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
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnReload,
            this.btnThoat,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar1.Text = "Tools";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa ";
            this.btnSua.Enabled = false;
            this.btnSua.Id = 0;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 1;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Enabled = false;
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 3;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 4;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1726, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 828);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1726, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 798);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1726, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 798);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm Cuộc TL";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "CÁC CUỘC TRIỂN LÃM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(700, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "CHI TIẾT CÁC TPNT CỦA TRIỂN LÃM";
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
            // gridView2
            // 
            this.gridView2.GridControl = this.gcnTPNT;
            this.gridView2.Name = "gridView2";
            // 
            // gcnTPNT
            // 
            this.gcnTPNT.Location = new System.Drawing.Point(706, 110);
            this.gcnTPNT.MainView = this.gridView2;
            this.gcnTPNT.MenuManager = this.barManager1;
            this.gcnTPNT.Name = "gcnTPNT";
            this.gcnTPNT.Size = new System.Drawing.Size(656, 401);
            this.gcnTPNT.TabIndex = 30;
            this.gcnTPNT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // FrmCuocTrienLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 828);
            this.Controls.Add(this.gcnTPNT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcnDetail);
            this.Controls.Add(this.gcnCTL);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmCuocTrienLam";
            this.Text = "FrmCuocTrienLam";
            this.Load += new System.EventHandler(this.FrmCuocTrienLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcnCTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUOCTRIENLAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcnDetail)).EndInit();
            this.pcnDetail.ResumeLayout(false);
            this.pcnDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcnTPNT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcnCTL;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BAOTANGDataSet bAOTANGDataSet;
        private System.Windows.Forms.BindingSource cUOCTRIENLAMBindingSource;
        private BAOTANGDataSetTableAdapters.CUOCTRIENLAMTableAdapter cUOCTRIENLAMTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCTL;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTRIENLAM;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBATDAU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYKETTHUC;
        private DevExpress.XtraEditors.PanelControl pcnDetail;
        private DevExpress.XtraEditors.DateEdit deTo;
        private DevExpress.XtraEditors.DateEdit deFrom;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.TextBox txtIDCLT;
        private System.Windows.Forms.Label label7;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tPNTBindingSource;
        private BAOTANGDataSetTableAdapters.TPNTTableAdapter tPNTTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl gcnTPNT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.Bar bar2;
    }
}