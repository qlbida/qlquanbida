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
    public partial class FrmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public DataTable nguoidung;

        public FrmNguoiDung()
        {
            InitializeComponent();
        }

        private void FrmNguoiDung_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            loadNguoiDung();
            nguoidung = nGUOIDUNGTableAdapter.GetData();
            tenDangNhapTextEdit.Focus();
            hoatDongCheckEdit.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTraTrungKhoa(nguoidung, tenDangNhapTextEdit.Text) == 1)
            {
                MessageBox.Show("Người dùng này đã tồn tại !!");
                tenDangNhapTextEdit.Focus();
            }
            else
            {
                nGUOIDUNGTableAdapter.Insert(tenDangNhapTextEdit.Text, matKhauTextEdit.Text, hoatDongCheckEdit.Checked, maNVTextEdit.Text);
                MessageBox.Show("Thêm người dùng mới thành công !!");
                loadNguoiDung();
            }
        }

        int kiemTraTrungKhoa(DataTable dt, string tennd)
        {
            int flag = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString() == tennd)
                    flag = 1;
            }
            return flag;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            DataRow dr = getRowChange(nguoidung);
            nGUOIDUNGTableAdapter.Update(dr);
            MessageBox.Show("Tài khoản " + tenDangNhapTextEdit.Text + " sửa thành công !!");
            loadNguoiDung();
        }

        DataRow getRowChange(DataTable dt)
        {
            DataRow rowchange = null;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString() == tenDangNhapTextEdit.Text)
                {
                    dr[1] = matKhauTextEdit.Text;
                    dr[2] = hoatDongCheckEdit.Checked;
                    dr[3] = maNVTextEdit.Text;
                    rowchange = dr;
                }
            }
            return rowchange;
        }

        void loadNguoiDung()
        {
            // TODO: This line of code loads data into the 'dataSetBida.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.dataSetBida.NGUOIDUNG);
            nguoidung = nGUOIDUNGTableAdapter.GetData();

            repositoryItemHyperLinkEdit1.Click += repositoryItemHyperLinkEdit1_Click;
        }

        //Xóa
        private void repositoryItemHyperLinkEdit1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa !!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var rowHandle = gridViewND.FocusedRowHandle;
                string tennd = gridViewND.GetRowCellValue(rowHandle, "TenDangNhap").ToString();

                nGUOIDUNGTableAdapter.Delete(tennd, string.Empty, false, string.Empty);
                MessageBox.Show("Xóa thành công !!");
                loadNguoiDung();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}