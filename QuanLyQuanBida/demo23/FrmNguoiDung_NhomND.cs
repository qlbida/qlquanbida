using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo23
{
    public partial class FrmNguoiDung_NhomND : Form
    {
        public FrmNguoiDung_NhomND()
        {
            InitializeComponent();
        }

        private void nguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FrmNguoiDung_NhomND_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.NguoiDung_NhomND' table. You can move, or remove it, as needed.
            this.nguoiDung_NhomNDTableAdapter.Fill(this.dataSet1.NguoiDung_NhomND);
            // TODO: This line of code loads data into the 'dataSet1.NhomNguoiDung' table. You can move, or remove it, as needed.
            this.nhomNguoiDungTableAdapter.Fill(this.dataSet1.NhomNguoiDung);
            
            // TODO: This line of code loads data into the 'dataSet1.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter.Fill(this.dataSet1.NguoiDung);

        }

        //load bảng người dùng - nhóm người dùng
        void loadNguoiDung_NhomND()
        {
            try
            {
                this.nguoiDung_NhomND_DKTableAdapter.Fill_Nhom_ND(this.dataSet1.NguoiDung_NhomND_DK, nhomNguoiDungComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void nhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNguoiDung_NhomND();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //string tenND = nguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();

            //string tenND = gridControlND
            //string nhomND = nhomNguoiDungComboBox.SelectedValue.ToString();

            //nguoiDung_NhomNDTableAdapter.Insert(nhomND, tenND, string.Empty);

            //MessageBox.Show("Thêm người dùng "+tenND+" vào nhóm thành công !!");

            loadNguoiDung_NhomND();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //string tenND = nguoiDung_NhomND_DKDataGridView.CurrentRow.Cells[1].Value.ToString();
            //string nhomND = nguoiDung_NhomND_DKDataGridView.CurrentRow.Cells[0].Value.ToString();

            //nguoiDung_NhomNDTableAdapter.Delete(nhomND, tenND, string.Empty);

            //MessageBox.Show("Xóa người dùng " + tenND + " trong nhóm thành công !!");

            loadNguoiDung_NhomND();
        }
    }
}
