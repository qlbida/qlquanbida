namespace demo23
{
    partial class FrmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhanQuyen));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.pHANQUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBida = new demo23.DataSetBida();
            this.gridViewPQ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaManHinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenManHinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCoQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlNhomND = new DevExpress.XtraGrid.GridControl();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewNhom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.nHOMNGUOIDUNGTableAdapter = new demo23.DataSetBidaTableAdapters.NHOMNGUOIDUNGTableAdapter();
            this.tableAdapterManager = new demo23.DataSetBidaTableAdapters.TableAdapterManager();
            this.pHANQUYENTableAdapter = new demo23.DataSetBidaTableAdapters.PHANQUYENTableAdapter();
            this.cT_NHOMNGUOIDUNG_MANHINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_NHOMNGUOIDUNG_MANHINHTableAdapter = new demo23.DataSetBidaTableAdapters.CT_NHOMNGUOIDUNG_MANHINHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANQUYENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhomND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NHOMNGUOIDUNG_MANHINHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnThoat);
            this.layoutControl1.Controls.Add(this.btnLuu);
            this.layoutControl1.Controls.Add(this.gridControlPhanQuyen);
            this.layoutControl1.Controls.Add(this.gridControlNhomND);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1094, 775);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(299, 33);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(229, 40);
            this.btnThoat.StyleController = this.layoutControl1;
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(33, 33);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(226, 40);
            this.btnLuu.StyleController = this.layoutControl1;
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gridControlPhanQuyen
            // 
            this.gridControlPhanQuyen.DataSource = this.pHANQUYENBindingSource;
            this.gridControlPhanQuyen.Location = new System.Drawing.Point(578, 93);
            this.gridControlPhanQuyen.MainView = this.gridViewPQ;
            this.gridControlPhanQuyen.Name = "gridControlPhanQuyen";
            this.gridControlPhanQuyen.Size = new System.Drawing.Size(500, 666);
            this.gridControlPhanQuyen.TabIndex = 5;
            this.gridControlPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPQ});
            // 
            // pHANQUYENBindingSource
            // 
            this.pHANQUYENBindingSource.DataMember = "PHANQUYEN";
            this.pHANQUYENBindingSource.DataSource = this.dataSetBida;
            // 
            // dataSetBida
            // 
            this.dataSetBida.DataSetName = "DataSetBida";
            this.dataSetBida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewPQ
            // 
            this.gridViewPQ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaManHinh,
            this.colTenManHinh,
            this.colCoQuyen});
            this.gridViewPQ.GridControl = this.gridControlPhanQuyen;
            this.gridViewPQ.Name = "gridViewPQ";
            this.gridViewPQ.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewPQ.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPQ_FocusedRowChanged);
            this.gridViewPQ.Click += new System.EventHandler(this.gridViewPQ_Click);
            // 
            // colMaManHinh
            // 
            this.colMaManHinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMaManHinh.AppearanceCell.Options.UseFont = true;
            this.colMaManHinh.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMaManHinh.AppearanceHeader.Options.UseFont = true;
            this.colMaManHinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaManHinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaManHinh.Caption = "Mã màn hình";
            this.colMaManHinh.FieldName = "MaManHinh";
            this.colMaManHinh.Name = "colMaManHinh";
            this.colMaManHinh.Visible = true;
            this.colMaManHinh.VisibleIndex = 0;
            // 
            // colTenManHinh
            // 
            this.colTenManHinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTenManHinh.AppearanceCell.Options.UseFont = true;
            this.colTenManHinh.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTenManHinh.AppearanceHeader.Options.UseFont = true;
            this.colTenManHinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenManHinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenManHinh.Caption = "Tên màn hình";
            this.colTenManHinh.FieldName = "TenManHinh";
            this.colTenManHinh.Name = "colTenManHinh";
            this.colTenManHinh.Visible = true;
            this.colTenManHinh.VisibleIndex = 1;
            // 
            // colCoQuyen
            // 
            this.colCoQuyen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colCoQuyen.AppearanceCell.Options.UseFont = true;
            this.colCoQuyen.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colCoQuyen.AppearanceHeader.Options.UseFont = true;
            this.colCoQuyen.AppearanceHeader.Options.UseTextOptions = true;
            this.colCoQuyen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCoQuyen.Caption = "Có quyền";
            this.colCoQuyen.FieldName = "CoQuyen";
            this.colCoQuyen.Name = "colCoQuyen";
            this.colCoQuyen.Visible = true;
            this.colCoQuyen.VisibleIndex = 2;
            // 
            // gridControlNhomND
            // 
            this.gridControlNhomND.DataSource = this.nHOMNGUOIDUNGBindingSource;
            this.gridControlNhomND.Location = new System.Drawing.Point(16, 96);
            this.gridControlNhomND.MainView = this.gridViewNhom;
            this.gridControlNhomND.Name = "gridControlNhomND";
            this.gridControlNhomND.Size = new System.Drawing.Size(512, 663);
            this.gridControlNhomND.TabIndex = 4;
            this.gridControlNhomND.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhom});
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataMember = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGBindingSource.DataSource = this.dataSetBida;
            // 
            // gridViewNhom
            // 
            this.gridViewNhom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNhom,
            this.colTenNhom,
            this.colGhiChu});
            this.gridViewNhom.GridControl = this.gridControlNhomND;
            this.gridViewNhom.Name = "gridViewNhom";
            this.gridViewNhom.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewNhom.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewNhom_FocusedRowChanged);
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
            this.colMaNhom.VisibleIndex = 0;
            // 
            // colTenNhom
            // 
            this.colTenNhom.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTenNhom.AppearanceCell.Options.UseFont = true;
            this.colTenNhom.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTenNhom.AppearanceHeader.Options.UseFont = true;
            this.colTenNhom.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenNhom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenNhom.Caption = "Tên nhóm";
            this.colTenNhom.FieldName = "TenNhom";
            this.colTenNhom.Name = "colTenNhom";
            this.colTenNhom.Visible = true;
            this.colTenNhom.VisibleIndex = 1;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colGhiChu.AppearanceCell.Options.UseFont = true;
            this.colGhiChu.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colGhiChu.AppearanceHeader.Options.UseFont = true;
            this.colGhiChu.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhiChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1094, 775);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlNhomND;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 20, 3, 3);
            this.layoutControlItem1.Size = new System.Drawing.Size(535, 669);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlPhanQuyen;
            this.layoutControlItem2.Location = new System.Drawing.Point(535, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 3, 80, 3);
            this.layoutControlItem2.Size = new System.Drawing.Size(533, 749);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnLuu;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.layoutControlItem3.Size = new System.Drawing.Size(266, 80);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnThoat;
            this.layoutControlItem4.Location = new System.Drawing.Point(266, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.layoutControlItem4.Size = new System.Drawing.Size(269, 80);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
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
            this.tableAdapterManager.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = this.nHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.TRANGTHAIBANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = demo23.DataSetBidaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pHANQUYENTableAdapter
            // 
            this.pHANQUYENTableAdapter.ClearBeforeFill = true;
            // 
            // cT_NHOMNGUOIDUNG_MANHINHBindingSource
            // 
            this.cT_NHOMNGUOIDUNG_MANHINHBindingSource.DataMember = "CT_NHOMNGUOIDUNG_MANHINH";
            this.cT_NHOMNGUOIDUNG_MANHINHBindingSource.DataSource = this.dataSetBida;
            // 
            // cT_NHOMNGUOIDUNG_MANHINHTableAdapter
            // 
            this.cT_NHOMNGUOIDUNG_MANHINHTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 775);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmPhanQuyen";
            this.Text = "Phân quyền chức năng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANQUYENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhomND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NHOMNGUOIDUNG_MANHINHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControlPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPQ;
        private DevExpress.XtraGrid.GridControl gridControlNhomND;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhom;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DataSetBida dataSetBida;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private DataSetBidaTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter;
        private DataSetBidaTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private System.Windows.Forms.BindingSource pHANQUYENBindingSource;
        private DataSetBidaTableAdapters.PHANQUYENTableAdapter pHANQUYENTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaManHinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenManHinh;
        private DevExpress.XtraGrid.Columns.GridColumn colCoQuyen;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource cT_NHOMNGUOIDUNG_MANHINHBindingSource;
        private DataSetBidaTableAdapters.CT_NHOMNGUOIDUNG_MANHINHTableAdapter cT_NHOMNGUOIDUNG_MANHINHTableAdapter;
    }
}