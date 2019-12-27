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
using BLL;
using DAL;
using XuLy;

namespace demo23
{
    public partial class FrmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        HangHoa_BLL hanghoa_bll = new HangHoa_BLL();
        float _thanhtien = 0;
        public string tendn;

        public FrmNhapHang()
        {
            InitializeComponent();
        }

        private void nHACUNGCAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHACUNGCAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBida);

        }

        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            // TODO: This line of code loads data into the 'dataSetBida.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.dataSetBida.NHACUNGCAP);
            dateTimeNgayNhap.Format = DateTimePickerFormat.Short;
            dataGridViewNhapHang.DataSource = hanghoa_bll.loadHHChoFrmNhap();
            int _sodong = dataGridViewNhapHang.Rows.Count;
            for (int i = 0; i < _sodong; i++)
            {
                dataGridViewNhapHang.Rows[i].Cells["soluongnhap"].Value = 0;
                dataGridViewNhapHang.Rows[i].Cells["dongianhap"].Value = 0;
                dataGridViewNhapHang.Rows[i].Cells["tongtien"].Value = 0;
            }
        }

        private void txtThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTongTien.Text == txtThanhToan.Text)
                txtConNo.Text = "0";
            else if (txtThanhToan.Text == "")
                txtConNo.Text = txtTongTien.Text;
            else
                txtConNo.Text = (_thanhtien - int.Parse(txtThanhToan.Text)).ToString();          
        }


        private void dataGridViewNhapHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        { 
            try{
             if (int.Parse(dataGridViewNhapHang.CurrentRow.Cells["soluongnhap"].Value.ToString()) != 0 && int.Parse(dataGridViewNhapHang.CurrentRow.Cells["dongianhap"].Value.ToString()) != 0)
                {
                    if (_thanhtien != 0)
                    {
                        _thanhtien = 0;
                    }
                    int _tongtien = int.Parse(dataGridViewNhapHang.CurrentRow.Cells["soluongnhap"].Value.ToString())
                             * int.Parse(dataGridViewNhapHang.CurrentRow.Cells["dongianhap"].Value.ToString());
                    dataGridViewNhapHang.CurrentRow.Cells["tongtien"].Value = _tongtien;
                    for (int i = 0; i < dataGridViewNhapHang.Rows.Count; i++)
                    {
                         _thanhtien = _thanhtien + float.Parse(dataGridViewNhapHang.Rows[i].Cells["tongtien"].Value.ToString());
                    }
                  
                    txtTongTien.Text = _thanhtien.ToString();
                    txtThanhToan.Text = _thanhtien.ToString();
                    if (txtTongTien.Text == txtThanhToan.Text)
                        txtConNo.Text = "0";
                    else
                        txtConNo.Text = (_thanhtien - int.Parse(txtThanhToan.Text)).ToString();
                }
            }
            catch { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float soluonghang = 0;
            int dem = 0;
            string mapn = "";
            for (int i = 0; i < dataGridViewNhapHang.Rows.Count; i++)
            {
                int thanhtien = int.Parse(dataGridViewNhapHang.Rows[i].Cells["tongtien"].Value.ToString());
                if (thanhtien > 0) //có nhập hàng
                {
                    dem += 1;
                    if (dem == 1)
                    {
                        //thêm phiếu nhập 1 lần
                        PHIEUNHAP pn = new PHIEUNHAP();
                        mapn = "PN" + XuLy.TaoMaRandom.taoMaRandom();
                        MessageBox.Show(mapn);
                        pn.MaPN = mapn;
                        pn.MaNCC = nHACUNGCAPComboBox.SelectedValue.ToString();
                        pn.MaNV = hanghoa_bll.layMaNV(tendn);
                        pn.NgayNhap = DateTime.Now;
                        hanghoa_bll.themPN(pn);
                    }

                    //thêm chi tiết nhiều lần
                    float sltemp = float.Parse(dataGridViewNhapHang.Rows[i].Cells["soluongnhap"].Value.ToString());
                    float dgtemp = float.Parse(dataGridViewNhapHang.Rows[i].Cells["dongianhap"].Value.ToString());
                    string tenhang = dataGridViewNhapHang.Rows[i].Cells["tenhanghoa"].Value.ToString();
                    soluonghang += sltemp;

                    CT_PHIEUNHAP ctpn = new CT_PHIEUNHAP();
                    ctpn.MaPN = mapn;
                    ctpn.MaHang = hanghoa_bll.layMaHH(tenhang);
                    //MessageBox.Show(hanghoa_bll.layMaHH(tenhang));
                    ctpn.SoLuongNhap = sltemp;
                    ctpn.DonGiaNhap = dgtemp;
                    ctpn.ThanhTien = thanhtien;
                    if (hanghoa_bll.themCTPN(ctpn))
                        MessageBox.Show("Thêm 1 chi tiết nhập thành công !!");
                    else
                        MessageBox.Show("Thêm 1 chi tiết nhập thất bại !!");
                }
            }

            if (dem > 0) //chắc chắn đã tạo phiếu nhập 
            {
                //cập nhập tổng gt pn và tổng số lượng hàng nhập
                if (hanghoa_bll.capNhatPN(mapn, float.Parse(txtTongTien.Text), soluonghang, float.Parse(txtConNo.Text)))
                    MessageBox.Show("Nhập hàng thành công !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Nhập hàng thất bại !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát !!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

    }
}