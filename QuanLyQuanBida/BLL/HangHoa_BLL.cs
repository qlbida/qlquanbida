using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class HangHoa_BLL
    {
        HangHoa_DAL hanghoa_DAL = new HangHoa_DAL();

        public List<string> load_CBB_DonViTinh()
        {
            return hanghoa_DAL.LoadDonViTinh();
        }

        public List<string> Load_CBB_LoaiHang()
        {
            return hanghoa_DAL.XuatLoaiHang();
        }

        public List<LOAIHANG> Load_DGV_LoaiHang()
        {
            return hanghoa_DAL.Xuat_Bang_LoaiHang();
        }

        public bool Them_LoaiHangHoa(string tenloai)
        {
            string maloai = "";
            int gtmoi = hanghoa_DAL.Count_LoaiHang() + 1;
            if (hanghoa_DAL.Count_LoaiHang() < 10)
                maloai = "MLH00" + gtmoi.ToString();
            else
                maloai = "MLH0" + gtmoi.ToString();
            LOAIHANG loai = new LOAIHANG();
            loai.MaLoai = maloai;
            loai.TenLoai = tenloai;
            if (hanghoa_DAL.Them_LoaiHang(loai))
                return true;
            else
                return false;
        }

        public object loadHHChoFrmNhap()
        {
            return hanghoa_DAL.loadHHChoFrmNhap();
        }

        public string layMaNV(string tennv)
        {
            return hanghoa_DAL.layMaNV(tennv);
        }

        public string layMaHH(string tenhh)
        {
            return hanghoa_DAL.layMaHH(tenhh);
        }


        public bool themCTPN(CT_PHIEUNHAP ctpn)
        {
            return hanghoa_DAL.themCTPhieuNhap(ctpn);
        }

        public bool themPN(PHIEUNHAP pn)
        {
            return hanghoa_DAL.themPhieuNhap(pn);
        }

        public bool capNhatPN(string mapn, float tonggt, float tongsl, float tienno)
        {
            return hanghoa_DAL.suaPhieuNhap(mapn, tonggt, tongsl, tienno);
        }


        public bool capNhatSLTonHH(string mahh, float soluongban)
        {
            return hanghoa_DAL.capNhatSLTonHH(mahh, soluongban);
        }

        public string layTenHang(string ma)
        {
            return hanghoa_DAL.layTenHH(ma);
        }

        public string layDonViTinh(string ma)
        {
            return hanghoa_DAL.layDVT(ma);
        }

    }
}
