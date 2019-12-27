using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class HoaDon_DAL
    {
        QuanLyBidaDataContext qlhd = new QuanLyBidaDataContext();

        public string layMaNV(string tendn)
        {
            return (from nv in qlhd.NGUOIDUNGs
                    where nv.TenDangNhap == tendn
                    select nv.MaNV).Single();
        }

        public string layMaHH(string ten)
        {
            return (from hh in qlhd.HANGHOAs
                    where hh.TenHang == ten
                    select hh.MaHang).Single();
        }

        public bool themHoaDon(HOADON hd)
        {
            try
            {
                qlhd.HOADONs.InsertOnSubmit(hd);
                qlhd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaHoaDonKhachMuaLe(string mahd, float tonggt, float tienno)
        {
            try
            {
                HOADON hd = qlhd.HOADONs.Where(t => t.MaHD == mahd).FirstOrDefault();
                hd.TongGiaTri = tonggt;
                hd.TienNo = tienno;
                qlhd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaHoaDonBan(string mahd, float chuyenban, float tongdichvu, float thuevat, float tonggt, float thanhtien, float tienno)
        {
            try
            {
                HOADON hd = qlhd.HOADONs.Where(t => t.MaHD == mahd).FirstOrDefault();
                hd.TienChuyenBan = chuyenban;
                hd.TongTienDichVu = tongdichvu;
                hd.ThueVAT = thuevat;
                hd.TongGiaTri = tonggt;
                hd.ThanhTien = thanhtien;
                hd.TienNo = tienno;
                qlhd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool themCTHD(CT_HOADON cthd)
        {
            try
            {
                qlhd.CT_HOADONs.InsertOnSubmit(cthd);
                qlhd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //============================Phần doanh thu===============
        public Object loadHoaDon()
        {
            return from hd in qlhd.HOADONs
                   from kh in qlhd.KHACHHANGs
                   from nv in qlhd.NHANVIENs
                   where hd.MaNV == nv.MaNV && hd.MaKH == kh.MaKH
                   select new { hd.MaHD, hd.ThanhTien, hd.NgayLap, kh.HoTenKH, nv.HoTenNV};
        }

        public Object loadCTHDTheoMaHD(string mahd)
        {
            return from cthd in qlhd.CT_HOADONs
                   from hh in qlhd.HANGHOAs
                   where cthd.MaHang == hh.MaHang && cthd.MaHD == mahd
                   select new { hh.TenHang, cthd.SoLuongBan, cthd.DonGiaBan, cthd.ThanhTien };
        }

        public Object loadHoaDonTheoNgay(DateTime tungay, DateTime denngay)
        {
            return from hd in qlhd.HOADONs
                   from kh in qlhd.KHACHHANGs
                   from nv in qlhd.NHANVIENs
                   where hd.MaNV == nv.MaNV && hd.MaKH == kh.MaKH && hd.NgayLap <= denngay && hd.NgayLap >= tungay
                   select new { hd.MaHD, hd.ThanhTien, hd.NgayLap, kh.HoTenKH, nv.HoTenNV };
        }
    }
}
