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
using BLL;
using DAL;
using XuLy;

namespace demo23
{
    public partial class FrmThueBan : DevExpress.XtraEditors.XtraForm
    {
        public string MaLoai = "";
        public string TenHang = "";
        public string maban;
        public string tendn;
        public float tienchuyenban = 0;

        Ban_BLL ban = new Ban_BLL();
        TamTinh_BLL tamtinh_bll = new TamTinh_BLL();
        HoaDon_BLL hoadon_bll = new HoaDon_BLL();
        HangHoa_BLL hanghoa_bll = new HangHoa_BLL();

        public DateTime giovao;
        DateTime giora;
        TimeSpan tgchoi;
        float dongiaban = 0;
        float tienban = 0;

        public bool thanhtoan = false;
        string makhach;
        string matamtinh = "";

        int check = 0;

        public FrmThueBan()
        {
            InitializeComponent();
        }

        private void FrmThueBan_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            loadTheoTen(TenHang);
            timerDem.Start();

            txtTenBan.Text = ban.layTenBan(maban);
            txtLoaiBan.Text = ban.layTenLoai(maban);

            makhach = "KH" + XuLy.TaoMaRandom.taoMaRandom();

            //thanh toán
            if (thanhtoan == true)
            {
                btnLuu.Text = "Thanh toán";
                matamtinh = tamtinh_bll.layMaTamTinh(maban);
                //MessageBox.Show(matamtinh);

                TAMTINH tamtinh = tamtinh_bll.layTamTinh(matamtinh);
                giovao = (DateTime)tamtinh.GioDatBan;
                tienchuyenban = (float)tamtinh.TienChuyenBan;
                txtVao.Text = String.Format("{0:G}",giovao);
            }

            if (matamtinh != "")
            {
                int index = dtgvCTHD.Rows.Count - 1;
                foreach (CT_TAMTINH ct in tamtinh_bll.layCTTT(matamtinh))
                {
                    index++;
                    dtgvCTHD.Rows.Add();
                    dtgvCTHD.Rows[index].Cells[0].Value = ct.MaHang;
                    dtgvCTHD.Rows[index].Cells[1].Value = hanghoa_bll.layTenHang(ct.MaHang);
                    dtgvCTHD.Rows[index].Cells[2].Value = ct.SoLuongBan;
                    dtgvCTHD.Rows[index].Cells[3].Value = ct.DonGiaBan;
                }
            }

            dongiaban = ban.layDonGia(maban);

            txtChuyenBan.Text = tienchuyenban.ToString();
            txtVao.Text = String.Format("{0:G}", giovao); //h:mm:ss  tt
        }

        TimeSpan tinhGioChoi(DateTime giovao, DateTime giora)
        {
            return giora.Subtract(giovao);
        }

        float tinhTienBan(TimeSpan khoangtg, float dongiaban)
        {
            return (khoangtg.Hours + (khoangtg.Minutes / (float)60.0)) * dongiaban;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TenHang = txtTimKiem.Text;
            if (MaLoai == "")
                loadTheoTen(TenHang);
            else
                loadTheoTenVaLoai(TenHang);
        }

        void loadTheoTen(string tenhang)
        {
            try
            {
                this.tENHANGTableAdapter.Fill_TenHang(this.dataSetBida.TENHANG, tenhang);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }            
        }

        void loadTheoTenVaLoai(string tenhang)
        {
            try
            {
                this.mAHANGTableAdapter.Fill_MaLoai(this.dataSetBida.MAHANG, tenhang, MaLoai);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void xtraTabControlDV_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControlDV.SelectedTabPage.Name != "MLH001" && xtraTabControlDV.SelectedTabPage.Name != "MLH002")
                loadTheoTen(TenHang);
            else
            {
                MaLoai = xtraTabControlDV.SelectedTabPage.Name;
                loadTheoTenVaLoai(TenHang);
                MaLoai = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mAHANGDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool kt = true;
            int index = mAHANGDataGridView1.CurrentCell.RowIndex;
            int sltru = Int32.Parse(mAHANGDataGridView1.Rows[index].Cells[2].Value.ToString());
            sltru--;
            mAHANGDataGridView1.Rows[index].Cells[2].Value = sltru;
            for (int i = 0; i < dtgvCTHD.Rows.Count; i++)
            {
                if (mAHANGDataGridView1.Rows[index].Cells[0].Value.ToString() == dtgvCTHD.Rows[i].Cells[0].Value.ToString())
                {
                    int slcong = Int32.Parse(dtgvCTHD.Rows[i].Cells[2].Value.ToString());
                    slcong++;
                    dtgvCTHD.Rows[i].Cells[2].Value = slcong;
                    kt = false;
                    break;
                }
            }
            if (kt)
            {
                int row = 0;
                dtgvCTHD.Rows.Add();
                row = dtgvCTHD.Rows.Count - 1;
                dtgvCTHD.Rows[row].Cells[0].Value = mAHANGDataGridView1.Rows[index].Cells[0].Value.ToString();
                dtgvCTHD.Rows[row].Cells[1].Value = mAHANGDataGridView1.Rows[index].Cells[1].Value.ToString();
                dtgvCTHD.Rows[row].Cells[2].Value = 1;
                dtgvCTHD.Rows[row].Cells[3].Value = mAHANGDataGridView1.Rows[index].Cells[3].Value.ToString();
                dtgvCTHD.Refresh();
            }
            txtDichVu.Text = tinhTienDichVu().ToString();
        }

        private void tENHANGDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool kt = true;
            int index = tENHANGDataGridView.CurrentCell.RowIndex;
            int sltru = Int32.Parse(tENHANGDataGridView.Rows[index].Cells[2].Value.ToString());
            sltru--;
            tENHANGDataGridView.Rows[index].Cells[2].Value = sltru;
            for (int i = 0; i < dtgvCTHD.Rows.Count; i++)
            {
                if (tENHANGDataGridView.Rows[index].Cells[0].Value.ToString() == dtgvCTHD.Rows[i].Cells[0].Value.ToString())
                {
                    int slcong = Int32.Parse(dtgvCTHD.Rows[i].Cells[2].Value.ToString());
                    slcong++;
                    dtgvCTHD.Rows[i].Cells[2].Value = slcong;
                    kt = false;
                    break;
                }
            }
            if (kt)
            {
                int row = 0;
                dtgvCTHD.Rows.Add();
                row = dtgvCTHD.Rows.Count - 1;
                dtgvCTHD.Rows[row].Cells[0].Value = tENHANGDataGridView.Rows[index].Cells[0].Value.ToString();
                dtgvCTHD.Rows[row].Cells[1].Value = tENHANGDataGridView.Rows[index].Cells[1].Value.ToString();
                dtgvCTHD.Rows[row].Cells[2].Value = 1;
                dtgvCTHD.Rows[row].Cells[3].Value = tENHANGDataGridView.Rows[index].Cells[3].Value.ToString();
                dtgvCTHD.Refresh();
            }
            txtDichVu.Text = tinhTienDichVu().ToString();
        }

        private void mAHANGDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool kt = true;
            int index = mAHANGDataGridView.CurrentCell.RowIndex;
            int sltru = Int32.Parse(mAHANGDataGridView.Rows[index].Cells[2].Value.ToString());
            sltru--;
            mAHANGDataGridView.Rows[index].Cells[2].Value = sltru;
            for (int i = 0; i < dtgvCTHD.Rows.Count; i++)
            {
                if (mAHANGDataGridView.Rows[index].Cells[0].Value.ToString() == dtgvCTHD.Rows[i].Cells[0].Value.ToString())
                {
                    int slcong = Int32.Parse(dtgvCTHD.Rows[i].Cells[2].Value.ToString());
                    slcong++;
                    dtgvCTHD.Rows[i].Cells[2].Value = slcong;
                    kt = false;
                    break;
                }
            }
            if (kt)
            {
                int row = 0;
                dtgvCTHD.Rows.Add();
                row = dtgvCTHD.Rows.Count - 1;
                dtgvCTHD.Rows[row].Cells[0].Value = mAHANGDataGridView.Rows[index].Cells[0].Value.ToString();
                dtgvCTHD.Rows[row].Cells[1].Value = mAHANGDataGridView.Rows[index].Cells[1].Value.ToString();
                dtgvCTHD.Rows[row].Cells[2].Value = 1;
                dtgvCTHD.Rows[row].Cells[3].Value = mAHANGDataGridView.Rows[index].Cells[3].Value.ToString();
                dtgvCTHD.Refresh();
            }
            txtDichVu.Text = tinhTienDichVu().ToString();
        }

        //dtgv cthd
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dtgvCTHD.CurrentCell.RowIndex;
                int sltru = Int32.Parse(dtgvCTHD.Rows[index].Cells[2].Value.ToString());
                sltru--;
                if (sltru == 0)
                {
                    dtgvCTHD.Rows[index].Cells[2].Value = sltru;
                    for (int i = 0; i < tENHANGDataGridView.Rows.Count; i++)
                    {
                        if (dtgvCTHD.Rows[index].Cells[0].Value.ToString() == tENHANGDataGridView.Rows[i].Cells[0].Value.ToString())
                        {
                            int slcong = Int32.Parse(tENHANGDataGridView.Rows[i].Cells[2].Value.ToString());
                            slcong++;
                            tENHANGDataGridView.Rows[i].Cells[2].Value = slcong;
                            break;
                        }
                    }
                    dtgvCTHD.Rows.RemoveAt(index);
                }
                else
                {
                    dtgvCTHD.Rows[index].Cells[2].Value = sltru;
                    for (int i = 0; i < tENHANGDataGridView.Rows.Count; i++)
                    {
                        if (dtgvCTHD.Rows[index].Cells[0].Value.ToString() == tENHANGDataGridView.Rows[i].Cells[0].Value.ToString())
                        {
                            int slcong = Int32.Parse(tENHANGDataGridView.Rows[i].Cells[2].Value.ToString());
                            slcong++;
                            tENHANGDataGridView.Rows[i].Cells[2].Value = slcong;
                            break;
                        }
                    }
                }
                txtDichVu.Text = tinhTienDichVu().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmThueBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check == 0) //chưa thanh toán thì mới lưu tự động
            {
                MessageBox.Show("Hệ thống sẽ tự động lưu những thay đổi !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                luuTamTinh();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text == "Thanh toán") //lưu hóa đơn
            {
                if (txtThanhToan.Text == "")
                {
                    MessageBox.Show("Hãy nhập số tiền khách thanh toán !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtThanhToan.Focus();
                }
                else //nhập tiền thanh toán mới cho thanh toán
                {
                    string mahd = "";
                    timerDem.Stop();
                    HOADON hd = new HOADON();
                    mahd = "HD" + XuLy.TaoMaRandom.taoMaRandom();
                    hd.MaHD = mahd;
                    hd.MaNV = hoadon_bll.layMaNV(tendn);
                    //hd.MaKH = makhach; //thêm khách hàng trước         

                    hd.TienBan = tienban;
                    hd.MaBan = maban;
                    hd.NgayLap = DateTime.Now.Date;

                    hd.GioDatBan = giovao;
                    hd.GioTraBan = giora;
                    hd.TGChoi = String.Format("{0:hh\\:mm\\:ss}", tgchoi);
                    MessageBox.Show("Thời gian khách chơi là: "+tgchoi.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    hoadon_bll.themHoaDon(hd);
                    List<CTHoaDonReport> ds = new List<CTHoaDonReport>();

                    for (int i = 0; i < dtgvCTHD.Rows.Count; i++)
                    {
                        //thêm chi tiết nhiều lần
                        float sltemp = float.Parse(dtgvCTHD.Rows[i].Cells["SL"].Value.ToString());
                        float dgtemp = float.Parse(dtgvCTHD.Rows[i].Cells["DG"].Value.ToString());
                        string mahang = dtgvCTHD.Rows[i].Cells["MaHang"].Value.ToString();

                        hanghoa_bll.capNhatSLTonHH(mahang, sltemp); //trừ đi số lượng của mặt hàng đó

                        CT_HOADON cthd = new CT_HOADON();
                        cthd.MaHD = mahd;
                        cthd.MaHang = mahang;
                        cthd.DonGiaBan = dgtemp;
                        cthd.SoLuongBan = sltemp;
                        cthd.ThanhTien = sltemp * dgtemp;

                        CTHoaDonReport cthdrp = new CTHoaDonReport();
                        cthdrp.TenHang = hanghoa_bll.layTenHang(mahang);
                        cthdrp.DonGia = dgtemp;
                        cthdrp.SoLuong = sltemp;
                        cthdrp.DonViTinh = hanghoa_bll.layDonViTinh(mahang);
                        cthdrp.ThanhTien = sltemp * dgtemp;

                        ds.Add(cthdrp);

                        hoadon_bll.themCTHD(cthd);
                    }

                    float thueVAT = float.Parse(txtThue.Text);
                    float tiendv = float.Parse(txtDichVu.Text);
                    float tonggt = float.Parse(txtChuyenBan.Text) + float.Parse(txtDichVu.Text) + float.Parse(txtTienBan.Text) + tienchuyenban;
                    float thanhtien = float.Parse(txtThanhTien.Text);
                    float tienno = float.Parse(txtTienNo.Text);

                    if (hoadon_bll.capnhatHDBan(mahd, tienchuyenban, tiendv, thueVAT, tonggt, thanhtien, tienno))
                    {
                        MessageBox.Show("Thanh toán của " + txtTenBan.Text + " thành công !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearDGVGioHang();
                        ban.capNhatTrangThai(maban, "Đang dọn dẹp");
                        loadTheoTen(TenHang);

                        //đã thanh toán rồi thì xóa tạm tính của bàn đó
                        xoaCTTT(matamtinh);
                        tamtinh_bll.xoaTamTinh(matamtinh);

                        check = 1;

                        //in hóa đơn
                        FromInHoaDon frm = new FromInHoaDon();
                        HoaDonRP hdrp = new HoaDonRP();
                        hdrp.MaHD = mahd;
                        hdrp.MaNV = hoadon_bll.layMaNV(tendn);
                        hdrp.MaBan = maban;
                        hdrp.GioVao = giovao;
                        hdrp.GioRa = giora;
                        hdrp.NgayLap = String.Format("{0:M/d/yyyy}", DateTime.Now);
                        hdrp.TienBan = tienban;
                        hdrp.TienChuyenBan = tienchuyenban;
                        hdrp.TongTien = thanhtien;
                        hdrp.TienThanhToan = float.Parse(txtThanhToan.Text);
                        hdrp.ConNo = tienno;

                        MessageBox.Show("Hãy chờ hóa đơn được in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frm.inHoaDon(hdrp, ds);
                        frm.ShowDialog();
                    }
                    else
                        MessageBox.Show("Thanh toán thất bại !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else //lưu vào tạm tính
            {
                luuTamTinh();
            }

         }

        void luuTamTinh()
        {
            if (matamtinh == "") //lưu lần đầu
            {
                TAMTINH tt = new TAMTINH();
                matamtinh = "TT" + XuLy.TaoMaRandom.taoMaRandom();
                tt.MaTamTinh = matamtinh;
                tt.MaNV = hoadon_bll.layMaNV(tendn);
                tt.MaKhach = makhach;
                tt.TienBan = float.Parse(txtTienBan.Text); //tiền bàn = 0
                tt.MaBan = maban;
                tt.GioDatBan = giovao;
                tt.TienChuyenBan = 0;

                if (tamtinh_bll.themTamTinh(tt))
                {
                    MessageBox.Show("Đặt bàn " + txtTenBan.Text + " thành công !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    themCTTT(matamtinh); //thêm với mã tt mới
                    ban.capNhatTrangThai(maban, "Có khách");
                }
                else
                    MessageBox.Show("Đặt bàn thất bại !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else //update
            {
                xoaCTTT(matamtinh); //vì hàng hóa có thể thêm hoặc bớt, để dễ xử lý ta xóa hết và thêm lại mới
                themCTTT(matamtinh);
                MessageBox.Show("Những thay đổi đã lưu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        float tinhTienDichVu()
        {
            float tiendv = 0;
            for (int i = 0; i < dtgvCTHD.Rows.Count; i++)
            {
                float sltemp = float.Parse(dtgvCTHD.Rows[i].Cells["SL"].Value.ToString());
                float dgtemp = float.Parse(dtgvCTHD.Rows[i].Cells["DG"].Value.ToString());
                tiendv += sltemp * dgtemp;
            }
            return tiendv;
        }

        float tinhThanhTien(float thueVAT)
        {
            float tonggt = float.Parse(txtChuyenBan.Text) + float.Parse(txtDichVu.Text) + float.Parse(txtTienBan.Text);
            return tonggt*(1+thueVAT/100);
        }

        void clearDGVGioHang()
        {
            for (int i = 0; i < dtgvCTHD.Rows.Count; i++)
            {
                dtgvCTHD.Rows.RemoveAt(i);
            }
        }

        private void txtThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                float tienno = float.Parse(txtThanhTien.Text) - float.Parse(txtThanhToan.Text);
                if (tienno < 0)
                    txtTienNo.Text = "0";
                else
                    txtTienNo.Text = tienno.ToString();
            }
            catch
            {
                txtThanhToan.Text = "0";
            }
        }

        private void txtThue_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = tinhThanhTien(float.Parse(txtThue.Text)).ToString();
            }
            catch { }
        }

        private void txtDichVu_EditValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = tinhThanhTien(float.Parse(txtThue.Text)).ToString();
        }

        private void timerDem_Tick(object sender, EventArgs e)
        {
            giora = DateTime.Now;
            txtRa.Text = String.Format("{0:G}", giora);

            tgchoi = tinhGioChoi(giovao, giora);
            dongiaban = ban.layDonGia(maban);
            tienban = tinhTienBan(tgchoi, dongiaban);
            //MessageBox.Show(tienban.ToString());

            txtDichVu.Text = tinhTienDichVu().ToString();
            txtTienBan.Text = tienban.ToString();

            //txtThanhTien.Text = tinhThanhTien(float.Parse(txtThue.Text)).ToString();
        }

        void xoaCTTT(string matamtinh)
        {
            foreach (CT_TAMTINH cttt in tamtinh_bll.layCTTT(matamtinh))
                tamtinh_bll.xoaChiTietTT(matamtinh, cttt.MaHang);
        }

        void themCTTT(string mtt)
        {
            if (dtgvCTHD.Rows.Count > 0) //nếu có kèm dịch vụ mới lưu ct tạm tính
            {
                for (int i = 0; i < dtgvCTHD.Rows.Count; i++)
                {
                    float sltemp = float.Parse(dtgvCTHD.Rows[i].Cells["SL"].Value.ToString());
                    float dgtemp = float.Parse(dtgvCTHD.Rows[i].Cells["DG"].Value.ToString());
                    string mahang = dtgvCTHD.Rows[i].Cells["MaHang"].Value.ToString();
                    float thanhtien = sltemp * dgtemp;

                    CT_TAMTINH cttt = new CT_TAMTINH();
                    cttt.MaTamTinh = mtt;
                    cttt.MaHang = mahang;
                    cttt.DonGiaBan = dgtemp;
                    cttt.SoLuongBan = sltemp;
                    cttt.ThanhTien = thanhtien;

                    if (tamtinh_bll.themCTTT(cttt) == false)
                        MessageBox.Show("Lưu 1 chi tiết thất bại !!");
                }

            }
        }
    }
}