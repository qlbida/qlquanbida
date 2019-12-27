using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HangHoa_DAL
    {
        QuanLyBidaDataContext qlhh = new QuanLyBidaDataContext();

        public List<string> LoadDonViTinh()
        {
            return qlhh.HANGHOAs.Select(h => h.DonViTinh).Distinct().ToList<string>();
        }

        public List<string> XuatLoaiHang()
        {
            return qlhh.LOAIHANGs.Select(h=>h.TenLoai).Distinct().ToList<string>();
        }

        public List<LOAIHANG> Xuat_Bang_LoaiHang()
        {
            return qlhh.LOAIHANGs.Select(h=>h).ToList<LOAIHANG>();
        }

        public bool Them_LoaiHang(LOAIHANG lh)
        {
            try
            {
                qlhh.LOAIHANGs.InsertOnSubmit(lh);
                qlhh.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int Count_LoaiHang()
        {
            return (qlhh.LOAIHANGs.Select(h => h)).Count();
        }


        public Object loadHHChoFrmNhap()
        {
            return from hh in qlhh.HANGHOAs
                   from tl in qlhh.LOAIHANGs
                   where hh.MaLoai == tl.MaLoai
                   select new { hh.TenHang, hh.DonViTinh, tl.TenLoai};
        }

        public bool themPhieuNhap(PHIEUNHAP pn)
        {
            try
            {
                qlhh.PHIEUNHAPs.InsertOnSubmit(pn);
                qlhh.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaPhieuNhap(string mapn, float tonggt, float tongsl, float tienno)
        {
            try
            {
                PHIEUNHAP pn = qlhh.PHIEUNHAPs.Where(t => t.MaPN == mapn).FirstOrDefault();
                pn.TongGiaTriNhap = tonggt;
                pn.TongSoLuongNhap = tongsl;
                pn.TienNo = tienno;
                qlhh.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool themCTPhieuNhap(CT_PHIEUNHAP ctpn)
        {
            try
            {
                qlhh.CT_PHIEUNHAPs.InsertOnSubmit(ctpn);
                qlhh.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string layMaNV(string tendn)
        {
            return (from nv in qlhh.NGUOIDUNGs
                   where nv.TenDangNhap == tendn
                   select nv.MaNV).Single();
        }

        public string layMaHH(string ten)
        {
            return (from hh in qlhh.HANGHOAs
                   where hh.TenHang == ten
                   select hh.MaHang).Single();
        }

        public string layTenHH(string ma)
        {
            return (from hh in qlhh.HANGHOAs
                    where hh.MaHang == ma
                    select hh.TenHang).Single();
        }

        public string layDVT(string ma)
        {
            return (from hh in qlhh.HANGHOAs
                    where hh.MaHang == ma
                    select hh.DonViTinh).Single();
        }

        public bool capNhatSLTonHH(string mahh, float soluongban)
        {
            try
            {
                HANGHOA hh = qlhh.HANGHOAs.Where(t => t.MaHang == mahh).FirstOrDefault();
                hh.SoLuongTon = hh.SoLuongTon-soluongban;
                qlhh.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
