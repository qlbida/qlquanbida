using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel; //skin màu cho form
using DevExpress.XtraEditors;
using DAL;
using BLL;
namespace demo23
{
    public partial class FrmCongNo : DevExpress.XtraEditors.XtraForm
    {
        CongNo_BLL congno_bll = new CongNo_BLL();

        public FrmCongNo()
        {
            InitializeComponent();
        }

        private void FrmCongNo_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            dataGridViewCongNoKH.DataSource = congno_bll.loadCongNoCuaKhach();

        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage.Name == "khachhang")
            {
                dataGridViewCongNoKH.DataSource = congno_bll.loadCongNoCuaKhach();
            }
            else
            {
                dataGridViewCongNoNCC.DataSource = congno_bll.loadCongNoNCC();
            }
        }

        private void dataGridViewCongNoKH_SelectionChanged(object sender, EventArgs e)
        {
            string makh = dataGridViewCongNoKH.CurrentRow.Cells["MaKH"].Value.ToString();
            dataGridViewCTCongNo.DataSource = congno_bll.loadCTCongNoCuaKhach(makh);
        }

        private void dataGridViewCongNoNCC_SelectionChanged(object sender, EventArgs e)
        {
            string mancc = dataGridViewCongNoNCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            dataGridViewCTCongNo.DataSource = congno_bll.loadCTCongNoNCC(mancc);
        }

        private void dataGridViewCTCongNo_SelectionChanged(object sender, EventArgs e)
        {
            string tienconno = dataGridViewCTCongNo.CurrentRow.Cells[2].Value.ToString();
            txtTienNo.Text = tienconno;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thanh toán công nợ ??", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (xtraTabControl1.SelectedTabPage.Name == "khachhang")
                {
                    string mahd = dataGridViewCTCongNo.CurrentRow.Cells[0].Value.ToString();
                    if (congno_bll.thanhToanCongNoKhachHang(mahd))
                    {
                        MessageBox.Show("Thanh toán công nợ thành công !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string makh = dataGridViewCongNoKH.CurrentRow.Cells["MaKH"].Value.ToString();
                        dataGridViewCTCongNo.DataSource = congno_bll.loadCTCongNoCuaKhach(makh);
                    }
                    else
                        MessageBox.Show("Thanh toán công nợ thất bại !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    string mapn = dataGridViewCTCongNo.CurrentRow.Cells[0].Value.ToString();
                    if (congno_bll.thanhToanCongNoNCC(mapn))
                    {
                        MessageBox.Show("Thanh toán công nợ thành công !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string mancc = dataGridViewCongNoNCC.CurrentRow.Cells["MaNCC"].Value.ToString();
                        dataGridViewCTCongNo.DataSource = congno_bll.loadCTCongNoNCC(mancc);
                    }
                    else
                        MessageBox.Show("Thanh toán công nợ thất bại !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}