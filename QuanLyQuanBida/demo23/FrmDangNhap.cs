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
            string ketnoi = Properties.Settings.Default.LTWNCConn;

            //MessageBox.Show(ketnoi);
            //cauhinh.config = Properties.Settings.Default; không phải kiểu string

            
            FrmCauHinh ch = new FrmCauHinh(ketnoi);
            if (Program.fm == null || Program.fm.IsDisposed)
            {
                Program.fm = new FrmMain();
            }

            //Truyền dữ liệu vào user control đã kéo vào form (Không khởi tạo đối tượng mới để truyền)
            dangNhapControl1.formLogin = this;
            dangNhapControl1.formConfig = ch;
            dangNhapControl1.formMain = Program.fm;
            dangNhapControl1.strcon = ketnoi;

        }
    }
}
