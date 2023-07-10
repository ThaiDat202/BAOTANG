namespace BAOTANG
{
    partial class FrmLoaiHinhKhac
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
            System.Windows.Forms.Label mÃ_TPNTLabel;
            System.Windows.Forms.Label tÊN_TPNTLabel;
            System.Windows.Forms.Label nĂM_SÁNG_TÁCLabel;
            System.Windows.Forms.Label cHỦ_ĐỀLabel;
            System.Windows.Forms.Label tÊN_TÁC_GIẢLabel;
            System.Windows.Forms.Label tHỂ_LOẠILabel;
            System.Windows.Forms.Label pHONG_CÁCHLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoaiHinhKhac));
            this.pnlDetail = new DevExpress.XtraEditors.PanelControl();
            this.cmbTenTG = new System.Windows.Forms.ComboBox();
            this.vIEW_LOAIHINHKHACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BAOTANGDataSet = new BAOTANG.BAOTANGDataSet();
            this.tACGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPhongCach = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemReadMore = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtTheLoai = new DevExpress.XtraEditors.TextEdit();
            this.txtChuDe = new DevExpress.XtraEditors.TextEdit();
            this.txtNamSangTac = new DevExpress.XtraEditors.TextEdit();
            this.txtTENTPNT = new DevExpress.XtraEditors.TextEdit();
            this.txtMATPNT = new DevExpress.XtraEditors.TextEdit();
            this.tableAdapterManager = new BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.tACGIATableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.TACGIATableAdapter();
            this.vIEW_LOAIHINHKHACTableAdapter = new BAOTANG.BAOTANGDataSetTableAdapters.VIEW_LOAIHINHKHACTableAdapter();
            this.vIEW_LOAIHINHKHACDataGridView = new System.Windows.Forms.DataGridView();
            this.MATPNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mÃ_TPNTLabel = new System.Windows.Forms.Label();
            tÊN_TPNTLabel = new System.Windows.Forms.Label();
            nĂM_SÁNG_TÁCLabel = new System.Windows.Forms.Label();
            cHỦ_ĐỀLabel = new System.Windows.Forms.Label();
            tÊN_TÁC_GIẢLabel = new System.Windows.Forms.Label();
            tHỂ_LOẠILabel = new System.Windows.Forms.Label();
            pHONG_CÁCHLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_LOAIHINHKHACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhongCach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamSangTac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENTPNT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMATPNT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_LOAIHINHKHACDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mÃ_TPNTLabel
            // 
            mÃ_TPNTLabel.AutoSize = true;
            mÃ_TPNTLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mÃ_TPNTLabel.Location = new System.Drawing.Point(414, 167);
            mÃ_TPNTLabel.Name = "mÃ_TPNTLabel";
            mÃ_TPNTLabel.Size = new System.Drawing.Size(116, 26);
            mÃ_TPNTLabel.TabIndex = 0;
            mÃ_TPNTLabel.Text = "MÃ TPNT:";
            // 
            // tÊN_TPNTLabel
            // 
            tÊN_TPNTLabel.AutoSize = true;
            tÊN_TPNTLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tÊN_TPNTLabel.Location = new System.Drawing.Point(956, 167);
            tÊN_TPNTLabel.Name = "tÊN_TPNTLabel";
            tÊN_TPNTLabel.Size = new System.Drawing.Size(124, 26);
            tÊN_TPNTLabel.TabIndex = 2;
            tÊN_TPNTLabel.Text = "TÊN TPNT:";
            // 
            // nĂM_SÁNG_TÁCLabel
            // 
            nĂM_SÁNG_TÁCLabel.AutoSize = true;
            nĂM_SÁNG_TÁCLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nĂM_SÁNG_TÁCLabel.Location = new System.Drawing.Point(214, 305);
            nĂM_SÁNG_TÁCLabel.Name = "nĂM_SÁNG_TÁCLabel";
            nĂM_SÁNG_TÁCLabel.Size = new System.Drawing.Size(189, 26);
            nĂM_SÁNG_TÁCLabel.TabIndex = 4;
            nĂM_SÁNG_TÁCLabel.Text = "NĂM SÁNG TÁC:";
            // 
            // cHỦ_ĐỀLabel
            // 
            cHỦ_ĐỀLabel.AutoSize = true;
            cHỦ_ĐỀLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cHỦ_ĐỀLabel.Location = new System.Drawing.Point(745, 305);
            cHỦ_ĐỀLabel.Name = "cHỦ_ĐỀLabel";
            cHỦ_ĐỀLabel.Size = new System.Drawing.Size(99, 26);
            cHỦ_ĐỀLabel.TabIndex = 6;
            cHỦ_ĐỀLabel.Text = "CHỦ ĐỀ:";
            // 
            // tÊN_TÁC_GIẢLabel
            // 
            tÊN_TÁC_GIẢLabel.AutoSize = true;
            tÊN_TÁC_GIẢLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tÊN_TÁC_GIẢLabel.Location = new System.Drawing.Point(1322, 305);
            tÊN_TÁC_GIẢLabel.Name = "tÊN_TÁC_GIẢLabel";
            tÊN_TÁC_GIẢLabel.Size = new System.Drawing.Size(160, 26);
            tÊN_TÁC_GIẢLabel.TabIndex = 8;
            tÊN_TÁC_GIẢLabel.Text = "TÊN TÁC GIẢ:";
            // 
            // tHỂ_LOẠILabel
            // 
            tHỂ_LOẠILabel.AutoSize = true;
            tHỂ_LOẠILabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tHỂ_LOẠILabel.Location = new System.Drawing.Point(283, 447);
            tHỂ_LOẠILabel.Name = "tHỂ_LOẠILabel";
            tHỂ_LOẠILabel.Size = new System.Drawing.Size(120, 26);
            tHỂ_LOẠILabel.TabIndex = 10;
            tHỂ_LOẠILabel.Text = "THỂ LOẠI:";
            // 
            // pHONG_CÁCHLabel
            // 
            pHONG_CÁCHLabel.AutoSize = true;
            pHONG_CÁCHLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHONG_CÁCHLabel.Location = new System.Drawing.Point(1010, 447);
            pHONG_CÁCHLabel.Name = "pHONG_CÁCHLabel";
            pHONG_CÁCHLabel.Size = new System.Drawing.Size(163, 26);
            pHONG_CÁCHLabel.TabIndex = 12;
            pHONG_CÁCHLabel.Text = "PHONG CÁCH:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(738, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(719, 37);
            label1.TabIndex = 19;
            label1.Text = "TÁC PHẨM NGHỆ THUẬT LOẠI HÌNH KHÁC";
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.cmbTenTG);
            this.pnlDetail.Controls.Add(label1);
            this.pnlDetail.Controls.Add(pHONG_CÁCHLabel);
            this.pnlDetail.Controls.Add(this.txtPhongCach);
            this.pnlDetail.Controls.Add(tHỂ_LOẠILabel);
            this.pnlDetail.Controls.Add(this.txtTheLoai);
            this.pnlDetail.Controls.Add(tÊN_TÁC_GIẢLabel);
            this.pnlDetail.Controls.Add(cHỦ_ĐỀLabel);
            this.pnlDetail.Controls.Add(this.txtChuDe);
            this.pnlDetail.Controls.Add(nĂM_SÁNG_TÁCLabel);
            this.pnlDetail.Controls.Add(this.txtNamSangTac);
            this.pnlDetail.Controls.Add(tÊN_TPNTLabel);
            this.pnlDetail.Controls.Add(this.txtTENTPNT);
            this.pnlDetail.Controls.Add(mÃ_TPNTLabel);
            this.pnlDetail.Controls.Add(this.txtMATPNT);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetail.Enabled = false;
            this.pnlDetail.Location = new System.Drawing.Point(0, 273);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1924, 555);
            this.pnlDetail.TabIndex = 0;
            // 
            // cmbTenTG
            // 
            this.cmbTenTG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vIEW_LOAIHINHKHACBindingSource, "TÊN TÁC GIẢ", true));
            this.cmbTenTG.DataSource = this.tACGIABindingSource;
            this.cmbTenTG.DisplayMember = "TENTACGIA";
            this.cmbTenTG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenTG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenTG.FormattingEnabled = true;
            this.cmbTenTG.Location = new System.Drawing.Point(1562, 302);
            this.cmbTenTG.Name = "cmbTenTG";
            this.cmbTenTG.Size = new System.Drawing.Size(281, 34);
            this.cmbTenTG.TabIndex = 20;
            this.cmbTenTG.ValueMember = "IDTACGIA";
            // 
            // vIEW_LOAIHINHKHACBindingSource
            // 
            this.vIEW_LOAIHINHKHACBindingSource.DataMember = "VIEW_LOAIHINHKHAC";
            this.vIEW_LOAIHINHKHACBindingSource.DataSource = this.BAOTANGDataSet;
            // 
            // BAOTANGDataSet
            // 
            this.BAOTANGDataSet.DataSetName = "BAOTANGDataSet";
            this.BAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tACGIABindingSource
            // 
            this.tACGIABindingSource.DataMember = "TACGIA";
            this.tACGIABindingSource.DataSource = this.BAOTANGDataSet;
            // 
            // txtPhongCach
            // 
            this.txtPhongCach.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vIEW_LOAIHINHKHACBindingSource, "PHONG CÁCH", true));
            this.txtPhongCach.Location = new System.Drawing.Point(1243, 444);
            this.txtPhongCach.MenuManager = this.barManager1;
            this.txtPhongCach.Name = "txtPhongCach";
            this.txtPhongCach.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhongCach.Properties.Appearance.Options.UseFont = true;
            this.txtPhongCach.Size = new System.Drawing.Size(600, 32);
            this.txtPhongCach.TabIndex = 13;
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
            this.btnItemExit,
            this.btnItemReadMore});
            this.barManager1.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemReadMore, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // btnItemReadMore
            // 
            this.btnItemReadMore.Caption = "Xem Thêm";
            this.btnItemReadMore.Id = 7;
            this.btnItemReadMore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemReadMore.ImageOptions.Image")));
            this.btnItemReadMore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemReadMore.ImageOptions.LargeImage")));
            this.btnItemReadMore.Name = "btnItemReadMore";
            this.btnItemReadMore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemReadMore_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 828);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 798);
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vIEW_LOAIHINHKHACBindingSource, "THỂ LOẠI", true));
            this.txtTheLoai.Location = new System.Drawing.Point(477, 444);
            this.txtTheLoai.MenuManager = this.barManager1;
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheLoai.Properties.Appearance.Options.UseFont = true;
            this.txtTheLoai.Size = new System.Drawing.Size(445, 32);
            this.txtTheLoai.TabIndex = 11;
            // 
            // txtChuDe
            // 
            this.txtChuDe.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vIEW_LOAIHINHKHACBindingSource, "CHỦ ĐỀ", true));
            this.txtChuDe.Location = new System.Drawing.Point(910, 302);
            this.txtChuDe.MenuManager = this.barManager1;
            this.txtChuDe.Name = "txtChuDe";
            this.txtChuDe.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuDe.Properties.Appearance.Options.UseFont = true;
            this.txtChuDe.Size = new System.Drawing.Size(352, 32);
            this.txtChuDe.TabIndex = 7;
            // 
            // txtNamSangTac
            // 
            this.txtNamSangTac.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vIEW_LOAIHINHKHACBindingSource, "NĂM SÁNG TÁC", true));
            this.txtNamSangTac.Location = new System.Drawing.Point(477, 302);
            this.txtNamSangTac.MenuManager = this.barManager1;
            this.txtNamSangTac.Name = "txtNamSangTac";
            this.txtNamSangTac.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSangTac.Properties.Appearance.Options.UseFont = true;
            this.txtNamSangTac.Size = new System.Drawing.Size(191, 32);
            this.txtNamSangTac.TabIndex = 5;
            // 
            // txtTENTPNT
            // 
            this.txtTENTPNT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vIEW_LOAIHINHKHACBindingSource, "TÊN TPNT", true));
            this.txtTENTPNT.Location = new System.Drawing.Point(1150, 164);
            this.txtTENTPNT.MenuManager = this.barManager1;
            this.txtTENTPNT.Name = "txtTENTPNT";
            this.txtTENTPNT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENTPNT.Properties.Appearance.Options.UseFont = true;
            this.txtTENTPNT.Size = new System.Drawing.Size(493, 32);
            this.txtTENTPNT.TabIndex = 3;
            // 
            // txtMATPNT
            // 
            this.txtMATPNT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vIEW_LOAIHINHKHACBindingSource, "MÃ TPNT", true));
            this.txtMATPNT.Location = new System.Drawing.Point(611, 164);
            this.txtMATPNT.MenuManager = this.barManager1;
            this.txtMATPNT.Name = "txtMATPNT";
            this.txtMATPNT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMATPNT.Properties.Appearance.Options.UseFont = true;
            this.txtMATPNT.Size = new System.Drawing.Size(233, 32);
            this.txtMATPNT.TabIndex = 1;
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
            this.tableAdapterManager.TACGIATableAdapter = this.tACGIATableAdapter;
            this.tableAdapterManager.TPNTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BAOTANG.BAOTANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tACGIATableAdapter
            // 
            this.tACGIATableAdapter.ClearBeforeFill = true;
            // 
            // vIEW_LOAIHINHKHACTableAdapter
            // 
            this.vIEW_LOAIHINHKHACTableAdapter.ClearBeforeFill = true;
            // 
            // vIEW_LOAIHINHKHACDataGridView
            // 
            this.vIEW_LOAIHINHKHACDataGridView.AutoGenerateColumns = false;
            this.vIEW_LOAIHINHKHACDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vIEW_LOAIHINHKHACDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vIEW_LOAIHINHKHACDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATPNT,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.vIEW_LOAIHINHKHACDataGridView.DataSource = this.vIEW_LOAIHINHKHACBindingSource;
            this.vIEW_LOAIHINHKHACDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vIEW_LOAIHINHKHACDataGridView.Location = new System.Drawing.Point(0, 30);
            this.vIEW_LOAIHINHKHACDataGridView.Name = "vIEW_LOAIHINHKHACDataGridView";
            this.vIEW_LOAIHINHKHACDataGridView.RowHeadersWidth = 51;
            this.vIEW_LOAIHINHKHACDataGridView.RowTemplate.Height = 24;
            this.vIEW_LOAIHINHKHACDataGridView.Size = new System.Drawing.Size(1924, 243);
            this.vIEW_LOAIHINHKHACDataGridView.TabIndex = 5;
            this.vIEW_LOAIHINHKHACDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vIEW_LOAIHINHKHACDataGridView_CellContentClick);
            // 
            // MATPNT
            // 
            this.MATPNT.DataPropertyName = "MÃ TPNT";
            this.MATPNT.HeaderText = "MÃ TPNT";
            this.MATPNT.MinimumWidth = 6;
            this.MATPNT.Name = "MATPNT";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TÊN TPNT";
            this.dataGridViewTextBoxColumn2.HeaderText = "TÊN TPNT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NĂM SÁNG TÁC";
            this.dataGridViewTextBoxColumn3.HeaderText = "NĂM SÁNG TÁC";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CHỦ ĐỀ";
            this.dataGridViewTextBoxColumn4.HeaderText = "CHỦ ĐỀ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TÊN TÁC GIẢ";
            this.dataGridViewTextBoxColumn5.HeaderText = "TÊN TÁC GIẢ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "THỂ LOẠI";
            this.dataGridViewTextBoxColumn6.HeaderText = "THỂ LOẠI";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PHONG CÁCH";
            this.dataGridViewTextBoxColumn7.HeaderText = "PHONG CÁCH";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // FrmLoaiHinhKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 828);
            this.Controls.Add(this.vIEW_LOAIHINHKHACDataGridView);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmLoaiHinhKhac";
            this.Text = "Loại Hình Khác";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLoaiHinhKhac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_LOAIHINHKHACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhongCach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChuDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamSangTac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENTPNT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMATPNT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_LOAIHINHKHACDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlDetail;
        private BAOTANGDataSet BAOTANGDataSet;
        
        private BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private BAOTANGDataSetTableAdapters.TACGIATableAdapter tACGIATableAdapter;
        private System.Windows.Forms.BindingSource tACGIABindingSource;
        private DevExpress.XtraBars.BarButtonItem btnItemAdd;
        private DevExpress.XtraBars.BarButtonItem btnItemEdit;
        private DevExpress.XtraBars.BarButtonItem btnItemDelete;
        private DevExpress.XtraBars.BarButtonItem btnItemSave;
        private DevExpress.XtraBars.BarButtonItem btnItemReload;
        private DevExpress.XtraBars.BarButtonItem btnItemUndo;
        private DevExpress.XtraBars.BarButtonItem btnItemExit;
        private DevExpress.XtraBars.BarButtonItem btnItemReadMore;
        private System.Windows.Forms.BindingSource vIEW_LOAIHINHKHACBindingSource;
        private BAOTANGDataSetTableAdapters.VIEW_LOAIHINHKHACTableAdapter vIEW_LOAIHINHKHACTableAdapter;
        private System.Windows.Forms.DataGridView vIEW_LOAIHINHKHACDataGridView;
        private DevExpress.XtraEditors.TextEdit txtPhongCach;
        private DevExpress.XtraEditors.TextEdit txtTheLoai;
        private DevExpress.XtraEditors.TextEdit txtChuDe;
        private DevExpress.XtraEditors.TextEdit txtNamSangTac;
        private DevExpress.XtraEditors.TextEdit txtTENTPNT;
        private DevExpress.XtraEditors.TextEdit txtMATPNT;
        private System.Windows.Forms.ComboBox cmbTenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATPNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}