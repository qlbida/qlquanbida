namespace demo23
{
    partial class FrnNguoiDung
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
            System.Windows.Forms.Label tenDangNhapLabel;
            System.Windows.Forms.Label matKhauLabel;
            System.Windows.Forms.Label hoatDongLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrnNguoiDung));
            this.nguoiDungBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new demo23.DataSet1();
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
            this.nguoiDungTableAdapter = new demo23.DataSet1TableAdapters.NguoiDungTableAdapter();
            this.tableAdapterManager = new demo23.DataSet1TableAdapters.TableAdapterManager();
            this.tenDangNhapTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.matKhauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoatDongCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.gridControlND = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoatDong = new DevExpress.XtraGrid.Columns.GridColumn();
            tenDangNhapLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            hoatDongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingNavigator)).BeginInit();
            this.nguoiDungBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDangNhapTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tenDangNhapLabel
            // 
            tenDangNhapLabel.AutoSize = true;
            tenDangNhapLabel.Location = new System.Drawing.Point(26, 60);
            tenDangNhapLabel.Name = "tenDangNhapLabel";
            tenDangNhapLabel.Size = new System.Drawing.Size(151, 25);
            tenDangNhapLabel.TabIndex = 1;
            tenDangNhapLabel.Text = "Tên đăng nhập:";
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Location = new System.Drawing.Point(26, 105);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(99, 25);
            matKhauLabel.TabIndex = 3;
            matKhauLabel.Text = "Mật khẩu:";
            // 
            // hoatDongLabel
            // 
            hoatDongLabel.AutoSize = true;
            hoatDongLabel.Location = new System.Drawing.Point(26, 146);
            hoatDongLabel.Name = "hoatDongLabel";
            hoatDongLabel.Size = new System.Drawing.Size(102, 25);
            hoatDongLabel.TabIndex = 5;
            hoatDongLabel.Text = "Hoạt động";
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
            this.nguoiDungBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.nguoiDungBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nguoiDungBindingNavigator.Size = new System.Drawing.Size(805, 27);
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
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            this.nguoiDungBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 27);
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
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NguoiDung_NhomND_DKTableAdapter = null;
            this.tableAdapterManager.NguoiDung_NhomNDTableAdapter = null;
            this.tableAdapterManager.NguoiDungTableAdapter = this.nguoiDungTableAdapter;
            this.tableAdapterManager.NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = demo23.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tenDangNhapTextEdit
            // 
            this.tenDangNhapTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nguoiDungBindingSource, "TenDangNhap", true));
            this.tenDangNhapTextEdit.Location = new System.Drawing.Point(189, 57);
            this.tenDangNhapTextEdit.Name = "tenDangNhapTextEdit";
            this.tenDangNhapTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenDangNhapTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tenDangNhapTextEdit.Size = new System.Drawing.Size(268, 30);
            this.tenDangNhapTextEdit.TabIndex = 2;
            // 
            // matKhauTextEdit
            // 
            this.matKhauTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nguoiDungBindingSource, "MatKhau", true));
            this.matKhauTextEdit.Location = new System.Drawing.Point(189, 102);
            this.matKhauTextEdit.Name = "matKhauTextEdit";
            this.matKhauTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.matKhauTextEdit.Properties.Appearance.Options.UseFont = true;
            this.matKhauTextEdit.Size = new System.Drawing.Size(268, 30);
            this.matKhauTextEdit.TabIndex = 4;
            // 
            // hoatDongCheckEdit
            // 
            this.hoatDongCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nguoiDungBindingSource, "HoatDong", true));
            this.hoatDongCheckEdit.Location = new System.Drawing.Point(189, 152);
            this.hoatDongCheckEdit.Name = "hoatDongCheckEdit";
            this.hoatDongCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hoatDongCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.hoatDongCheckEdit.Properties.Caption = "";
            this.hoatDongCheckEdit.Size = new System.Drawing.Size(23, 19);
            this.hoatDongCheckEdit.TabIndex = 6;
            // 
            // gridControlND
            // 
            this.gridControlND.DataSource = this.nguoiDungBindingSource;
            this.gridControlND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridControlND.Location = new System.Drawing.Point(31, 197);
            this.gridControlND.MainView = this.gridView1;
            this.gridControlND.Name = "gridControlND";
            this.gridControlND.Size = new System.Drawing.Size(741, 460);
            this.gridControlND.TabIndex = 8;
            this.gridControlND.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDangNhap,
            this.colMatKhau,
            this.colHoatDong});
            this.gridView1.GridControl = this.gridControlND;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
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
            // FrnNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(805, 669);
            this.Controls.Add(this.gridControlND);
            this.Controls.Add(tenDangNhapLabel);
            this.Controls.Add(this.tenDangNhapTextEdit);
            this.Controls.Add(matKhauLabel);
            this.Controls.Add(this.matKhauTextEdit);
            this.Controls.Add(hoatDongLabel);
            this.Controls.Add(this.hoatDongCheckEdit);
            this.Controls.Add(this.nguoiDungBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrnNguoiDung";
            this.Text = "Danh sách người dùng";
            this.Load += new System.EventHandler(this.FrnNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingNavigator)).EndInit();
            this.nguoiDungBindingNavigator.ResumeLayout(false);
            this.nguoiDungBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDangNhapTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoatDongCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DevExpress.XtraEditors.TextEdit tenDangNhapTextEdit;
        private DevExpress.XtraEditors.TextEdit matKhauTextEdit;
        private DevExpress.XtraEditors.CheckEdit hoatDongCheckEdit;
        private DevExpress.XtraGrid.GridControl gridControlND;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn colHoatDong;
    }
}