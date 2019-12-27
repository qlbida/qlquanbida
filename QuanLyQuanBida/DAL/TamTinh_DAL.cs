using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TamTinh_DAL
    {
        QuanLyBidaDataContext tamtinh = new QuanLyBidaDataContext();

        public bool themTamTinh(TAMTINH ttinh)
        {
            try
            {
                tamtinh.TAMTINHs.InsertOnSubmit(ttinh);
                tamtinh.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaTamTinh(string matamtinh, float tienban)
        {
            try
            {
                TAMTINH tt = tamtinh.TAMTINHs.Where(t => t.MaTamTinh == matamtinh).FirstOrDefault();
                tt.TienBan = tienban;
                tamtinh.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaTamTinh(string matamtinh, string mabanmoi, float tienchuyenban)
        {
            try
            {
                TAMTINH tt = tamtinh.TAMTINHs.Where(t => t.MaTamTinh == matamtinh).FirstOrDefault();
                tt.MaBan = mabanmoi;
                tt.TienChuyenBan += tienchuyenban;
                tamtinh.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool themCTTT(CT_TAMTINH cttt)
        {
            try
            {
                tamtinh.CT_TAMTINHs.InsertOnSubmit(cttt);
                tamtinh.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<CT_TAMTINH> getDataCTT(string matamtinh)
        {
            return tamtinh.CT_TAMTINHs.Where(t => t.MaTamTinh == matamtinh).ToList<CT_TAMTINH>();
        }

        public TAMTINH getDataTamTinh(string matamtinh)
        {
            return tamtinh.TAMTINHs.Where(t => t.MaTamTinh == matamtinh).Single();
        }

        public string layMaTamTinh(string maban) 
        {
            return (from tt in tamtinh.TAMTINHs
                    where tt.MaBan == maban
                    select tt.MaTamTinh).Single();
        }

        public bool xoaCTTT(string matt, string mahang) 
        {
            try
            {
                CT_TAMTINH cttt = tamtinh.CT_TAMTINHs.Where(t => t.MaTamTinh == matt && t.MaHang == mahang).FirstOrDefault();
                tamtinh.CT_TAMTINHs.DeleteOnSubmit(cttt);
                tamtinh.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaTamTinh(string ma)
        {
            try
            {
                TAMTINH tt = tamtinh.TAMTINHs.Where(t => t.MaTamTinh == ma).FirstOrDefault();
                tamtinh.TAMTINHs.DeleteOnSubmit(tt);
                tamtinh.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Cần thêm chuyển bàn

    }
}
