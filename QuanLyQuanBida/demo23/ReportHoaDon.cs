using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic; //dùng cho list

namespace demo23
{
    public partial class ReportHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHoaDon()
        {
            InitializeComponent();
        }

        public void initData(string tenban, float tienban, float tienchuyen, float tiencanthanhtoan, float tienthanhtoan, float tienno, string giovao, string giora, string mahd, string manv, string ngaylap, List<CTHoaDonReport> cthd)
        {
            pTenBan.Value = tenban;
            pTienBan.Value = tienban;
            pNhanBan.Value = giovao;
            pTraBan.Value = giora;
            pMaHD.Value = mahd;
            pMaNV.Value = manv;
            pNgayLap.Value = ngaylap;
            pTienChuyen.Value = tienchuyen;
            pTienCanThanhToan.Value = tiencanthanhtoan;
            pTienThanhToan.Value = tienthanhtoan;
            pTienNo.Value = tienno;
            objectDataSource1.DataSource = cthd;
        }
    }
}
