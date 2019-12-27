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
using DevExpress.LookAndFeel; //skin màu cho form

namespace demo23
{
    public partial class FrmLienHe : DevExpress.XtraEditors.XtraForm
    {
        public FrmLienHe()
        {
            InitializeComponent();
        }

        private void FrmLienHe_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            labelMail.Text += " khoihuy123@gmail.com";
            labelSDT.Text += " 0987 454 292";
            labelWeb.Text += " hotroabc.vn";
            labelDiaChi.Text = "CÔNG TY TNHH CÔNG NGHỆ ABC \n 140 Lê Trọng Tấn, Quận Tân Phú, TP Hồ Chí Minh";
        }
    }
}