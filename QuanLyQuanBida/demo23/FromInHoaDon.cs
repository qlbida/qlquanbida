using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace demo23
{
    public partial class FromInHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public FromInHoaDon()
        {
            InitializeComponent();
        }

        public void inHoaDon(HoaDonRP hd, List<CTHoaDonReport> cthd)
        {
            ReportHoaDon rp = new ReportHoaDon();
            foreach(DevExpress.XtraReports.Parameters.Parameter p in rp.Parameters)
                p.Visible = false;

            rp.initData(hd.MaBan, hd.TienBan, hd.TienChuyenBan, hd.TongTien, hd.TienThanhToan, hd.ConNo,hd.GioVao.ToString(), hd.GioRa.ToString(), hd.MaHD, hd.MaNV, hd.NgayLap.ToString(), cthd);
            documentViewer1.DocumentSource = rp;
            rp.CreateDocument();
        }
    }
}