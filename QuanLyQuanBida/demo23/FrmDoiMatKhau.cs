using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel; //skin màu cho form

namespace demo23
{
    public partial class FrmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public string tennd;
        public DataTable nguoidung;

        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if (txtXacNhan.Text != txtMKMoi.Text)
                MessageBox.Show("Xác nhận chưa khớp với mật khẩu mới !!");

            DataRow dr = getRowChange(nguoidung);
            nGUOIDUNGTableAdapter.Update(dr);
            MessageBox.Show("Tài khoản "+tennd+" đổi mật khẩu thành công !!");
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            // TODO: This line of code loads data into the 'dataSetBida.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.dataSetBida.NGUOIDUNG);
            txtTenDN.Text = tennd;
            nguoidung = nGUOIDUNGTableAdapter.GetData();
            txtMK.Text = layMatKhau(nguoidung);     
        }

        string layMatKhau(DataTable dt)
        {   
            string matkhau = "";
            foreach (DataRow dr in dt.Rows)
                if (dr[0].ToString() == tennd)
                    matkhau = dr[1].ToString();
            return matkhau;
        }

        DataRow getRowChange(DataTable dt)
        {
            DataRow rowchange = null;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString() == tennd)
                {
                    dr[1] = txtMKMoi.Text;
                    rowchange = dr;
                }
            }
            return rowchange;
        }

        private void txtXacNhan_EditValueChanged(object sender, EventArgs e)
        {
            if (txtXacNhan.Text != "")
                btnDoi.Enabled = true;
            else
                btnDoi.Enabled = false;
        }
    }
}