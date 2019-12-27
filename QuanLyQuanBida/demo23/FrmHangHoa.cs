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

namespace demo23
{
    public partial class FrmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public FrmHangHoa()
        {
            InitializeComponent();
        }

        HangHoa_BLL hanghoa_BLL = new HangHoa_BLL();

        private void FrmHangHoa_Load(object sender, EventArgs e)
        {
            hANGHOAComboBox.DataSource = hanghoa_BLL.load_CBB_DonViTinh();
            lOAIBANBIDAComboBox.DataSource = hanghoa_BLL.Load_CBB_LoaiHang();
            lOAIHANGDataGridView.DataSource = hanghoa_BLL.Load_DGV_LoaiHang();
            //tenLoaiTextEdit.Text = lOAIHANGDataGridView.CurrentRow.Cells[1].Value.ToString();
            // TODO: This line of code loads data into the 'dataSetBida.LoadHH' table. You can move, or remove it, as needed.
            this.loadHHTableAdapter.Fill_loadHH(this.dataSetBida.LoadHH);
            
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            BinDing();
            
        }            

        private void hANGHOADataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BinDing();  
        }

        private void BinDing()
        {
            lOAIBANBIDAComboBox.Text = hANGHOADataGridView.CurrentRow.Cells[5].Value.ToString();
            hANGHOAComboBox.Text = hANGHOADataGridView.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            maHangTextEdit.Text = "";
            tenHangTextEdit.Text = "";
            donGiaTextEdit.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            btnSuaLoai.Enabled = false;
            tenLoaiTextEdit.Enabled = true;
            tenHangTextEdit.Text = "";            
        }

        private void lOAIHANGDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tenLoaiTextEdit.Text = lOAIHANGDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            btnThemLoai.Enabled = false;
            tenLoaiTextEdit.Enabled = true;
        }

        private void btnLuuLoai_Click(object sender, EventArgs e)
        {
            if (btnThemLoai.Enabled == true)
            {
                MessageBox.Show(tenHangTextEdit.Text);
                if (hanghoa_BLL.Them_LoaiHangHoa(tenHangTextEdit.Text))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("thất bại");
                lOAIHANGDataGridView.DataSource = hanghoa_BLL.Load_DGV_LoaiHang();
            }
            else
            { }
        }
    }
}