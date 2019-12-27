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
using DevExpress.XtraBars; //duyet Ribbon control
using DevExpress.LookAndFeel; //skin màu cho form
using DAL;
using BLL;

namespace demo23
{
    public partial class FrmChuyenBan : DevExpress.XtraEditors.XtraForm
    {
        public FrmChuyenBan()
        {
            InitializeComponent();
        }

        public string maban;
        Ban_BLL ban = new Ban_BLL();
        TamTinh_BLL tamtinh_bll = new TamTinh_BLL();

        private void FrmChuyenBan_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            txtBanCu.Text = ban.layTenBan(maban);
            cboBanMoi.DataSource = ban.layDSBanTru(maban);
            cboBanMoi.ValueMember = "MaBan";
            cboBanMoi.DisplayMember = "TenBan";

            txtTienThem.Text = "20000 đ"; //còn xử lý tiền chuyển bàn
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            string mabanmoi = cboBanMoi.SelectedValue.ToString();
            string matt = tamtinh_bll.layMaTamTinh(maban); // lấy mã tạm tính bàn cũ

            ban.capNhatTrangThai(mabanmoi, "Có khách");
            ban.capNhatTrangThai(maban, "Sẵn sàng đón khách");

            if(tamtinh_bll.suaTamTinh(matt, mabanmoi, 20000) == true){
                MessageBox.Show("Chuyển bàn từ bàn "+maban+" qua bàn "+mabanmoi+" thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Chuyển bàn từ bàn " + maban + " qua bàn " + mabanmoi + " thất bại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}