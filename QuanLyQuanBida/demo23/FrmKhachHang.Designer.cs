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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dataSetBida = new demo23.DataSetBida();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new demo23.DataSetBidaTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new demo23.DataSetBidaTableAdapters.TableAdapterManager();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diaChiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.soDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.maKHTextEdit);
            this.layoutControl1.Controls.Add(this.tenKHTextEdit);
            this.layoutControl1.Controls.Add(this.diaChiTextEdit);
            this.layoutControl1.Controls.Add(this.soDTTextEdit);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(768, 629);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(768, 629);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kHACHHANGBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(16, 72);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(736, 541);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colDiaChi,
            this.colSoDT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(742, 547);
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
            this.tableAdapterManager.TRANGTHAIDATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = demo23.DataSetBidaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // colMaKH
            // 
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
            this.colTenKH.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTenKH.AppearanceHeader.Options.UseFont = true;
            this.colTenKH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenKH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenKH.Caption = "Tên khách hàng";
            this.colTenKH.FieldName = "TenKH";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 1;
            // 
            // colDiaChi
            // 
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
            // maKHTextEdit
            // 
            this.maKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "MaKH", true));
            this.maKHTextEdit.Location = new System.Drawing.Point(111, 16);
            this.maKHTextEdit.Name = "maKHTextEdit";
            this.maKHTextEdit.Size = new System.Drawing.Size(270, 22);
            this.maKHTextEdit.StyleController = this.layoutControl1;
            this.maKHTextEdit.TabIndex = 6;
            // 
            // tenKHTextEdit
            // 
            this.tenKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "TenKH", true));
            this.tenKHTextEdit.Location = new System.Drawing.Point(482, 16);
            this.tenKHTextEdit.Name = "tenKHTextEdit";
            this.tenKHTextEdit.Size = new System.Drawing.Size(270, 22);
            this.tenKHTextEdit.StyleController = this.layoutControl1;
            this.tenKHTextEdit.TabIndex = 8;
            // 
            // diaChiTextEdit
            // 
            this.diaChiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "DiaChi", true));
            this.diaChiTextEdit.Location = new System.Drawing.Point(111, 44);
            this.diaChiTextEdit.Name = "diaChiTextEdit";
            this.diaChiTextEdit.Size = new System.Drawing.Size(270, 22);
            this.diaChiTextEdit.StyleController = this.layoutControl1;
            this.diaChiTextEdit.TabIndex = 10;
            // 
            // soDTTextEdit
            // 
            this.soDTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "SoDT", true));
            this.soDTTextEdit.Location = new System.Drawing.Point(482, 44);
            this.soDTTextEdit.Name = "soDTTextEdit";
            this.soDTTextEdit.Size = new System.Drawing.Size(270, 22);
            this.soDTTextEdit.StyleController = this.layoutControl1;
            this.soDTTextEdit.TabIndex = 12;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.maKHTextEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(371, 28);
            this.layoutControlItem3.Text = "Mã khách hàng:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(91, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.tenKHTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(371, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(371, 28);
            this.layoutControlItem5.Text = "Tên KH:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(91, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.diaChiTextEdit;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(371, 28);
            this.layoutControlItem7.Text = "Địa chỉ:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(91, 17);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.soDTTextEdit;
            this.layoutControlItem9.Location = new System.Drawing.Point(371, 28);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(371, 28);
            this.layoutControlItem9.Text = "Số DT:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(91, 17);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 629);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmKhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DataSetBida dataSetBida;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private DataSetBidaTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private DataSetBidaTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit maKHTextEdit;
        private DevExpress.XtraEditors.TextEdit tenKHTextEdit;
        private DevExpress.XtraEditors.TextEdit diaChiTextEdit;
        private DevExpress.XtraEditors.TextEdit soDTTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}