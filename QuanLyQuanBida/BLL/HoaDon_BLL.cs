using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class HoaDon_BLL
    {
        HoaDon_DAL hoadon_DAL = new HoaDon_DAL();

        public string layMaNV(string tennv)
        {
            return hoadon_DAL.layMaNV(tennv);
        }

        public string layMaHH(string tenhh)
        {
            return hoadon_DAL.layMaHH(tenhh);
        }

        public bool themHoaDon(HOADON hd)
        {
            return hoadon_DAL.themHoaDon(hd);
        }

        public bool capNhapHDKhachMuaLe(string mahd, float tonggt, float tienno)
        {
            return hoadon_DAL.suaHoaDonKhachMuaLe(mahd, tonggt, tienno);
        }

        public bool themCTHD(CT_HOADON cthd)
        {
            return hoadon_DAL.themCTHD(cthd);
        }

        public bool capnhatHDBan(string mahd, float chuyenban, float tiendichvu, float thue, float tonggiatri, float thanhtien, float tienno)
        {
            return hoadon_DAL.suaHoaDonBan(mahd, chuyenban, tiendichvu, thue, tonggiatri, thanhtien, tienno);
        }
        //==========Phần doanh thu=======
        public Object loadHoaDon()
        {
            return hoadon_DAL.loadHoaDon();
        }

        public Object loadCTHDTheoMaHD(string mahd)
        {
            return hoadon_DAL.loadCTHDTheoMaHD(mahd);
        }

        public Object loadHoaDonTheoNgay(DateTime tungay, DateTime denngay)
        {
            return hoadon_DAL.loadHoaDonTheoNgay(tungay, denngay);
        }
    }
}
