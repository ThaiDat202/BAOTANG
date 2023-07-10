namespace BAOTANG
{
    partial class FrmTacGia
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
            System.Windows.Forms.Label tENTACGIALabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label nGAYMATLabel;
            System.Windows.Forms.Label qUOCTICHLabel;
            System.Windows.Forms.Label tHOIDAILabel;
            System.Windows.Forms.Label pHONGCACHLabel;
            System.Windows.Forms.Label lOIDIENGIAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTacGia));
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
            this.bdsTG = new System.Windows.Forms.BindingSource(this.components);
            this.BAOTANGDataSet = new BAOTANG.BAOTANGDataSet();
            this.TACGIATableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.TACGIATableAdapter();
            this.tableAdapterManager = new BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.TPNTTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.TPNTTableAdapter();
            this.TPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIDTG = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTG = new DevExpress.XtraEditors.TextEdit();
            this.dtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.dtNgayMat = new DevExpress.XtraEditors.DateEdit();
            this.txtQuocTich = new DevExpress.XtraEditors.TextEdit();
            this.txtThoiDai = new DevExpress.XtraEditors.TextEdit();
            this.txtPhongCach = new DevExpress.XtraEditors.TextEdit();
            this.txtLoiDienGiai = new DevExpress.XtraEditors.TextEdit();
            this.pnlDetail = new DevExpress.XtraEditors.PanelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDTACGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTACGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUOCTICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIDAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONGCACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOIDIENGIAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctTG = new DevExpress.XtraGrid.GridControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            iDTACGIALabel = new System.Windows.Forms.Label();
            tENTACGIALabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            nGAYMATLabel = new System.Windows.Forms.Label();
            qUOCTICHLabel = new System.Windows.Forms.Label();
            tHOIDAILabel = new System.Windows.Forms.Label();
            pHONGCACHLabel = new System.Windows.Forms.Label();
            lOIDIENGIAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDTG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuocTich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiDai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhongCach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoiDienGiai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctTG)).BeginInit();
            this.SuspendLayout();
            // 
            // iDTACGIALabel
            // 
            iDTACGIALabel.AutoSize = true;
            iDTACGIALabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDTACGIALabel.Location = new System.Drawing.Point(114, 45);
            iDTACGIALabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            iDTACGIALabel.Name = "iDTACGIALabel";
            iDTACGIALabel.Size = new System.Drawing.Size(125, 26);
            iDTACGIALabel.TabIndex = 0;
            iDTACGIALabel.Text = "IDTACGIA:";
            // 
            // tENTACGIALabel
            // 
            tENTACGIALabel.AutoSize = true;
            tENTACGIALabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENTACGIALabel.Location = new System.Drawing.Point(712, 45);
            tENTACGIALabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            tENTACGIALabel.Name = "tENTACGIALabel";
            tENTACGIALabel.Size = new System.Drawing.Size(144, 26);
            tENTACGIALabel.TabIndex = 2;
            tENTACGIALabel.Text = "TENTACGIA:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYSINHLabel.Location = new System.Drawing.Point(1367, 45);
            nGAYSINHLabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(132, 26);
            nGAYSINHLabel.TabIndex = 4;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // nGAYMATLabel
            // 
            nGAYMATLabel.AutoSize = true;
            nGAYMATLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYMATLabel.Location = new System.Drawing.Point(114, 171);
            nGAYMATLabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            nGAYMATLabel.Name = "nGAYMATLabel";
            nGAYMATLabel.Size = new System.Drawing.Size(125, 26);
            nGAYMATLabel.TabIndex = 6;
            nGAYMATLabel.Text = "NGAYMAT:";
            // 
            // qUOCTICHLabel
            // 
            qUOCTICHLabel.AutoSize = true;
            qUOCTICHLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qUOCTICHLabel.Location = new System.Drawing.Point(722, 171);
            qUOCTICHLabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            qUOCTICHLabel.Name = "qUOCTICHLabel";
            qUOCTICHLabel.Size = new System.Drawing.Size(134, 26);
            qUOCTICHLabel.TabIndex = 8;
            qUOCTICHLabel.Text = "QUOCTICH:";
            // 
            // tHOIDAILabel
            // 
            tHOIDAILabel.AutoSize = true;
            tHOIDAILabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tHOIDAILabel.Location = new System.Drawing.Point(1387, 171);
            tHOIDAILabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            tHOIDAILabel.Name = "tHOIDAILabel";
            tHOIDAILabel.Size = new System.Drawing.Size(112, 26);
            tHOIDAILabel.TabIndex = 10;
            tHOIDAILabel.Text = "THOIDAI:";
            // 
            // pHONGCACHLabel
            // 
            pHONGCACHLabel.AutoSize = true;
            pHONGCACHLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHONGCACHLabel.Location = new System.Drawing.Point(83, 305);
            pHONGCACHLabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            pHONGCACHLabel.Name = "pHONGCACHLabel";
            pHONGCACHLabel.Size = new System.Drawing.Size(156, 26);
            pHONGCACHLabel.TabIndex = 12;
            pHONGCACHLabel.Text = "PHONGCACH:";
            // 
            // lOIDIENGIAILabel
            // 
            lOIDIENGIAILabel.AutoSize = true;
            lOIDIENGIAILabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lOIDIENGIAILabel.Location = new System.Drawing.Point(699, 305);
            lOIDIENGIAILabel.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            lOIDIENGIAILabel.Name = "lOIDIENGIAILabel";
            lOIDIENGIAILabel.Size = new System.Drawing.Size(157, 26);
            lOIDIENGIAILabel.TabIndex = 14;
            lOIDIENGIAILabel.Text = "LOIDIENGIAI:";
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 742);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 712);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 712);
            // 
            // bdsTG
            // 
            this.bdsTG.DataMember = "TACGIA";
            this.bdsTG.DataSource = this.BAOTANGDataSet;
            // 
            // BAOTANGDataSet
            // 
            this.BAOTANGDataSet.DataSetName = "BAOTANGDataSet";
            this.BAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TACGIATableAdapter
            // 
            this.TACGIATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TACGIATableAdapter = this.TACGIATableAdapter;
            this.tableAdapterManager.TPNTTableAdapter = this.TPNTTableAdapter;
            this.tableAdapterManager.UpdateOrder = BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TPNTTableAdapter
            // 
            this.TPNTTableAdapter.ClearBeforeFill = true;
            // 
            // TPNTBindingSource
            // 
            this.TPNTBindingSource.DataMember = "FK_TACGIA";
            this.TPNTBindingSource.DataSource = this.bdsTG;
            // 
            // txtIDTG
            // 
            this.txtIDTG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTG, "IDTACGIA", true));
            this.txtIDTG.Location = new System.Drawing.Point(295, 42);
            this.txtIDTG.Margin = new System.Windows.Forms.Padding(15);
            this.txtIDTG.MenuManager = this.barManager1;
            this.txtIDTG.Name = "txtIDTG";
            this.txtIDTG.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDTG.Properties.Appearance.Options.UseFont = true;
            this.txtIDTG.Size = new System.Drawing.Size(300, 32);
            this.txtIDTG.TabIndex = 1;
            // 
            // txtTenTG
            // 
            this.txtTenTG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTG, "TENTACGIA", true));
            this.txtTenTG.Location = new System.Drawing.Point(945, 42);
            this.txtTenTG.Margin = new System.Windows.Forms.Padding(15);
            this.txtTenTG.MenuManager = this.barManager1;
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTG.Properties.Appearance.Options.UseFont = true;
            this.txtTenTG.Size = new System.Drawing.Size(338, 32);
            this.txtTenTG.TabIndex = 3;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTG, "NGAYSINH", true));
            this.dtNgaySinh.EditValue = null;
            this.dtNgaySinh.Location = new System.Drawing.Point(1563, 42);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(15);
            this.dtNgaySinh.MenuManager = this.barManager1;
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.dtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaySinh.Size = new System.Drawing.Size(259, 32);
            this.dtNgaySinh.TabIndex = 5;
            // 
            // dtNgayMat
            // 
            this.dtNgayMat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTG, "NGAYMAT", true));
            this.dtNgayMat.EditValue = null;
            this.dtNgayMat.Location = new System.Drawing.Point(295, 168);
            this.dtNgayMat.Margin = new System.Windows.Forms.Padding(15);
            this.dtNgayMat.MenuManager = this.barManager1;
            this.dtNgayMat.Name = "dtNgayMat";
            this.dtNgayMat.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayMat.Properties.Appearance.Options.UseFont = true;
            this.dtNgayMat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayMat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayMat.Size = new System.Drawing.Size(300, 32);
            this.dtNgayMat.TabIndex = 7;
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTG, "QUOCTICH", true));
            this.txtQuocTich.Location = new System.Drawing.Point(945, 168);
            this.txtQuocTich.Margin = new System.Windows.Forms.Padding(15);
            this.txtQuocTich.MenuManager = this.barManager1;
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuocTich.Properties.Appearance.Options.UseFont = true;
            this.txtQuocTich.Size = new System.Drawing.Size(338, 32);
            this.txtQuocTich.TabIndex = 9;
            // 
            // txtThoiDai
            // 
            this.txtThoiDai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTG, "THOIDAI", true));
            this.txtThoiDai.Location = new System.Drawing.Point(1563, 168);
            this.txtThoiDai.Margin = new System.Windows.Forms.Padding(15);
            this.txtThoiDai.MenuManager = this.barManager1;
            this.txtThoiDai.Name = "txtThoiDai";
            this.txtThoiDai.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiDai.Properties.Appearance.Options.UseFont = true;
            this.txtThoiDai.Size = new System.Drawing.Size(259, 32);
            this.txtThoiDai.TabIndex = 11;
            // 
            // txtPhongCach
            // 
            this.txtPhongCach.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTG, "PHONGCACH", true));
            this.txtPhongCach.Location = new System.Drawing.Point(295, 302);
            this.txtPhongCach.Margin = new System.Windows.Forms.Padding(15);
            this.txtPhongCach.MenuManager = this.barManager1;
            this.txtPhongCach.Name = "txtPhongCach";
            this.txtPhongCach.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhongCach.Properties.Appearance.Options.UseFont = true;
            this.txtPhongCach.Size = new System.Drawing.Size(300, 32);
            this.txtPhongCach.TabIndex = 13;
            // 
            // txtLoiDienGiai
            // 
            this.txtLoiDienGiai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTG, "LOIDIENGIAI", true));
            this.txtLoiDienGiai.Location = new System.Drawing.Point(945, 302);
            this.txtLoiDienGiai.Margin = new System.Windows.Forms.Padding(15);
            this.txtLoiDienGiai.MenuManager = this.barManager1;
            this.txtLoiDienGiai.Name = "txtLoiDienGiai";
            this.txtLoiDienGiai.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoiDienGiai.Properties.Appearance.Options.UseFont = true;
            this.txtLoiDienGiai.Size = new System.Drawing.Size(877, 32);
            this.txtLoiDienGiai.TabIndex = 15;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(lOIDIENGIAILabel);
            this.pnlDetail.Controls.Add(this.txtLoiDienGiai);
            this.pnlDetail.Controls.Add(pHONGCACHLabel);
            this.pnlDetail.Controls.Add(this.txtPhongCach);
            this.pnlDetail.Controls.Add(tHOIDAILabel);
            this.pnlDetail.Controls.Add(this.txtThoiDai);
            this.pnlDetail.Controls.Add(qUOCTICHLabel);
            this.pnlDetail.Controls.Add(this.txtQuocTich);
            this.pnlDetail.Controls.Add(nGAYMATLabel);
            this.pnlDetail.Controls.Add(this.dtNgayMat);
            this.pnlDetail.Controls.Add(nGAYSINHLabel);
            this.pnlDetail.Controls.Add(this.dtNgaySinh);
            this.pnlDetail.Controls.Add(tENTACGIALabel);
            this.pnlDetail.Controls.Add(this.txtTenTG);
            this.pnlDetail.Controls.Add(iDTACGIALabel);
            this.pnlDetail.Controls.Add(this.txtIDTG);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetail.Enabled = false;
            this.pnlDetail.Location = new System.Drawing.Point(0, 349);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(15);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1924, 393);
            this.pnlDetail.TabIndex = 4;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDTACGIA,
            this.colTENTACGIA,
            this.colNGAYSINH,
            this.colNGAYMAT,
            this.colQUOCTICH,
            this.colTHOIDAI,
            this.colPHONGCACH,
            this.colLOIDIENGIAI});
            this.gridView1.DetailHeight = 1331;
            this.gridView1.GridControl = this.gctTG;
            this.gridView1.Name = "gridView1";
            // 
            // colIDTACGIA
            // 
            this.colIDTACGIA.FieldName = "IDTACGIA";
            this.colIDTACGIA.MinWidth = 95;
            this.colIDTACGIA.Name = "colIDTACGIA";
            this.colIDTACGIA.Visible = true;
            this.colIDTACGIA.VisibleIndex = 0;
            this.colIDTACGIA.Width = 355;
            // 
            // colTENTACGIA
            // 
            this.colTENTACGIA.FieldName = "TENTACGIA";
            this.colTENTACGIA.MinWidth = 95;
            this.colTENTACGIA.Name = "colTENTACGIA";
            this.colTENTACGIA.Visible = true;
            this.colTENTACGIA.VisibleIndex = 1;
            this.colTENTACGIA.Width = 355;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 95;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 2;
            this.colNGAYSINH.Width = 355;
            // 
            // colNGAYMAT
            // 
            this.colNGAYMAT.FieldName = "NGAYMAT";
            this.colNGAYMAT.MinWidth = 95;
            this.colNGAYMAT.Name = "colNGAYMAT";
            this.colNGAYMAT.Visible = true;
            this.colNGAYMAT.VisibleIndex = 3;
            this.colNGAYMAT.Width = 355;
            // 
            // colQUOCTICH
            // 
            this.colQUOCTICH.FieldName = "QUOCTICH";
            this.colQUOCTICH.MinWidth = 95;
            this.colQUOCTICH.Name = "colQUOCTICH";
            this.colQUOCTICH.Visible = true;
            this.colQUOCTICH.VisibleIndex = 4;
            this.colQUOCTICH.Width = 355;
            // 
            // colTHOIDAI
            // 
            this.colTHOIDAI.FieldName = "THOIDAI";
            this.colTHOIDAI.MinWidth = 95;
            this.colTHOIDAI.Name = "colTHOIDAI";
            this.colTHOIDAI.Visible = true;
            this.colTHOIDAI.VisibleIndex = 5;
            this.colTHOIDAI.Width = 355;
            // 
            // colPHONGCACH
            // 
            this.colPHONGCACH.FieldName = "PHONGCACH";
            this.colPHONGCACH.MinWidth = 95;
            this.colPHONGCACH.Name = "colPHONGCACH";
            this.colPHONGCACH.Visible = true;
            this.colPHONGCACH.VisibleIndex = 6;
            this.colPHONGCACH.Width = 355;
            // 
            // colLOIDIENGIAI
            // 
            this.colLOIDIENGIAI.FieldName = "LOIDIENGIAI";
            this.colLOIDIENGIAI.MinWidth = 95;
            this.colLOIDIENGIAI.Name = "colLOIDIENGIAI";
            this.colLOIDIENGIAI.Visible = true;
            this.colLOIDIENGIAI.VisibleIndex = 7;
            this.colLOIDIENGIAI.Width = 355;
            // 
            // gctTG
            // 
            this.gctTG.DataSource = this.bdsTG;
            this.gctTG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctTG.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(15);
            this.gctTG.Location = new System.Drawing.Point(0, 30);
            this.gctTG.MainView = this.gridView1;
            this.gctTG.Margin = new System.Windows.Forms.Padding(15);
            this.gctTG.MenuManager = this.barManager1;
            this.gctTG.Name = "gctTG";
            this.gctTG.Size = new System.Drawing.Size(1924, 319);
            this.gctTG.TabIndex = 6;
            this.gctTG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // FrmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 742);
            this.Controls.Add(this.gctTG);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmTacGia";
            this.Text = "Tác Giả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDTG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuocTich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiDai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhongCach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoiDienGiai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsTG;
        private BAOTANGDataSet BAOTANGDataSet;
        private BAOTANGDataSetTableAdapters.TACGIATableAdapter TACGIATableAdapter;
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BAOTANGDataSetTableAdapters.TPNTTableAdapter TPNTTableAdapter;
        private System.Windows.Forms.BindingSource TPNTBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnItemAdd;
        private DevExpress.XtraBars.BarButtonItem btnItemEdit;
        private DevExpress.XtraBars.BarButtonItem btnItemDelete;
        private DevExpress.XtraBars.BarButtonItem btnItemSave;
        private DevExpress.XtraBars.BarButtonItem btnItemReload;
        private DevExpress.XtraBars.BarButtonItem btnItemUndo;
        private DevExpress.XtraBars.BarButtonItem btnItemExit;
        private DevExpress.XtraGrid.GridControl gctTG;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDTACGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTACGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMAT;
        private DevExpress.XtraGrid.Columns.GridColumn colQUOCTICH;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIDAI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHONGCACH;
        private DevExpress.XtraGrid.Columns.GridColumn colLOIDIENGIAI;
        private DevExpress.XtraEditors.PanelControl pnlDetail;
        private DevExpress.XtraEditors.TextEdit txtLoiDienGiai;
        private DevExpress.XtraEditors.TextEdit txtPhongCach;
        private DevExpress.XtraEditors.TextEdit txtThoiDai;
        private DevExpress.XtraEditors.TextEdit txtQuocTich;
        private DevExpress.XtraEditors.DateEdit dtNgayMat;
        private DevExpress.XtraEditors.DateEdit dtNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtTenTG;
        private DevExpress.XtraEditors.TextEdit txtIDTG;
        private DevExpress.XtraBars.Bar bar2;
    }
}