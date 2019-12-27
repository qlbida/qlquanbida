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
using DAL;
using BLL;
namespace demo23
{
    public partial class FrmBanHangKL : DevExpress.XtraEditors.XtraForm
    {

        public FrmBanHangKL()
        {
            InitializeComponent();
        }


        public string MaLoai = "";
        public string TenHang = "";
        public DataTable HangTheoTen ;
        public DataTable HangTheoMa;
        int _thanhtien = 0;
        public string tendn;

        HoaDon_BLL hoadon_BLL = new HoaDon_BLL();
        HangHoa_BLL hanghoa_BLL = new HangHoa_BLL();

        private void FrmBanHangKL_Load(object sender, EventArgs e)
        {                       
            // TODO: This line of code loads data into the 'dataSetBida.HANGHOA' table. You can move, or remove it, as needed.
            
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            
            //Gán giá trị cho combobox
            string[] kieuin = {"In nhiệt", "In thường", "In nhiệt 58"};
            comboKieuIn.Properties.Items.AddRange(kieuin);
            comboKieuIn.SelectedIndex = 0;
            comboLoaiKhach.Text = "Khách lẻ";
            numericSoLuong.Value = 1;

            loadTheoTen(TenHang);
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
                HangTheoTen = tENHANGTableAdapter.GetData_TenHang(tenhang);
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
                HangTheoMa = mAHANGTableAdapter.GetData_MaLoai(tenhang,MaLoai);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void repositoryItemHyperLinkEditTA_Click(object sender, EventArgs e)
        {
            //xuLyThem();
        }
        private void repositoryItemHyperLinkEditDU_Click(object sender, EventArgs e)
        {
            //xuLyThem();
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
            if (MessageBox.Show("Bạn có chắc muốn thoát !!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        private void GV_MatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool kt = true;
                int index = GV_MatHang.CurrentCell.RowIndex;
                int sltru = Int32.Parse(GV_MatHang.Rows[index].Cells[2].Value.ToString());
                sltru--;
                GV_MatHang.Rows[index].Cells[2].Value = sltru;
                for (int i = 0; i < DGV_GioHang.Rows.Count; i++)
                {
                    if (GV_MatHang.Rows[index].Cells[0].Value.ToString() == DGV_GioHang.Rows[i].Cells[0].Value.ToString())
                    {
                        int slcong = Int32.Parse(DGV_GioHang.Rows[i].Cells[2].Value.ToString());
                        slcong++;
                        DGV_GioHang.Rows[i].Cells[2].Value = slcong;
                        kt = false;
                        break;
                    }
                }
                if (kt)
                {
                    int row = 0;
                    DGV_GioHang.Rows.Add();
                    row = DGV_GioHang.Rows.Count - 1;
                    DGV_GioHang.Rows[row].Cells[0].Value = GV_MatHang.Rows[index].Cells[0].Value.ToString();
                    DGV_GioHang.Rows[row].Cells[1].Value = GV_MatHang.Rows[index].Cells[1].Value.ToString();
                    DGV_GioHang.Rows[row].Cells[2].Value = 1;
                    DGV_GioHang.Rows[row].Cells[3].Value = GV_MatHang.Rows[index].Cells[3].Value.ToString();                    
                    DGV_GioHang.Refresh();
                }
                xuLy_TongTien_ThanhToan_No();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_GioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = DGV_GioHang.CurrentCell.RowIndex;
                int sltru = Int32.Parse(DGV_GioHang.Rows[index].Cells[2].Value.ToString());
                sltru--;
                if (sltru == 0)
                {
                    
                    for (int i = 0; i < GV_MatHang.Rows.Count; i++)
                    {
                        if (DGV_GioHang.Rows[index].Cells[0].Value.ToString() == GV_MatHang.Rows[i].Cells[0].Value.ToString())
                        {
                            int slcong = Int32.Parse(GV_MatHang.Rows[i].Cells[2].Value.ToString());
                            slcong++;
                            GV_MatHang.Rows[i].Cells[2].Value = slcong;
                        }
                    }
                    DGV_GioHang.Rows.RemoveAt(index);
                }
                else
                {
                    DGV_GioHang.Rows[index].Cells[2].Value = sltru;
                    for (int i = 0; i < GV_MatHang.Rows.Count; i++)
                    {
                        if (DGV_GioHang.Rows[index].Cells[0].Value.ToString() == GV_MatHang.Rows[i].Cells[0].Value.ToString())
                        {
                            int slcong = Int32.Parse(GV_MatHang.Rows[i].Cells[2].Value.ToString());
                            slcong++;
                            GV_MatHang.Rows[i].Cells[2].Value = slcong;
                            break;
                        }
                    }
                }
                xuLy_TongTien_ThanhToan_No();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void mAHANGDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool kt = true;
            int index = mAHANGDataGridView1.CurrentCell.RowIndex;
            int sltru = Int32.Parse(mAHANGDataGridView1.Rows[index].Cells[2].Value.ToString());
            sltru--;
            mAHANGDataGridView1.Rows[index].Cells[2].Value = sltru;
            for (int i = 0; i < DGV_GioHang.Rows.Count; i++)
            {
                if (mAHANGDataGridView1.Rows[index].Cells[0].Value.ToString() == DGV_GioHang.Rows[i].Cells[0].Value.ToString())
                {
                    int slcong = Int32.Parse(DGV_GioHang.Rows[i].Cells[2].Value.ToString());
                    slcong++;
                    DGV_GioHang.Rows[i].Cells[2].Value = slcong;
                    kt = false;
                    break;
                }
            }
            if (kt)
            {
                int row = 0;
                DGV_GioHang.Rows.Add();
                row = DGV_GioHang.Rows.Count - 1;
                DGV_GioHang.Rows[row].Cells[0].Value = mAHANGDataGridView1.Rows[index].Cells[0].Value.ToString();
                DGV_GioHang.Rows[row].Cells[1].Value = mAHANGDataGridView1.Rows[index].Cells[1].Value.ToString();
                DGV_GioHang.Rows[row].Cells[2].Value = 1;
                DGV_GioHang.Rows[row].Cells[3].Value = mAHANGDataGridView1.Rows[index].Cells[3].Value.ToString();                
                DGV_GioHang.Refresh();
            }
            xuLy_TongTien_ThanhToan_No();
        }

        private void mAHANGDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool kt = true;
            int index = mAHANGDataGridView.CurrentCell.RowIndex;
            int sltru = Int32.Parse(mAHANGDataGridView.Rows[index].Cells[2].Value.ToString());
            sltru--;
            mAHANGDataGridView.Rows[index].Cells[2].Value = sltru;
            for (int i = 0; i < DGV_GioHang.Rows.Count; i++)
            {
                if (mAHANGDataGridView.Rows[index].Cells[0].Value.ToString() == DGV_GioHang.Rows[i].Cells[0].Value.ToString())
                {
                    int slcong = Int32.Parse(DGV_GioHang.Rows[i].Cells[2].Value.ToString());
                    slcong++;
                    DGV_GioHang.Rows[i].Cells[2].Value = slcong;
                    kt = false;
                    break;
                }
            }
            if (kt)
            {
                int row = 0;
                DGV_GioHang.Rows.Add();
                row = DGV_GioHang.Rows.Count - 1;
                DGV_GioHang.Rows[row].Cells[0].Value = mAHANGDataGridView.Rows[index].Cells[0].Value.ToString();
                DGV_GioHang.Rows[row].Cells[1].Value = mAHANGDataGridView.Rows[index].Cells[1].Value.ToString();
                DGV_GioHang.Rows[row].Cells[2].Value = 1;
                DGV_GioHang.Rows[row].Cells[3].Value = mAHANGDataGridView.Rows[index].Cells[3].Value.ToString();                
                DGV_GioHang.Refresh();
            }
            xuLy_TongTien_ThanhToan_No();
        }

        //Xử lý tính toán các ô tổng tiền, thanh toán, còn nợ
        public void xuLy_TongTien_ThanhToan_No()
        {
           
            if(_thanhtien != 0)
                _thanhtien = 0;
            for (int i = 0; i < DGV_GioHang.Rows.Count; i++)
            {
                int _soluong = Int32.Parse(DGV_GioHang.Rows[i].Cells[2].Value.ToString());
                int _dongia = Int32.Parse(DGV_GioHang.Rows[i].Cells[3].Value.ToString());
                int _tongtien = _soluong * _dongia;
                _thanhtien += _tongtien;
            }
            txtTongTien.Text = _thanhtien.ToString();
            txtThanhToan.Text = _thanhtien.ToString();
            if (txtTongTien.Text == txtThanhToan.Text)
                txtConNo.Text = "0";
            else
                txtConNo.Text = (_thanhtien - int.Parse(txtThanhToan.Text)).ToString();
          
        }

        private void txtThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTongTien.Text == txtThanhToan.Text)
                txtConNo.Text = "0";
            else if (txtThanhToan.Text == "")
                txtConNo.Text = txtTongTien.Text;
            else
                txtConNo.Text = (_thanhtien - int.Parse(txtThanhToan.Text)).ToString();  
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int dem = 0;
            string mahd = "";
            for (int i = 0; i < DGV_GioHang.Rows.Count; i++)
            {
                int tongtien = int.Parse(txtTongTien.Text);
                if (tongtien > 0) //có mua hàng
                {
                    dem += 1;
                    if (dem == 1)
                    {
                        //thêm hóa đơn 1 lần
                        HOADON hd = new HOADON();
                        mahd = "HD" + XuLy.TaoMaRandom.taoMaRandom();
                        hd.MaHD = mahd;
                        hd.MaNV = hoadon_BLL.layMaNV(tendn);                       
                        hd.NgayLap = DateTime.Now;
                        hoadon_BLL.themHoaDon(hd);
                        hd.MaKH = "KH001"; //mặc định khách hàng có mã KH001 là khách lẻ
                    }

                    //thêm chi tiết hóa đơn nhiều lần
                    CT_HOADON cthd = new CT_HOADON();
                    cthd.MaHD = mahd;
                    cthd.MaHang = DGV_GioHang.Rows[i].Cells[0].Value.ToString();
                    cthd.SoLuongBan = float.Parse(DGV_GioHang.Rows[i].Cells[2].Value.ToString());
                    cthd.DonGiaBan = float.Parse(DGV_GioHang.Rows[i].Cells[3].Value.ToString());
                    cthd.ThanhTien = (float.Parse(DGV_GioHang.Rows[i].Cells[2].Value.ToString())) * (float.Parse(DGV_GioHang.Rows[i].Cells[3].Value.ToString()));
                    hoadon_BLL.themCTHD(cthd);

                    //cập nhật số lượng tồn của hàng hóa
                    float soluongban = float.Parse(DGV_GioHang.Rows[i].Cells[2].Value.ToString());                  
                    string mahh = DGV_GioHang.Rows[i].Cells[0].Value.ToString();
                    if (hanghoa_BLL.capNhatSLTonHH(mahh, soluongban))
                        MessageBox.Show("Thêm 1 chi tiết hóa đơn thành công !!");
                    else
                        MessageBox.Show("Thêm 1 chi tiết hóa đơn thất bại !!");
                }
            }

            if (dem > 0) //chắc chắn đã tạo hóa đơn 
            {
                //cập nhập tổng giá trị, tiền nợ cho hóa đơn
                if (hoadon_BLL.capNhapHDKhachMuaLe(mahd, float.Parse(txtTongTien.Text), float.Parse(txtConNo.Text)))
                {
                    MessageBox.Show("Lưu hóa đơn thành công !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadTheoTen("");
                    clearDGVGioHang();
                }
                else
                    MessageBox.Show("Lưu hóa đơn thất bại !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        void clearDGVGioHang()
        {
            for (int i = 0; i < DGV_GioHang.Rows.Count; i++)
            {
                DGV_GioHang.Rows.RemoveAt(i);
            }
        }


    }
}