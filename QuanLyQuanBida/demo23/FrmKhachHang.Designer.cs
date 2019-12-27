namespace demo23
{
    partial class FrmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhachHang));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.maKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diaChiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.soDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colMaKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dataSetBida = new demo23.DataSetBida();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource();
            this.kHACHHANGTableAdapter = new demo23.DataSetBidaTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new demo23.DataSetBidaTableAdapters.TableAdapterManager();
            this.colMaKH2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDT2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.btnSua);
            this.layoutControl1.Controls.Add(this.btnThem);
            this.layoutControl1.Controls.Add(this.maKHTextEdit);
            this.layoutControl1.Controls.Add(this.tenKHTextEdit);
            this.layoutControl1.Controls.Add(this.diaChiTextEdit);
            this.layoutControl1.Controls.Add(this.soDTTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1155, 647);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(413, 194);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 40);
            this.btnSua.StyleController = this.layoutControl1;
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(315, 194);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 40);
            this.btnThem.StyleController = this.layoutControl1;
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // maKHTextEdit
            // 
            this.maKHTextEdit.Location = new System.Drawing.Point(63, 83);
            this.maKHTextEdit.Name = "maKHTextEdit";
            this.maKHTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maKHTextEdit.Properties.Appearance.Options.UseFont = true;
            this.maKHTextEdit.Size = new System.Drawing.Size(152, 30);
            this.maKHTextEdit.StyleController = this.layoutControl1;
            this.maKHTextEdit.TabIndex = 6;
            // 
            // tenKHTextEdit
            // 
            this.tenKHTextEdit.Location = new System.Drawing.Point(315, 84);
            this.tenKHTextEdit.Name = "tenKHTextEdit";
            this.tenKHTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenKHTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tenKHTextEdit.Size = new System.Drawing.Size(172, 30);
            this.tenKHTextEdit.StyleController = this.layoutControl1;
            this.tenKHTextEdit.TabIndex = 8;
            // 
            // diaChiTextEdit
            // 
            this.diaChiTextEdit.Location = new System.Drawing.Point(63, 141);
            this.diaChiTextEdit.Name = "diaChiTextEdit";
            this.diaChiTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diaChiTextEdit.Properties.Appearance.Options.UseFont = true;
            this.diaChiTextEdit.Size = new System.Drawing.Size(152, 30);
            this.diaChiTextEdit.StyleController = this.layoutControl1;
            this.diaChiTextEdit.TabIndex = 10;
            // 
            // soDTTextEdit
            // 
            this.soDTTextEdit.Location = new System.Drawing.Point(315, 141);
            this.soDTTextEdit.Name = "soDTTextEdit";
            this.soDTTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.soDTTextEdit.Properties.Appearance.Options.UseFont = true;
            this.soDTTextEdit.Size = new System.Drawing.Size(172, 30);
            this.soDTTextEdit.StyleController = this.layoutControl1;
            this.soDTTextEdit.TabIndex = 12;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1155, 647);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.maKHTextEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 50, 50, 3);
            this.layoutControlItem3.Size = new System.Drawing.Size(252, 104);
            this.layoutControlItem3.Text = "Mã khách hàng:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(91, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.tenKHTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(252, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 100, 50, 3);
            this.layoutControlItem5.Size = new System.Drawing.Size(322, 104);
            this.layoutControlItem5.Text = "Họ tên khách:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(91, 17);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.diaChiTextEdit;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 50, 3, 3);
            this.layoutControlItem7.Size = new System.Drawing.Size(252, 517);
            this.layoutControlItem7.Text = "Địa chỉ:";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(91, 17);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.soDTTextEdit;
            this.layoutControlItem9.Location = new System.Drawing.Point(252, 104);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 100, 3, 3);
            this.layoutControlItem9.Size = new System.Drawing.Size(322, 57);
            this.layoutControlItem9.Text = "Số điện thoại:";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(91, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnThem;
            this.layoutControlItem2.Location = new System.Drawing.Point(252, 161);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 5, 20, 3);
            this.layoutControlItem2.Size = new System.Drawing.Size(143, 460);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSua;
            this.layoutControlItem4.Location = new System.Drawing.Point(395, 161);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 100, 20, 3);
            this.layoutControlItem4.Size = new System.Drawing.Size(179, 460);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // colMaKH1
            // 
            this.colMaKH1.FieldName = "MaKH";
            this.colMaKH1.Name = "colMaKH1";
            // 
            // colTenKH1
            // 
            this.colTenKH1.FieldName = "HoTenKH";
            this.colTenKH1.Name = "colTenKH1";
            // 
            // colDiaChi1
            // 
            this.colDiaChi1.FieldName = "DiaChi";
            this.colDiaChi1.Name = "colDiaChi1";
            // 
            // colSoDT1
            // 
            this.colSoDT1.FieldName = "SoDT";
            this.colSoDT1.Name = "colSoDT1";
            // 
            // colMaKH
            // 
            this.colMaKH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMaKH.AppearanceCell.Options.UseFont = true;
            this.colMaKH.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMaKH.AppearanceHeader.Options.UseFont = true;
            this.colMaKH.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaKH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaKH.Caption = "Mã khách hàng";
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 0;
            // 
            // colTenKH
            // 
            this.colTenKH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTenKH.AppearanceCell.Options.UseFont = true;
            this.colTenKH.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTenKH.AppearanceHeader.Options.UseFont = true;
            this.colTenKH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenKH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenKH.Caption = "Họ tên khách";
            this.colTenKH.FieldName = "HoTenKH";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 1;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colDiaChi.AppearanceCell.Options.UseFont = true;
            this.colDiaChi.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colDiaChi.AppearanceHeader.Options.UseFont = true;
            this.colDiaChi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiaChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiaChi.Caption = "Địa chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 2;
            // 
            // colSoDT
            // 
            this.colSoDT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colSoDT.AppearanceCell.Options.UseFont = true;
            this.colSoDT.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colSoDT.AppearanceHeader.Options.UseFont = true;
            this.colSoDT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoDT.Caption = "Số điện thoại";
            this.colSoDT.FieldName = "SoDT";
            this.colSoDT.Name = "colSoDT";
            this.colSoDT.Visible = true;
            this.colSoDT.VisibleIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kHACHHANGBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(590, 16);
            this.gridControl1.MainView = this.gridViewKH;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(549, 615);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKH});
            // 
            // gridViewKH
            // 
            this.gridViewKH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKH2,
            this.colHoTenKH,
            this.colDiaChi2,
            this.colSoDT2});
            this.gridViewKH.GridControl = this.gridControl1;
            this.gridViewKH.Name = "gridViewKH";
            this.gridViewKH.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(574, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(555, 621);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // dataSetBida
            // 
            this.dataSetBida.DataSetName = "DataSetBida";
            this.dataSetBida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.dataSetBida;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.LOAIBANBIDATableAdapter = null;
            this.tableAdapterManager.LOAIHANGTableAdapter = null;
            this.tableAdapterManager.MANHINHTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.TRANGTHAIBANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = demo23.DataSetBidaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // colMaKH2
            // 
            this.colMaKH2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMaKH2.AppearanceCell.Options.UseFont = true;
            this.colMaKH2.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMaKH2.AppearanceHeader.Options.UseFont = true;
            this.colMaKH2.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaKH2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaKH2.Caption = "Mã khách hàng";
            this.colMaKH2.FieldName = "MaKH";
            this.colMaKH2.Name = "colMaKH2";
            this.colMaKH2.Visible = true;
            this.colMaKH2.VisibleIndex = 0;
            // 
            // colHoTenKH
            // 
            this.colHoTenKH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colHoTenKH.AppearanceCell.Options.UseFont = true;
            this.colHoTenKH.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colHoTenKH.AppearanceHeader.Options.UseFont = true;
            this.colHoTenKH.AppearanceHeader.Options.UseTextOptions = true;
            this.colHoTenKH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHoTenKH.Caption = "Họ tên khách";
            this.colHoTenKH.FieldName = "HoTenKH";
            this.colHoTenKH.Name = "colHoTenKH";
            this.colHoTenKH.Visible = true;
            this.colHoTenKH.VisibleIndex = 1;
            // 
            // colDiaChi2
            // 
            this.colDiaChi2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colDiaChi2.AppearanceCell.Options.UseFont = true;
            this.colDiaChi2.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colDiaChi2.AppearanceHeader.Options.UseFont = true;
            this.colDiaChi2.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiaChi2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiaChi2.Caption = "Địa chỉ";
            this.colDiaChi2.FieldName = "DiaChi";
            this.colDiaChi2.Name = "colDiaChi2";
            this.colDiaChi2.Visible = true;
            this.colDiaChi2.VisibleIndex = 2;
            // 
            // colSoDT2
            // 
            this.colSoDT2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colSoDT2.AppearanceCell.Options.UseFont = true;
            this.colSoDT2.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colSoDT2.AppearanceHeader.Options.UseFont = true;
            this.colSoDT2.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoDT2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoDT2.Caption = "Số điện thoại";
            this.colSoDT2.FieldName = "SoDT";
            this.colSoDT2.Name = "colSoDT2";
            this.colSoDT2.Visible = true;
            this.colSoDT2.VisibleIndex = 3;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 647);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmKhachHang";
            this.Text = "Khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit maKHTextEdit;
        private DevExpress.XtraEditors.TextEdit tenKHTextEdit;
        private DevExpress.XtraEditors.TextEdit diaChiTextEdit;
        private DevExpress.XtraEditors.TextEdit soDTTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH1;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDT1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDT;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKH;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DataSetBida dataSetBida;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private DataSetBidaTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private DataSetBidaTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH2;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi2;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDT2;
    }
}