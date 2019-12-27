using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TamTinh_BLL
    {
        TamTinh_DAL tamtinh_dal = new TamTinh_DAL();
        
        public bool themTamTinh(TAMTINH tt)
        {
            return tamtinh_dal.themTamTinh(tt);
        }

        public bool capNhapTamTinh(string matt, float tienban)
        {
            return tamtinh_dal.suaTamTinh(matt, tienban);
        }

        public bool themCTTT(CT_TAMTINH cttt)
        {
            return tamtinh_dal.themCTTT(cttt);
        }

        public List<CT_TAMTINH> layCTTT(string matamtinh)
        {
            return tamtinh_dal.getDataCTT(matamtinh);
        }

        public bool xoaChiTietTT(string matamtinh, string mahang)
        {
            return tamtinh_dal.xoaCTTT(matamtinh, mahang);
        }

        public bool xoaTamTinh(string matamtinh)
        {
            return tamtinh_dal.xoaTamTinh(matamtinh);
        }

        public string layMaTamTinh(string maban)
        {
            return tamtinh_dal.layMaTamTinh(maban);
        }

        public TAMTINH layTamTinh(string matamtinh)
        {
            return tamtinh_dal.getDataTamTinh(matamtinh);
        }

        public bool suaTamTinh(string matt, string maban, float chuyenban)
        {
            return tamtinh_dal.suaTamTinh(matt, maban, chuyenban);
        }

        public bool suaTamTinh(string matt, float tienban)
        {
            return tamtinh_dal.suaTamTinh(matt, tienban);
        }
    }
}
