using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class CongNo_BLL
    {
        CongNo_DAL congno_dal = new CongNo_DAL();
        public Object loadCongNoCuaKhach()
        {
            return congno_dal.loadCongNoCuaKhach();
        }

        public Object loadCongNoNCC()
        {
            return congno_dal.loadCongNoNCC();
        }

        public Object loadCTCongNoCuaKhach(string makh)
        {
            return congno_dal.loadCTCongNoCuaKhach(makh);
        }

        public Object loadCTCongNoNCC(string mancc)
        {
            return congno_dal.loadCTCongNoNCC(mancc);
        }

        public bool thanhToanCongNoKhachHang(string mahd)
        {
            return congno_dal.thanhToanCongNoKhachHang(mahd);
        }

        public bool thanhToanCongNoNCC(string mapn)
        {
            return congno_dal.thanhToanCongNoNCC(mapn);
        }
    }
}
