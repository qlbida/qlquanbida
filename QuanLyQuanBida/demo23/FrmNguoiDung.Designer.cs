namespace demo23
{
    partial class FrmNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNguoiDung));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlND = new DevExpress.XtraGrid.GridControl();
            this.nGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBida = new demo23.DataSetBida();
            this.gridViewND = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoatDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenDangNhapTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.matKhauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoatDongCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.maNVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutNguoiDung = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.nGUOIDUNGTableAdapter = new demo23.DataSetBidaTableAdapters.NGUOIDUNGTableAdapter();
            this.tableAdapterManager = new demo23.DataSetBidaTableAdapters.TableAdapterManager();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDangNhapTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnLuu);
            this.layoutControl1.Controls.Add(this.btnSua);
            this.layoutControl1.Controls.Add(this.btnXoa);
            this.layoutControl1.Controls.Add(this.btnThem);
            this.layoutControl1.Controls.Add(this.gridControlND);
            this.layoutControl1.Controls.Add(this.tenDangNhapTextEdit);
            this.layoutControl1.Controls.Add(this.matKhauTextEdit);
            this.layoutControl1.Controls.Add(this.hoatDongCheckEdit);
            this.layoutControl1.Controls.Add(this.maNVTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutNguoiDung;
            this.layoutControl1.Size = new System.Drawing.Size(993, 626);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(16, 158);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(258, 40);
            this.btnLuu.StyleController = this.layoutControl1;
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Sửa";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(764, 158);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(213, 40);
            this.btnSua.StyleController = this.layoutControl1;
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Xóa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(545, 158);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(213, 40);
            this.btnXoa.StyleController = this.layoutControl1;
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Lưu";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(280, 158);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(259, 40);
            this.btnThem.StyleController = this.layoutControl1;
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControlND
            // 
            this.gridControlND.DataSource = this.nGUOIDUNGBindingSource;
            this.gridControlND.Location = new System.Drawing.Point(16, 204);
            this.gridControlND.MainView = this.gridViewND;
            this.gridControlND.Name = "gridControlND";
            this.gridControlND.Size = new System.Drawing.Size(961, 406);
            this.gridControlND.TabIndex = 9;
            this.gridControlND.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewND});
            // 
            // nGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGBindingSource.DataMember = "NGUOIDUNG";
            this.nGUOIDUNGBindingSource.DataSource = this.dataSetBida;
            // 
            // dataSetBida
            // 
            this.dataSetBida.DataSetName = "DataSetBida";
            this.dataSetBida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewND
            // 
            this.gridViewND.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDangNhap,
            this.colMatKhau,
            this.colHoatDong,
            this.colMaNV});
            this.gridViewND.GridControl = this.gridControlND;
            this.gridViewND.Name = "gridViewND";
            this.gridViewND.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTenDangNhap.AppearanceCell.Options.UseFont = true;
            this.colTenDangNhap.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTenDangNhap.AppearanceHeader.Options.UseFont = true;
            this.colTenDangNhap.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDangNhap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDangNhap.Caption = "Tên đăng nhập";
            this.colTenDangNhap.FieldName = "TenDangNhap";
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.Visible = true;
            this.colTenDangNhap.VisibleIndex = 0;
            // 
            // colMatKhau
            // 
            this.colMatKhau.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMatKhau.AppearanceCell.Options.UseFont = true;
            this.colMatKhau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMatKhau.AppearanceHeader.Options.UseFont = true;
            this.colMatKhau.AppearanceHeader.Options.UseTextOptions = true;
            this.colMatKhau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMatKhau.Caption = "Mật khẩu";
            this.colMatKhau.FieldName = "MatKhau";
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.Visible = true;
            this.colMatKhau.VisibleIndex = 1;
            // 
            // colHoatDong
            // 
            this.colHoatDong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colHoatDong.AppearanceCell.Options.UseFont = true;
            this.colHoatDong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colHoatDong.AppearanceHeader.Options.UseFont = true;
            this.colHoatDong.AppearanceHeader.Options.UseTextOptions = true;
            this.colHoatDong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHoatDong.Caption = "Hoạt động";
            this.colHoatDong.FieldName = "HoatDong";
            this.colHoatDong.Name = "colHoatDong";
            this.colHoatDong.Visible = true;
            this.colHoatDong.VisibleIndex = 2;
            // 
            // colMaNV
            // 
            this.colMaNV.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMaNV.AppearanceCell.Options.UseFont = true;
            this.colMaNV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMaNV.AppearanceHeader.Options.UseFont = true;
            this.colMaNV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaNV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaNV.Caption = "Mã nhân viên";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 3;
            // 
            // tenDangNhapTextEdit
            // 
            this.tenDangNhapTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nGUOIDUNGBindingSource, "TenDangNhap", true));
            this.tenDangNhapTextEdit.Location = new System.Drawing.Point(161, 16);
            this.tenDangNhapTextEdit.Name = "tenDangNhapTextEdit";
            this.tenDangNhapTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenDangNhapTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tenDangNhapTextEdit.Size = new System.Drawing.Size(319, 30);
            this.tenDangNhapTextEdit.StyleController = this.layoutControl1;
            this.tenDangNhapTextEdit.TabIndex = 0;
            // 
            // matKhauTextEdit
            // 
            this.matKhauTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nGUOIDUNGBindingSource, "MatKhau", true));
            this.matKhauTextEdit.Location = new System.Drawing.Point(161, 52);
            this.matKhauTextEdit.Name = "matKhauTextEdit";
            this.matKhauTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.matKhauTextEdit.Properties.Appearance.Options.UseFont = true;
            this.matKhauTextEdit.Size = new System.Drawing.Size(319, 30);
            this.matKhauTextEdit.StyleController = this.layoutControl1;
            this.matKhauTextEdit.TabIndex = 2;
            // 
            // hoatDongCheckEdit
            // 
            this.hoatDongCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nGUOIDUNGBindingSource, "HoatDong", true));
            this.hoatDongCheckEdit.Location = new System.Drawing.Point(113, 88);
            this.hoatDongCheckEdit.Name = "hoatDongCheckEdit";
            this.hoatDongCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hoatDongCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.hoatDongCheckEdit.Properties.Caption = "Hoạt động";
            this.hoatDongCheckEdit.Size = new System.Drawing.Size(864, 28);
            this.hoatDongCheckEdit.StyleController = this.layoutControl1;
            this.hoatDongCheckEdit.TabIndex = 4;
            // 
            // maNVTextEdit
            // 
            this.maNVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nGUOIDUNGBindingSource, "MaNV", true));
            this.maNVTextEdit.Location = new System.Drawing.Point(161, 122);
            this.maNVTextEdit.Name = "maNVTextEdit";
            this.maNVTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maNVTextEdit.Properties.Appearance.Options.UseFont = true;
            this.maNVTextEdit.Size = new System.Drawing.Size(319, 30);
            this.maNVTextEdit.StyleController = this.layoutControl1;
            this.maNVTextEdit.TabIndex = 3;
            // 
            // layoutNguoiDung
            // 
            this.layoutNguoiDung.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutNguoiDung.GroupBordersVisible = false;
            this.layoutNguoiDung.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem9,
            this.layoutControlItem3,
            this.layoutControlItem10});
            this.layoutNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.layoutNguoiDung.Name = "Root";
            this.layoutNguoiDung.OptionsItemText.TextToControlDistance = 4;
            this.layoutNguoiDung.Size = new System.Drawing.Size(993, 626);
            this.layoutNguoiDung.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.tenDangNhapTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 500, 3, 3);
            this.layoutControlItem2.Size = new System.Drawing.Size(967, 36);
            this.layoutControlItem2.Text = "Tên đăng nhập:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(141, 24);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.hoatDongCheckEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 3, 3, 3);
            this.layoutControlItem6.Size = new System.Drawing.Size(967, 34);
            this.layoutControlItem6.Text = "Hoat Dong:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlND;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 188);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(967, 412);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.Control = this.maNVTextEdit;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 106);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 500, 3, 3);
            this.layoutControlItem8.Size = new System.Drawing.Size(967, 36);
            this.layoutControlItem8.Text = "Mã nhân viên:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(141, 24);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.matKhauTextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 500, 3, 3);
            this.layoutControlItem4.Size = new System.Drawing.Size(967, 36);
            this.layoutControlItem4.Text = "Mật khẩu:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(141, 24);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnThem;
            this.layoutControlItem3.Location = new System.Drawing.Point(264, 142);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(265, 46);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnSua;
            this.layoutControlItem10.Location = new System.Drawing.Point(748, 142);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(219, 46);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnLuu;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 142);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(264, 46);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // nGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANBIDATableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_NHOMNGUOIDUNG_MANHINHTableAdapter = null;
            this.tableAdapterManager.CT_NHOMNGUOIDUNG_NGUOIDUNG_DKTableAdapter = null;
            this.tableAdapterManager.CT_NHOMNGUOIDUNG_NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.CT_PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.DATBANBIDATableAdapter = null;
            this.tableAdapterManager.HANGHOATableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.LOAIBANBIDATableAdapter = null;
            this.tableAdapterManager.LOAIHANGTableAdapter = null;
            this.tableAdapterManager.MANHINHTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = this.nGUOIDUNGTableAdapter;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.TRANGTHAIBANTableAdapter = null;
            this.tableAdapterManager.TRANGTHAIDATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = demo23.DataSetBidaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnXoa;
            this.layoutControlItem7.Location = new System.Drawing.Point(529, 142);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(219, 46);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // FrmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 626);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmNguoiDung";
            this.Text = "Thông tin người dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDangNhapTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutNguoiDung;
        private DataSetBida dataSetBida;
        private System.Windows.Forms.BindingSource nGUOIDUNGBindingSource;
        private DataSetBidaTableAdapters.NGUOIDUNGTableAdapter nGUOIDUNGTableAdapter;
        private DataSetBidaTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridControlND;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewND;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn colHoatDong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraEditors.TextEdit tenDangNhapTextEdit;
        private DevExpress.XtraEditors.TextEdit matKhauTextEdit;
        private DevExpress.XtraEditors.CheckEdit hoatDongCheckEdit;
        private DevExpress.XtraEditors.TextEdit maNVTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;

    }
}