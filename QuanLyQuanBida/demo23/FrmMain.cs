using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpf.Ribbon;
using System.Data.SqlClient;
using QuanBida;
using DevExpress.XtraBars;

namespace demo23
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<SimpleButton> dsban = new List<SimpleButton>();
        public string tendn;

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

            DataTable banbida = bANBIDATableAdapter.GetData();
            DataTable trangthai = tRANGTHAIBANTableAdapter.GetData();

            int soban = banbida.Rows.Count;  
            taoBanBida(soban, banbida, trangthai); 

            //Chỗ truyền dữ liệu từ form đăng nhập
            btnNguoiDung.Caption += tendn;
            List<string> nhom = layNhom(tendn);

            btnNhomQuyen.Caption += nhom.First(); //mặc định lấy nhóm tìm được đầu tiên để hiện thị

            //Phân quyền
            phanQuyen(tendn, nhom);

            //List<string> a = timManHinhBiKhoa(nhom.First());
            //foreach (string mh in a)
            //    MessageBox.Show(mh);
        }

        //Xử lý hiện thị bàn
        void taoBanBida(int n, DataTable dt1, DataTable dt2)
        {
            int soban = 1;
            for (int i = 1; i <= Math.Ceiling((double)n / 6); i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    SimpleButton ban = new SimpleButton();
                    

                    if (soban <= n)
                    {
                        DataRow row = dt1.Rows[soban - 1];
                        ban.Size = new Size(200, 200);
                        ban.Top = i * 250;
                        ban.Left = j * 250;

                        
                        //ban.Text = "Bàn " + soban.ToString() + "\n Sẵn sàng đón khách";
                        ban.Name = "Btn" + soban.ToString();
                        string[] trangthai = layTrangThaiBan(dt2, row["MaTrangThai"].ToString());

                        ban.Text = row["TenBan"].ToString() + "\n" + trangthai[0];

                        ban.LookAndFeel.SetSkinStyle(trangthai[1]);
                        ban.ContextMenuStrip = contextMSDatBan;

                        this.Controls.Add(ban);
                        dsban.Add(ban);
                        soban++;
                    }
                }
            }
        }

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
            Program.fdn.Show();
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
            FrmNhapHang fm = new FrmNhapHang();
            fm.ShowDialog();
        }

        private void barBtnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDoiMatKhau fm = new FrmDoiMatKhau();
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

    }
}
 