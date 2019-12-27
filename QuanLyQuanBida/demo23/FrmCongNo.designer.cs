namespace demo23
{
    partial class FrmCongNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCongNo));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.khachhang = new DevExpress.XtraTab.XtraTabPage();
            this.dataGridViewCongNoKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhacungcap = new DevExpress.XtraTab.XtraTabPage();
            this.dataGridViewCongNoNCC = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewCTCongNo = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtTienNo = new DevExpress.XtraEditors.TextEdit();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.khachhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCongNoKH)).BeginInit();
            this.nhacungcap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCongNoNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTCongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.xtraTabControl1);
            this.groupControl1.Location = new System.Drawing.Point(10, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(487, 797);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Công nợ";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(6, 29);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.khachhang;
            this.xtraTabControl1.Size = new System.Drawing.Size(481, 762);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.khachhang,
            this.nhacungcap});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // khachhang
            // 
            this.khachhang.Controls.Add(this.dataGridViewCongNoKH);
            this.khachhang.Name = "khachhang";
            this.khachhang.Size = new System.Drawing.Size(474, 727);
            this.khachhang.Text = "Khách chơi bida";
            // 
            // dataGridViewCongNoKH
            // 
            this.dataGridViewCongNoKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewCongNoKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCongNoKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoTenKH,
            this.tienno});
            this.dataGridViewCongNoKH.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCongNoKH.Name = "dataGridViewCongNoKH";
            this.dataGridViewCongNoKH.RowTemplate.Height = 28;
            this.dataGridViewCongNoKH.Size = new System.Drawing.Size(468, 724);
            this.dataGridViewCongNoKH.TabIndex = 0;
            this.dataGridViewCongNoKH.SelectionChanged += new System.EventHandler(this.dataGridViewCongNoKH_SelectionChanged);
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách";
            this.MaKH.Name = "MaKH";
            // 
            // HoTenKH
            // 
            this.HoTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTenKH.DataPropertyName = "HoTenKH";
            this.HoTenKH.HeaderText = "Tên khách";
            this.HoTenKH.Name = "HoTenKH";
            // 
            // tienno
            // 
            this.tienno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tienno.DataPropertyName = "TienNo";
            this.tienno.HeaderText = "Tiền còn nợ";
            this.tienno.Name = "tienno";
            // 
            // nhacungcap
            // 
            this.nhacungcap.Controls.Add(this.dataGridViewCongNoNCC);
            this.nhacungcap.Name = "nhacungcap";
            this.nhacungcap.Size = new System.Drawing.Size(474, 727);
            this.nhacungcap.Text = "Nhà cung cấp";
            // 
            // dataGridViewCongNoNCC
            // 
            this.dataGridViewCongNoNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCongNoNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.Column4,
            this.Column5});
            this.dataGridViewCongNoNCC.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCongNoNCC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewCongNoNCC.Name = "dataGridViewCongNoNCC";
            this.dataGridViewCongNoNCC.RowTemplate.Height = 28;
            this.dataGridViewCongNoNCC.Size = new System.Drawing.Size(468, 721);
            this.dataGridViewCongNoNCC.TabIndex = 0;
            this.dataGridViewCongNoNCC.SelectionChanged += new System.EventHandler(this.dataGridViewCongNoNCC_SelectionChanged);
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.Name = "MaNCC";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TenNCC";
            this.Column4.HeaderText = "Tên nhà cung cấp";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TienNo";
            this.Column5.HeaderText = "Tiền quán nợ";
            this.Column5.Name = "Column5";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.dataGridViewCTCongNo);
            this.groupControl3.Location = new System.Drawing.Point(501, 11);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(740, 625);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Chi tiết công nợ";
            // 
            // dataGridViewCTCongNo
            // 
            this.dataGridViewCTCongNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCTCongNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCTCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTCongNo.Location = new System.Drawing.Point(5, 29);
            this.dataGridViewCTCongNo.Name = "dataGridViewCTCongNo";
            this.dataGridViewCTCongNo.RowTemplate.Height = 28;
            this.dataGridViewCTCongNo.Size = new System.Drawing.Size(730, 581);
            this.dataGridViewCTCongNo.TabIndex = 0;
            this.dataGridViewCTCongNo.SelectionChanged += new System.EventHandler(this.dataGridViewCTCongNo_SelectionChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.txtTienNo);
            this.groupControl2.Controls.Add(this.btnThanhToan);
            this.groupControl2.Location = new System.Drawing.Point(501, 641);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(740, 167);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Thanh toán công nợ";
            // 
            // txtTienNo
            // 
            this.txtTienNo.Location = new System.Drawing.Point(147, 61);
            this.txtTienNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTienNo.Properties.Appearance.Options.UseFont = true;
            this.txtTienNo.Size = new System.Drawing.Size(417, 30);
            this.txtTienNo.TabIndex = 1;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.Appearance.Options.UseFont = true;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(579, 56);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(142, 42);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // FrmCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 818);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmCongNo";
            this.Text = "Công nợ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCongNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.khachhang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCongNoKH)).EndInit();
            this.nhacungcap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCongNoNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTCongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTienNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dataGridViewCTCongNo;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage khachhang;
        private DevExpress.XtraTab.XtraTabPage nhacungcap;
        private System.Windows.Forms.DataGridView dataGridViewCongNoKH;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private DevExpress.XtraEditors.TextEdit txtTienNo;
        private System.Windows.Forms.DataGridView dataGridViewCongNoNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienno;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}