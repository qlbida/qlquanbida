using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QuanBida;
using DevExpress.XtraBars; //duyet Ribbon control
using DevExpress.LookAndFeel; //skin màu cho form
using DAL;
using BLL;

namespace demo23
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string tendn;

        SimpleButton btnChon;
        string maban;
        Ban_BLL ban = new Ban_BLL();

        DataTable banbida;
        DataTable trangthai;
        public bool dathanhtoan = false;

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(string tendn)
        {
            InitializeComponent();
            this.tendn = tendn;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           btnThoiGian.Caption = DateTime.Now.ToString();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            loadBan();
           
            //Chỗ truyền dữ liệu từ form đăng nhập
            btnNguoiDung.Caption += tendn;
            List<string> nhom = layNhom(tendn);

            //Phân quyền
            phanQuyen(tendn, nhom);
        }

        public void loadBan()
        {
            // TODO: This line of code loads data into the 'dataSetBida.CT_NHOMNGUOIDUNG_NGUOIDUNG' table. You can move, or remove it, as needed.
            this.cT_NHOMNGUOIDUNG_NGUOIDUNGTableAdapter.Fill(this.dataSetBida.CT_NHOMNGUOIDUNG_NGUOIDUNG);
            // TODO: This line of code loads data into the 'dataSetBida.CT_NHOMNGUOIDUNG_MANHINH' table. You can move, or remove it, as needed.
            this.cT_NHOMNGUOIDUNG_MANHINHTableAdapter.Fill(this.dataSetBida.CT_NHOMNGUOIDUNG_MANHINH);
            // TODO: This line of code loads data into the 'dataSetBida.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.dataSetBida.NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dataSetBida.TRANGTHAIBAN' table. You can move, or remove it, as needed.
            this.tRANGTHAIBANTableAdapter.Fill(this.dataSetBida.TRANGTHAIBAN);
            // TODO: This line of code loads data into the 'dataSetBida.BANBIDA' table. You can move, or remove it, as needed.
            this.bANBIDATableAdapter.Fill(this.dataSetBida.BANBIDA);

            banbida = bANBIDATableAdapter.GetData();
            trangthai = tRANGTHAIBANTableAdapter.GetData();

            taoBanBida(banbida, trangthai); 
        }


        //Xử lý hiện thị bàn overload
        //ADO
        void taoBanBida(DataTable dt1, DataTable dt2)
        {
            int soban = 1;
            int i = 0;
            int j = 0;

            foreach (DataRow row in dt1.Rows)
            {
                SimpleButton ban = new SimpleButton();
                ban.Width = 220;
                ban.Height = 150;
                ban.Top = 30 + i * 170;
                ban.Left = 80 + j * 240;

                ban.Name = "Btn" + soban.ToString();
                string[] trangthai = layTrangThaiBan(dt2, row["MaTrangThai"].ToString());

                ban.Text = row["TenBan"].ToString() + "\n" + trangthai[0];
                ban.Tag = row["MaBan"].ToString();

                ban.LookAndFeel.SetSkinStyle(trangthai[1]);
                ban.MouseDown += ban_MouseDown;
                ban.ContextMenuStrip = contextMSDatBan;

                //this.Controls.Add(ban);
                pnlBan.Controls.Add(ban);
                soban++;
                j++;
                if (j == 6)
                {
                    i++;
                    j = 0;
                }
            }
        }

        //LINQ
        void taoBanBida(List<BANBIDA> dsban)
        {
            int soban = 1;
            int i = 0;
            int j = 0;

            foreach (BANBIDA bida in dsban)
            {
                SimpleButton ban1 = new SimpleButton();
                ban1.Width = 220;
                ban1.Height = 150;
                ban1.Top = 30 + i * 170;
                ban1.Left = 80 + j * 240;

                ban1.Name = "Btn" + soban.ToString();

                ban1.Text = bida.TenBan + "\n" + ban.layTrangThai(bida.MaBan);
                ban1.Tag = bida.MaBan;

                ban1.LookAndFeel.SetSkinStyle(ban.layMauTrangThai(bida.MaBan));
                ban1.MouseDown += ban_MouseDown;
                ban1.ContextMenuStrip = contextMSDatBan;

                //this.Controls.Add(ban);
                pnlBan.Controls.Add(ban1);
                soban++;
                j++;
                if (j == 6)
                {
                    i++;
                    j = 0;
                }
            }
        }


        void ban_MouseDown(object sender, MouseEventArgs e)
        {
            btnChon = ((SimpleButton)sender);
        }

        void capNhatTinhTrangBan()
        {
            //int slPHat = 0, slpDon = 0, slPBaoTri = 0, slpTrong = 0, slDat = 0;
            foreach (SimpleButton btn in pnlBan.Controls.OfType<SimpleButton>())
            {
                string temp = btn.Text;
                string[] arrTemp = temp.Split('\n');
                string trangthai = arrTemp[1];

                btn.LookAndFeel.SetSkinStyle(ban.layMauTrangThai(btn.Tag.ToString()));
                btn.Text = arrTemp[0] +"\n"+ ban.layTrangThai(btn.Tag.ToString());

                //btnTrong.Text = "Phòng trống: " + slpTrong.ToString();
                //btnBaoTri.Text = "Bảo trì: " + slPBaoTri.ToString();
                //btnDangDon.Text = "Đang dọn: " + slpDon.ToString();
                //btnDangHat.Text = "Đang hát: " + slPHat.ToString();
                //btnDaDat.Text = "Đã đặt: " + slDat.ToString();
            }
        }

        //ADO
        string[] layTrangThaiBan(DataTable dt, string s)
        {
            string[] trangthai = new string[2];
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["MaTrangThai"].ToString() == s)
                {
                    trangthai[0] = dr["TenTrangThai"].ToString();
                    trangthai[1] = dr["Mau"].ToString();
                }
            }
            return trangthai;
        }

        //================================================================
        //xử lý context menu
        private void contextMSDatBan_Opening(object sender, CancelEventArgs e)
        {
            //lấy tình trạng của bàn
            string tinhtrang = ban.layTrangThai(btnChon.Tag.ToString());
            //string tinhtrang = "";
            //MessageBox.Show(tinhtrang);
            if (tinhtrang == "Sẵn sàng đón khách")
            {
                kháchVàoChơiToolStripMenuItem.Enabled = true;
                dọnBànToolStripMenuItem.Enabled = true;
                sửaBànToolStripMenuItem.Enabled = true;

                dọnBànToolStripMenuItem.Text = "Dọn bàn";
                sửaBànToolStripMenuItem.Text = "Sửa bàn";
                kháchVàoChơiToolStripMenuItem.Text = tinhtrang;

                cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
                thôngTinKháchToolStripMenuItem.Enabled = false;
                đổiBànToolStripMenuItem.Enabled = false;
            }
            else
            {
                if (tinhtrang == "Có khách")
                {
                    kháchVàoChơiToolStripMenuItem.Enabled = true;
                    kháchVàoChơiToolStripMenuItem.Text = "Thanh toán";
                    cậpNhậtDịchVụToolStripMenuItem.Enabled = true;
                    thôngTinKháchToolStripMenuItem.Enabled = true;
                    đổiBànToolStripMenuItem.Enabled = true;

                    dọnBànToolStripMenuItem.Text = "Dọn bàn";
                    sửaBànToolStripMenuItem.Text = "Sửa bàn";

                    dọnBànToolStripMenuItem.Enabled = false;
                    sửaBànToolStripMenuItem.Enabled = false;
                }
                else 
                {
                    if (tinhtrang == "Đang dọn dẹp")
                    {
                        cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
                        thôngTinKháchToolStripMenuItem.Enabled = false;
                        đổiBànToolStripMenuItem.Enabled = false;
                        sửaBànToolStripMenuItem.Enabled = false;
                        kháchVàoChơiToolStripMenuItem.Enabled = false;

                        kháchVàoChơiToolStripMenuItem.Text = "Sẵn sàng đón khách";

                        dọnBànToolStripMenuItem.Enabled = true;
                        dọnBànToolStripMenuItem.Text = "Kết thúc dọn bàn";
                    }
                    else //đang sửa chữa
                    {
                        cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
                        thôngTinKháchToolStripMenuItem.Enabled = false;
                        đổiBànToolStripMenuItem.Enabled = false;
                        dọnBànToolStripMenuItem.Enabled = false;
                        kháchVàoChơiToolStripMenuItem.Enabled = false;

                        kháchVàoChơiToolStripMenuItem.Text = "Sẵn sàng đón khách";

                        sửaBànToolStripMenuItem.Enabled = true;
                        sửaBànToolStripMenuItem.Text = "Kết thúc sửa chữa";
                    }
                }
            }
        }


        private void dọnBànToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dọnBànToolStripMenuItem.Text == "Kết thúc dọn bàn") //dọn dẹp xong
            {
                ban.capNhatTrangThai(btnChon.Tag.ToString(),"Sẵn sàng đón khách");
                capNhatTinhTrangBan();
            }
            else
            {
                ban.capNhatTrangThai(btnChon.Tag.ToString(), "Đang dọn dẹp");
                capNhatTinhTrangBan();
            }
        }

        private void sửaBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sửaBànToolStripMenuItem.Text == "Kết thúc sửa chữa")
            {
                ban.capNhatTrangThai(btnChon.Tag.ToString(), "Sẵn sàng đón khách");
                capNhatTinhTrangBan();
            }
            else
            {
                ban.capNhatTrangThai(btnChon.Tag.ToString(), "Đang sửa chữa");
                capNhatTinhTrangBan();
            }
        }


        private void thôngTinKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void cậpNhậtDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThueBan fm = new FrmThueBan();
            fm.maban = btnChon.Tag.ToString();
            fm.thanhtoan = true;
            fm.FormClosed += fm_FormClosed;
            fm.tendn = tendn;
            fm.ShowDialog();
        }

        private void kháchVàoChơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string temp = btnChon.Text;
            string[] arrTemp = temp.Split('\n');
            string trangthai = arrTemp[1];

            DateTime vao = DateTime.Now;

            if (trangthai == "Sẵn sàng đón khách")
            {
                FrmThueBan fm = new FrmThueBan();
                fm.maban = btnChon.Tag.ToString();
                fm.giovao = vao;
                fm.tendn = tendn;
                fm.FormClosed += fm_FormClosed;
                fm.ShowDialog();
            }
            else if (trangthai == "Có khách") //thành thanh toán
            {
                FrmThueBan fm = new FrmThueBan();
                fm.thanhtoan = true;
                fm.maban = btnChon.Tag.ToString();
                fm.FormClosed += fm_FormClosed; //dùng để load lại trạng thái bàn bên form main
                fm.tendn = tendn;
                fm.ShowDialog();
            }
        }

        void fm_FormClosed(object sender, FormClosedEventArgs e)
        {
            capNhatTinhTrangBan();
        }

        private void đổiBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChuyenBan fm = new FrmChuyenBan();
            fm.maban = btnChon.Tag.ToString();
            fm.FormClosed += fm_FormClosed;
            fm.ShowDialog();
        }

        //================================================================
        //Xử lý phân quyền
        void phanQuyen(string tennd, List<string> dsnhom)
        {
            foreach (string manhom in dsnhom)
            {
                List<string> quyen = timManHinhBiKhoa(manhom);

                foreach (var items in ribbonControlMain.Items)
                {
                    if (items is BarButtonItem)
                    {
                        BarButtonItem bbi = items as BarButtonItem;

                        if (quyen.Contains(bbi.Name) == true)
                            bbi.Enabled = false;
                            //MessageBox.Show(bbi.Name);
                    }
                }

  
            }
        }

        List<string> layNhom(string tennd)
        {
            DataTable pq = cT_NHOMNGUOIDUNG_NGUOIDUNGTableAdapter.GetData();
            List<string> nhom = new List<string>();
            foreach (DataRow dr in pq.Rows)
            {
                if (dr[0].ToString() == tennd)
                    nhom.Add(dr[1].ToString());
            }
            return nhom;
        }

        List<string> timManHinhBiKhoa(string manhom)
        {
            DataTable pq = cT_NHOMNGUOIDUNG_MANHINHTableAdapter.GetData();
            List<string> manhinh = new List<string>();
            foreach (DataRow dr in pq.Rows)
            {
                if (dr["MaNhom"].ToString() == manhom && dr["CoQuyen"].ToString() == "False")
                    manhinh.Add(dr["MaManHinh"].ToString());
            }
            return manhinh;
        }

        //================================================================
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắn chắc muốn thoát khỏi hệ thống ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.fdn.Show();
            }
        }

        private void barBtnNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNguoiDung fm = new FrmNguoiDung();
            fm.ShowDialog();
        }

        private void barBtnNhomND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNguoiDung_NhomND fm = new FrmNguoiDung_NhomND();
            fm.ShowDialog();
        }

        private void barBtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bANBIDABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bANBIDABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBida);

        }

        private void barBtnNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNhapHang fmnh = new FrmNhapHang();
            fmnh.tendn = tendn;
            fmnh.ShowDialog();
        }

        private void barBtnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDoiMatKhau fm = new FrmDoiMatKhau();
            fm.tennd = tendn;
            fm.ShowDialog();
        }

        private void barBtnNhaCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNhaCC fm = new FrmNhaCC();
            fm.ShowDialog();
        }

        private void barBtnBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBanHangKL fm = new FrmBanHangKL();
            fm.tendn = tendn;
            fm.ShowDialog();
        }

        private void barBtnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPhanQuyen fm = new FrmPhanQuyen();
            fm.ShowDialog();
        }

        private void barBtnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKhachHang fm = new FrmKhachHang();
            fm.ShowDialog();
        }

        private void barBtnLoaiHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmHangHoa fm = new FrmHangHoa();
            fm.ShowDialog();
        }

        private void barBtnMatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmHangHoa fm = new FrmHangHoa();
            fm.ShowDialog();
        }

        private void barBtnLienHe_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmLienHe fm = new FrmLienHe();
            fm.ShowDialog();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void barBtnBCTongHop_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDoanhThu fm = new FrmDoanhThu();
            fm.ShowDialog();
        }

        private void barBtnCongNo_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCongNo fm = new FrmCongNo();
            fm.ShowDialog();
        }

        //lọc và sắp xếp
        //tình trạng bàn
        private void barBtnCoKhach_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlBan.Controls.Clear();
            taoBanBida(ban.layDSBanTheoTT("MTT002"));
        }

        private void barBtnTrong_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlBan.Controls.Clear();
            taoBanBida(ban.layDSBanTheoTT("MTT001"));
        }

        private void barBtnDonDep_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlBan.Controls.Clear();
            taoBanBida(ban.layDSBanTheoTT("MTT004"));
        }

        private void barBtnSuaChua_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlBan.Controls.Clear();
            taoBanBida(ban.layDSBanTheoTT("MTT003"));
        }

        //loại
        private void barBtnBida3Lo_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlBan.Controls.Clear();
            taoBanBida(ban.layDSBanTheoLoai("MLB01"));
        }

        private void barBtnBidaBang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlBan.Controls.Clear();
            taoBanBida(ban.layDSBanTheoLoai("MLB02"));
        }

        //khu vực
        private void barBtnVIP_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlBan.Controls.Clear();
            taoBanBida(ban.layDSBanTheoKV("1"));
        }

        private void barBtnThuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlBan.Controls.Clear();
            taoBanBida(ban.layDSBanTheoKV("2"));
        }

        private void barBtnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }



    }
}
 