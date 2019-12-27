namespace demo23
{
    partial class FrmNguoiDung_NhomND
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.nHOMNGUOIDUNGComboBox = new System.Windows.Forms.ComboBox();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBida = new demo23.DataSetBida();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlThemND = new DevExpress.XtraGrid.GridControl();
            this.cT_NHOMNGUOIDUNG_NGUOIDUNG_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewND_Nhom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDangNhap1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlND = new DevExpress.XtraGrid.GridControl();
            this.nGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewND = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoatDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.nHOMNGUOIDUNGTableAdapter = new demo23.DataSetBidaTableAdapters.NHOMNGUOIDUNGTableAdapter();
            this.tableAdapterManager = new demo23.DataSetBidaTableAdapters.TableAdapterManager();
            this.cT_NHOMNGUOIDUNG_NGUOIDUNG_DKTableAdapter = new demo23.DataSetBidaTableAdapters.CT_NHOMNGUOIDUNG_NGUOIDUNG_DKTableAdapter();
            this.nGUOIDUNGTableAdapter = new demo23.DataSetBidaTableAdapters.NGUOIDUNGTableAdapter();
            this.cT_NHOMNGUOIDUNG_NGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_NHOMNGUOIDUNG_NGUOIDUNGTableAdapter = new demo23.DataSetBidaTableAdapters.CT_NHOMNGUOIDUNG_NGUOIDUNGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThemND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NHOMNGUOIDUNG_NGUOIDUNG_DKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewND_Nhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NHOMNGUOIDUNG_NGUOIDUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.nHOMNGUOIDUNGComboBox);
            this.layoutControl1.Controls.Add(this.btnXoa);
            this.layoutControl1.Controls.Add(this.btnThem);
            this.layoutControl1.Controls.Add(this.gridControlThemND);
            this.layoutControl1.Controls.Add(this.gridControlND);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(993, 690);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // nHOMNGUOIDUNGComboBox
            // 
            this.nHOMNGUOIDUNGComboBox.DataSource = this.nHOMNGUOIDUNGBindingSource;
            this.nHOMNGUOIDUNGComboBox.DisplayMember = "TenNhom";
            this.nHOMNGUOIDUNGComboBox.FormattingEnabled = true;
            this.nHOMNGUOIDUNGComboBox.Location = new System.Drawing.Point(620, 16);
            this.nHOMNGUOIDUNGComboBox.Name = "nHOMNGUOIDUNGComboBox";
            this.nHOMNGUOIDUNGComboBox.Size = new System.Drawing.Size(357, 24);
            this.nHOMNGUOIDUNGComboBox.TabIndex = 8;
            this.nHOMNGUOIDUNGComboBox.ValueMember = "MaNhom";
            this.nHOMNGUOIDUNGComboBox.SelectedIndexChanged += new System.EventHandler(this.nHOMNGUOIDUNGComboBox_SelectedIndexChanged);
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataMember = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGBindingSource.DataSource = this.dataSetBida;
            // 
            // dataSetBida
            // 
            this.dataSetBida.DataSetName = "DataSetBida";
            this.dataSetBida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(505, 546);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 30);
            this.btnXoa.StyleController = this.layoutControl1;
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "<<";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(505, 313);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 30);
            this.btnThem.StyleController = this.layoutControl1;
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = ">>";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControlThemND
            // 
            this.gridControlThemND.DataSource = this.cT_NHOMNGUOIDUNG_NGUOIDUNG_DKBindingSource;
            this.gridControlThemND.Location = new System.Drawing.Point(620, 48);
            this.gridControlThemND.MainView = this.gridViewND_Nhom;
            this.gridControlThemND.Name = "gridControlThemND";
            this.gridControlThemND.Size = new System.Drawing.Size(357, 626);
            this.gridControlThemND.TabIndex = 5;
            this.gridControlThemND.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewND_Nhom});
            // 
            // cT_NHOMNGUOIDUNG_NGUOIDUNG_DKBindingSource
            // 
            this.cT_NHOMNGUOIDUNG_NGUOIDUNG_DKBindingSource.DataMember = "CT_NHOMNGUOIDUNG_NGUOIDUNG_DK";
            this.cT_NHOMNGUOIDUNG_NGUOIDUNG_DKBindingSource.DataSource = this.dataSetBida;
            // 
            // gridViewND_Nhom
            // 
            this.gridViewND_Nhom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDangNhap1,
            this.colMaNhom});
            this.gridViewND_Nhom.GridControl = this.gridControlThemND;
            this.gridViewND_Nhom.Name = "gridViewND_Nhom";
            this.gridViewND_Nhom.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colTenDangNhap1
            // 
            this.colTenDangNhap1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTenDangNhap1.AppearanceCell.Options.UseFont = true;
            this.colTenDangNhap1.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTenDangNhap1.AppearanceHeader.Options.UseFont = true;
            this.colTenDangNhap1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDangNhap1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDangNhap1.Caption = "Tên đăng nhập";
            this.colTenDangNhap1.FieldName = "TenDangNhap";
            this.colTenDangNhap1.Name = "colTenDangNhap1";
            this.colTenDangNhap1.Visible = true;
            this.colTenDangNhap1.VisibleIndex = 0;
            // 
            // colMaNhom
            // 
            this.colMaNhom.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMaNhom.AppearanceCell.Options.UseFont = true;
            this.colMaNhom.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMaNhom.AppearanceHeader.Options.UseFont = true;
            this.colMaNhom.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaNhom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaNhom.Caption = "Mã nhóm";
            this.colMaNhom.FieldName = "MaNhom";
            this.colMaNhom.Name = "colMaNhom";
            this.colMaNhom.Visible = true;
            this.colMaNhom.VisibleIndex = 1;
            // 
            // gridControlND
            // 
            this.gridControlND.DataSource = this.nGUOIDUNGBindingSource;
            this.gridControlND.Location = new System.Drawing.Point(16, 49);
            this.gridControlND.MainView = this.gridViewND;
            this.gridControlND.Name = "gridControlND";
            this.gridControlND.Size = new System.Drawing.Size(476, 625);
            this.gridControlND.TabIndex = 4;
            this.gridControlND.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewND});
            // 
            // nGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGBindingSource.DataMember = "NGUOIDUNG";
            this.nGUOIDUNGBindingSource.DataSource = this.dataSetBida;
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
            this.colTenDangNhap.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
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
            this.colMatKhau.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
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
            this.colHoatDong.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
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
            this.colMaNV.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMaNV.AppearanceHeader.Options.UseFont = true;
            this.colMaNV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaNV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaNV.Caption = "Mã NV";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(993, 690);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlND;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 36, 3);
            this.layoutControlItem1.Size = new System.Drawing.Size(482, 664);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlThemND;
            this.layoutControlItem2.Location = new System.Drawing.Point(604, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(363, 632);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnThem;
            this.layoutControlItem3.Location = new System.Drawing.Point(482, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 300, 3);
            this.layoutControlItem3.Size = new System.Drawing.Size(122, 333);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnXoa;
            this.layoutControlItem4.Location = new System.Drawing.Point(482, 333);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 200, 3);
            this.layoutControlItem4.Size = new System.Drawing.Size(122, 331);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.nHOMNGUOIDUNGComboBox;
            this.layoutControlItem5.Location = new System.Drawing.Point(604, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(363, 32);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // nHOMNGUOIDUNGTableAdapter
            // 
            this.nHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANBIDATableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_NHOMNGUOIDUNG_MANHINHTableAdapter = null;
            this.tableAdapterManager.CT_NHOMNGUOIDUNG_NGUOIDUNG_DKTableAdapter = this.cT_NHOMNGUOIDUNG_NGUOIDUNG_DKTableAdapter;
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
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = this.nHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.TRANGTHAIBANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = demo23.DataSetBidaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cT_NHOMNGUOIDUNG_NGUOIDUNG_DKTableAdapter
            // 
            this.cT_NHOMNGUOIDUNG_NGUOIDUNG_DKTableAdapter.ClearBeforeFill = true;
            // 
            // nGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // cT_NHOMNGUOIDUNG_NGUOIDUNGBindingSource
            // 
            this.cT_NHOMNGUOIDUNG_NGUOIDUNGBindingSource.DataMember = "CT_NHOMNGUOIDUNG_NGUOIDUNG";
            this.cT_NHOMNGUOIDUNG_NGUOIDUNGBindingSource.DataSource = this.dataSetBida;
            // 
            // cT_NHOMNGUOIDUNG_NGUOIDUNGTableAdapter
            // 
            this.cT_NHOMNGUOIDUNG_NGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNguoiDung_NhomND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 690);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmNguoiDung_NhomND";
            this.Text = "Thêm người dùng vào nhóm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNguoiDung_NhomND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThemND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NHOMNGUOIDUNG_NGUOIDUNG_DKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewND_Nhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NHOMNGUOIDUNG_NGUOIDUNGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gridControlThemND;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewND_Nhom;
        private DevExpress.XtraGrid.GridControl gridControlND;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewND;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DataSetBida dataSetBida;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private DataSetBidaTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter;
        private DataSetBidaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox nHOMNGUOIDUNGComboBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DataSetBidaTableAdapters.NGUOIDUNGTableAdapter nGUOIDUNGTableAdapter;
        private System.Windows.Forms.BindingSource nGUOIDUNGBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn colHoatDong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DataSetBidaTableAdapters.CT_NHOMNGUOIDUNG_NGUOIDUNG_DKTableAdapter cT_NHOMNGUOIDUNG_NGUOIDUNG_DKTableAdapter;
        private System.Windows.Forms.BindingSource cT_NHOMNGUOIDUNG_NGUOIDUNG_DKBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhom;
        private System.Windows.Forms.BindingSource cT_NHOMNGUOIDUNG_NGUOIDUNGBindingSource;
        private DataSetBidaTableAdapters.CT_NHOMNGUOIDUNG_NGUOIDUNGTableAdapter cT_NHOMNGUOIDUNG_NGUOIDUNGTableAdapter;
    }
}