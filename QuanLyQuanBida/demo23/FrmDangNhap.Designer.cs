namespace demo23
{
    partial class FrmDangNhap
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
            this.dangNhapControl1 = new QuanBida.DangNhapControl();
            this.SuspendLayout();
            // 
            // dangNhapControl1
            // 
            this.dangNhapControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dangNhapControl1.Location = new System.Drawing.Point(10, 11);
            this.dangNhapControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dangNhapControl1.Name = "dangNhapControl1";
            this.dangNhapControl1.Size = new System.Drawing.Size(474, 238);
            this.dangNhapControl1.TabIndex = 0;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(496, 260);
            this.Controls.Add(this.dangNhapControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormDN2_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmDangNhap_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private QuanBida.DangNhapControl dangNhapControl1;

    }
}