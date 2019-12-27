using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Ban_DAL
    {
        QuanLyBidaDataContext qlbida = new QuanLyBidaDataContext();
        
        public string layTrangThai(string maban)
        {
            return (from ban in qlbida.BANBIDAs
                    from trangthai in qlbida.TRANGTHAIBANs
                    where ban.MaTrangThai == trangthai.MaTrangThai && ban.MaBan == maban
                    select trangthai.TenTrangThai).Single();
        }

        public string layMauTrangThai(string maban)
        {
            return (from ban in qlbida.BANBIDAs
                    from trangthai in qlbida.TRANGTHAIBANs
                    where ban.MaTrangThai == trangthai.MaTrangThai && ban.MaBan == maban
                    select trangthai.Mau).Single();
        }

        public string layTenLoai(string maban)
        {
            return (from ban in qlbida.BANBIDAs
                    from loai in qlbida.LOAIBANBIDAs
                    where ban.MaLoaiBan == loai.MaLoaiBan && ban.MaBan == maban
                    select loai.TenLoaiBan).Single();
        }

        public string layMaTrangThai(string tentrangthai)
        {
            return (from tinhtrang in qlbida.TRANGTHAIBANs
                    where tinhtrang.TenTrangThai == tentrangthai
                    select tinhtrang.MaTrangThai).Single();
        }

        public string layDonGia(string maban)
        {
            return (from ban in qlbida.BANBIDAs
                    from loai in qlbida.LOAIBANBIDAs
                    where ban.MaLoaiBan == loai.MaLoaiBan && ban.MaBan == maban
                    select loai.DonGia).Single().ToString();
        }

        public string layTenBan(string maban)
        {
            return (from ban in qlbida.BANBIDAs
                    where ban.MaBan == maban
                    select ban.TenBan).Single();
        }

        public bool suaTinhTrang(string maban, string tentinhtrang)
        {
            try
            {
                BANBIDA ban = qlbida.BANBIDAs.Where(t => t.MaBan == maban).FirstOrDefault();
                ban.MaTrangThai = layMaTrangThai(tentinhtrang);
                qlbida.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //lấy data bàn
        public List<BANBIDA> layDataBan()
        {
            return qlbida.BANBIDAs.Select(t => t).ToList<BANBIDA>();
        }

        public List<BANBIDA> layBanTheoLoai(string maloai)
        {
            return qlbida.BANBIDAs.Where(t => t.MaLoaiBan == maloai).ToList<BANBIDA>();
        }

        public List<BANBIDA> layBanTheoKV(string makhuvuc)
        {
            return qlbida.BANBIDAs.Where(t => t.ViTri == makhuvuc).ToList<BANBIDA>();
        }

        public List<BANBIDA> layBanTheoTinhTrang(string matinhtrang)
        {
            return qlbida.BANBIDAs.Where(t => t.MaTrangThai == matinhtrang).ToList<BANBIDA>();
        }
    }
}
