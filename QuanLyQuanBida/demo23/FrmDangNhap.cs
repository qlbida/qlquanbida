using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XuLy;
using QuanBida;

namespace demo23
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FormDN2_Load(object sender, EventArgs e)
        {
            dangNhap();
        }

        void dangNhap()
        {
            string ketnoi = Properties.Settings.Default.LTWNCConn;

            FrmCauHinh ch = new FrmCauHinh(ketnoi);

            //Truyền dữ liệu vào user control đã kéo vào form (Không khởi tạo đối tượng mới để truyền)
            this.Visible = true;
            dangNhapControl1.formLogin = this;
            dangNhapControl1.formConfig = ch;

            if (Program.fm == null || Program.fm.IsDisposed)
            {
                Program.fm = new FrmMain();
            }
            dangNhapControl1.formMain = Program.fm;
            dangNhapControl1.strcon = ketnoi;
        }

        private void FrmDangNhap_VisibleChanged(object sender, EventArgs e)
        {
            Program.fm.tendn = dangNhapControl1.tendn;
            dangNhap();
        }

    }
}
