using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CongNo_DAL
    {
        QuanLyBidaDataContext qlcn = new QuanLyBidaDataContext();

        public Object loadCongNoCuaKhach()
        {
            var congnokh = from hd in qlcn.HOADONs
                           from kh in qlcn.KHACHHANGs
                           where hd.MaKH == kh.MaKH && hd.TienNo > 0
                           group hd by new { hd.MaKH, kh.HoTenKH } into kq
                           select new { MaKH = kq.Key.MaKH,HoTenKH = kq.Key.HoTenKH ,TienNo = kq.Sum(t => t.TienNo) };
            return congnokh;
        }


        public Object loadCongNoNCC()
        {
            return from pn in qlcn.PHIEUNHAPs
                   from ncc in qlcn.NHACUNGCAPs
                   where pn.MaNCC == ncc.MaNCC && pn.TienNo > 0
                   group pn by new {pn.MaNCC, ncc.TenNCC} into kq
                   select new { MaNCC = kq.Key.MaNCC, TenNCC = kq.Key.TenNCC, TienNo = kq.Sum(t => t.TienNo) };
        }

        public Object loadCTCongNoCuaKhach(string makh)
        {
            return from hd in qlcn.HOADONs
                   where hd.MaKH == makh && hd.TienNo > 0
                   select new {hd.MaHD, hd.NgayLap, hd.TienNo};
        }

        public Object loadCTCongNoNCC(string mancc)
        {
            return from pn in qlcn.PHIEUNHAPs
                   where pn.MaNCC == mancc && pn.TienNo > 0
                   select new { pn.MaPN,pn.NgayNhap, pn.TienNo};
        }

        public bool thanhToanCongNoKhachHang(string mahd)
        {
            try
            {
                HOADON hd = qlcn.HOADONs.Where(t => t.MaHD == mahd).FirstOrDefault();
                hd.TienNo = 0;
                qlcn.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool thanhToanCongNoNCC(string mapn)
        {
            try
            {
                PHIEUNHAP pn = qlcn.PHIEUNHAPs.Where(t => t.MaPN == mapn).FirstOrDefault();
                pn.TienNo = 0;
                qlcn.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
