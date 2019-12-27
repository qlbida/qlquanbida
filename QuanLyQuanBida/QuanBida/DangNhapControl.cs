using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XuLy;

namespace QuanBida
{
    public partial class DangNhapControl : UserControl
    {
        public Form formLogin;
        public Form formConfig;
        public Form formMain;
        public string strcon;
        public string tendn;
        public QLy_NguoiDung CauHinh = new QLy_NguoiDung();
        
        public DangNhapControl()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            CauHinh.connect = strcon;

            if (string.IsNullOrEmpty(txtTenDN.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống user !!");
                txtTenDN.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống pass !!");
                txtMatKhau.Focus();
                return;
            }
 
            int kq = CauHinh.Check_Config(); 
            if (kq == 0)
            {
                ProcessLogin();
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại !!");
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không hợp lệ !!");
                formConfig.Show();
            }
        }

        public void ProcessLogin()
        {
            int result;
            result = CauHinh.Check_User(txtTenDN.Text, txtMatKhau.Text);
            
            // Wrong username or pass
            if (result == -1)
            {
                MessageBox.Show("Sai user hoặc pass !!");
                return;
            }
            else if (result == 0)
            {
                MessageBox.Show("Tài khoản này đã bị khóa !!");
                return;
            }
            tendn = txtTenDN.Text;

            formLogin.Visible = false;
            formMain.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            formLogin.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Properties.PasswordChar == '*' && checkBox1.Checked == true)
            {
                txtMatKhau.Properties.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.Properties.PasswordChar = '*';
            }
        } 
    }
}
