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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNguoiDung_NhomND));
            this.dataSet1 = new demo23.DataSet1();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungTableAdapter = new demo23.DataSet1TableAdapters.NguoiDungTableAdapter();
            this.tableAdapterManager = new demo23.DataSet1TableAdapters.TableAdapterManager();
            this.nguoiDung_NhomND_DKTableAdapter = new demo23.DataSet1TableAdapters.NguoiDung_NhomND_DKTableAdapter();
            this.nhomNguoiDungTableAdapter = new demo23.DataSet1TableAdapters.NhomNguoiDungTableAdapter();
            this.nguoiDungBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nguoiDungBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nguoiDung_NhomND_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomNguoiDungComboBox = new System.Windows.Forms.ComboBox();
            this.nguoiDung_NhomNDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDung_NhomNDTableAdapter = new demo23.DataSet1TableAdapters.NguoiDung_NhomNDTableAdapter();
            this.gridControlND_Nhom = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlND = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoatDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingNavigator)).BeginInit();
            this.nguoiDungBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDung_NhomND_DKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDung_NhomNDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlND_Nhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            this.nguoiDungBindingSource.DataSource = this.dataSet1;
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NguoiDung_NhomND_DKTableAdapter = this.nguoiDung_NhomND_DKTableAdapter;
            this.tableAdapterManager.NguoiDung_NhomNDTableAdapter = null;
            this.tableAdapterManager.NguoiDungTableAdapter = this.nguoiDungTableAdapter;
            this.tableAdapterManager.NhomNguoiDungTableAdapter = this.nhomNguoiDungTableAdapter;
            this.tableAdapterManager.UpdateOrder = demo23.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nguoiDung_NhomND_DKTableAdapter
            // 
            this.nguoiDung_NhomND_DKTableAdapter.ClearBeforeFill = true;
            // 
            // nhomNguoiDungTableAdapter
            // 
            this.nhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // nguoiDungBindingNavigator
            // 
            this.nguoiDungBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nguoiDungBindingNavigator.BindingSource = this.nguoiDungBindingSource;
            this.nguoiDungBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nguoiDungBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nguoiDungBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nguoiDungBindingNavigatorSaveItem});
            this.nguoiDungBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nguoiDungBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nguoiDungBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nguoiDungBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nguoiDungBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nguoiDungBindingNavigator.Name = "nguoiDungBindingNavigator";
            this.nguoiDungBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nguoiDungBindingNavigator.Size = new System.Drawing.Size(1090, 27);
            this.nguoiDungBindingNavigator.TabIndex = 0;
            this.nguoiDungBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // nguoiDungBindingNavigatorSaveItem
            // 
            this.nguoiDungBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nguoiDungBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nguoiDungBindingNavigatorSaveItem.Image")));
            this.nguoiDungBindingNavigatorSaveItem.Name = "nguoiDungBindingNavigatorSaveItem";
            this.nguoiDungBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.nguoiDungBindingNavigatorSaveItem.Text = "Save Data";
            this.nguoiDungBindingNavigatorSaveItem.Click += new System.EventHandler(this.nguoiDungBindingNavigatorSaveItem_Click);
            // 
            // nguoiDung_NhomND_DKBindingSource
            // 
            this.nguoiDung_NhomND_DKBindingSource.DataMember = "NguoiDung_NhomND_DK";
            this.nguoiDung_NhomND_DKBindingSource.DataSource = this.dataSet1;
            // 
            // nhomNguoiDungBindingSource
            // 
            this.nhomNguoiDungBindingSource.DataMember = "NhomNguoiDung";
            this.nhomNguoiDungBindingSource.DataSource = this.dataSet1;
            // 
            // nhomNguoiDungComboBox
            // 
            this.nhomNguoiDungComboBox.DataSource = this.nhomNguoiDungBindingSource;
            this.nhomNguoiDungComboBox.DisplayMember = "TenNhom";
            this.nhomNguoiDungComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nhomNguoiDungComboBox.FormattingEnabled = true;
            this.nhomNguoiDungComboBox.Location = new System.Drawing.Point(630, 30);
            this.nhomNguoiDungComboBox.Name = "nhomNguoiDungComboBox";
            this.nhomNguoiDungComboBox.Size = new System.Drawing.Size(448, 28);
            this.nhomNguoiDungComboBox.TabIndex = 6;
            this.nhomNguoiDungComboBox.ValueMember = "MaNhom";
            this.nhomNguoiDungComboBox.SelectedIndexChanged += new System.EventHandler(this.nhomNguoiDungComboBox_SelectedIndexChanged);
            // 
            // nguoiDung_NhomNDBindingSource
            // 
            this.nguoiDung_NhomNDBindingSource.DataMember = "NguoiDung_NhomND";
            this.nguoiDung_NhomNDBindingSource.DataSource = this.dataSet1;
            // 
            // nguoiDung_NhomNDTableAdapter
            // 
            this.nguoiDung_NhomNDTableAdapter.ClearBeforeFill = true;
            // 
            // gridControlND_Nhom
            // 
            this.gridControlND_Nhom.DataSource = this.nguoiDung_NhomND_DKBindingSource;
            this.gridControlND_Nhom.Location = new System.Drawing.Point(630, 78);
            this.gridControlND_Nhom.MainView = this.gridView1;
            this.gridControlND_Nhom.Name = "gridControlND_Nhom";
            this.gridControlND_Nhom.Size = new System.Drawing.Size(448, 560);
            this.gridControlND_Nhom.TabIndex = 7;
            this.gridControlND_Nhom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNhom,
            this.colNguoiDung});
            this.gridView1.GridControl = this.gridControlND_Nhom;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaNhom
            // 
            this.colMaNhom.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            // colNguoiDung
            // 
            this.colNguoiDung.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colNguoiDung.AppearanceCell.Options.UseFont = true;
            this.colNguoiDung.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colNguoiDung.AppearanceHeader.Options.UseFont = true;
            this.colNguoiDung.AppearanceHeader.Options.UseTextOptions = true;
            this.colNguoiDung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNguoiDung.Caption = "Người dùng";
            this.colNguoiDung.FieldName = "NguoiDung";
            this.colNguoiDung.Name = "colNguoiDung";
            this.colNguoiDung.Visible = true;
            this.colNguoiDung.VisibleIndex = 1;
            // 
            // gridControlND
            // 
            this.gridControlND.DataSource = this.nguoiDungBindingSource;
            this.gridControlND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridControlND.Location = new System.Drawing.Point(12, 78);
            this.gridControlND.MainView = this.gridView2;
            this.gridControlND.Name = "gridControlND";
            this.gridControlND.Size = new System.Drawing.Size(466, 560);
            this.gridControlND.TabIndex = 9;
            this.gridControlND.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDangNhap,
            this.colMatKhau,
            this.colHoatDong});
            this.gridView2.GridControl = this.gridControlND;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTenDangNhap.AppearanceCell.Options.UseFont = true;
            this.colTenDangNhap.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTenDangNhap.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTenDangNhap.AppearanceHeader.Options.UseFont = true;
            this.colTenDangNhap.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDangNhap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDangNhap.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenDangNhap.Caption = "Tên đăng nhập";
            this.colTenDangNhap.FieldName = "TenDangNhap";
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.Visible = true;
            this.colTenDangNhap.VisibleIndex = 0;
            // 
            // colMatKhau
            // 
            this.colMatKhau.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMatKhau.AppearanceCell.Options.UseFont = true;
            this.colMatKhau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMatKhau.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMatKhau.AppearanceHeader.Options.UseFont = true;
            this.colMatKhau.AppearanceHeader.Options.UseTextOptions = true;
            this.colMatKhau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMatKhau.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMatKhau.Caption = "Mật khẩu";
            this.colMatKhau.FieldName = "MatKhau";
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.Visible = true;
            this.colMatKhau.VisibleIndex = 1;
            // 
            // colHoatDong
            // 
            this.colHoatDong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colHoatDong.AppearanceCell.Options.UseFont = true;
            this.colHoatDong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colHoatDong.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colHoatDong.AppearanceHeader.Options.UseFont = true;
            this.colHoatDong.AppearanceHeader.Options.UseTextOptions = true;
            this.colHoatDong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHoatDong.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHoatDong.Caption = "Hoạt động";
            this.colHoatDong.FieldName = "HoatDong";
            this.colHoatDong.Name = "colHoatDong";
            this.colHoatDong.Visible = true;
            this.colHoatDong.VisibleIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(506, 277);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 42);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = ">>";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(506, 440);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 42);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "<<";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FrmNguoiDung_NhomND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1090, 659);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridControlND);
            this.Controls.Add(this.gridControlND_Nhom);
            this.Controls.Add(this.nhomNguoiDungComboBox);
            this.Controls.Add(this.nguoiDungBindingNavigator);
            this.Name = "FrmNguoiDung_NhomND";
            this.Text = "FrmNguoiDung_NhomND";
            this.Load += new System.EventHandler(this.FrmNguoiDung_NhomND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingNavigator)).EndInit();
            this.nguoiDungBindingNavigator.ResumeLayout(false);
            this.nguoiDungBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDung_NhomND_DKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDung_NhomNDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlND_Nhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private DataSet1TableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nguoiDungBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nguoiDungBindingNavigatorSaveItem;
        private DataSet1TableAdapters.NguoiDung_NhomND_DKTableAdapter nguoiDung_NhomND_DKTableAdapter;
        private System.Windows.Forms.BindingSource nguoiDung_NhomND_DKBindingSource;
        private DataSet1TableAdapters.NhomNguoiDungTableAdapter nhomNguoiDungTableAdapter;
        private System.Windows.Forms.BindingSource nhomNguoiDungBindingSource;
        private System.Windows.Forms.ComboBox nhomNguoiDungComboBox;
        private System.Windows.Forms.BindingSource nguoiDung_NhomNDBindingSource;
        private DataSet1TableAdapters.NguoiDung_NhomNDTableAdapter nguoiDung_NhomNDTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlND_Nhom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiDung;
        private DevExpress.XtraGrid.GridControl gridControlND;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn colHoatDong;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}