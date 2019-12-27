using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{   
    public class Ban_BLL
    {
        Ban_DAL ban_dal = new Ban_DAL();

        public string layTrangThai(string maban)
        {
            return ban_dal.layTrangThai(maban);
        }

        public string layMauTrangThai(string maban)
        {
            return ban_dal.layMauTrangThai(maban);
        }

        public float layDonGia(string maban)
        {
            return float.Parse(ban_dal.layDonGia(maban));
        }

        public string layTenLoai(string maban)
        {
            return ban_dal.layTenLoai(maban);
        }

        public string layTenBan(string maban)
        {
            return ban_dal.layTenBan(maban);
        }

        public bool capNhatTrangThai(string maban, string tentrangthai)
        {
            return ban_dal.suaTinhTrang(maban, tentrangthai);
        }

        public List<BANBIDA> layDSBan()
        {
            return ban_dal.layDataBan();
        }

        public List<BANBIDA> layDSBanTru(string maban)
        {
            List<BANBIDA> dsban = new List<BANBIDA>();
            foreach (BANBIDA ban in ban_dal.layDataBan())
            {
                if (ban.MaBan != maban && ban.MaTrangThai == "MTT001") //chỉ lấy bàn trống khác bàn cũ
                    dsban.Add(ban);
            }
            return dsban;
        }

        public List<BANBIDA> layDSBanTheoLoai(string maloai)
        {
            return ban_dal.layBanTheoLoai(maloai);
        }

        public List<BANBIDA> layDSBanTheoTT(string tinhtrang)
        {
            return ban_dal.layBanTheoTinhTrang(tinhtrang);
        }

        public List<BANBIDA> layDSBanTheoKV(string khuvuc)
        {
            return ban_dal.layBanTheoKV(khuvuc);
        }
    }
}
