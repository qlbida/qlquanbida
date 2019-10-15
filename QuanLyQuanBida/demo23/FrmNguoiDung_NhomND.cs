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
    public partial class FrmNguoiDung_NhomND : DevExpress.XtraEditors.XtraForm
    {
        public FrmNguoiDung_NhomND()
        {
            InitializeComponent();
        }

        private void nHOMNGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHOMNGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBida);

        }

        private void FrmNguoiDung_NhomND_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBida.CT_NHOMNGUOIDUNG_NGUOIDUNG' table. You can move, or remove it, as needed.
            this.cT_NHOMNGUOIDUNG_NGUOIDUNGTableAdapter.Fill(this.dataSetBida.CT_NHOMNGUOIDUNG_NGUOIDUNG);
            // TODO: This line of code loads data into the 'dataSetBida.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.dataSetBida.NGUOIDUNG);
            // TODO: This line of code loads data into the 'dataSetBida.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.dataSetBida.NHOMNGUOIDUNG);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var rowHandle = gridViewND.FocusedRowHandle;
            string tennd = gridViewND.GetRowCellValue(rowHandle, "TenDangNhap").ToString();
            string nhomnd = nHOMNGUOIDUNGComboBox.SelectedValue.ToString();
            cT_NHOMNGUOIDUNG_NGUOIDUNGTableAdapter.Insert(tennd, nhomnd, string.Empty);
            MessageBox.Show("Thêm thành công !!");
            loadComboNhomND();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var rowHandle = gridViewND_Nhom.FocusedRowHandle; //lấy dòng hiện tại
            string tennd = gridViewND_Nhom.GetRowCellValue(rowHandle, "TenDangNhap").ToString();
            string nhomnd = nHOMNGUOIDUNGComboBox.SelectedValue.ToString();
            cT_NHOMNGUOIDUNG_NGUOIDUNGTableAdapter.Delete(tennd, nhomnd, string.Empty);
            MessageBox.Show("Xóa thành công !!");
            loadComboNhomND();
        }

        private void nHOMNGUOIDUNGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadComboNhomND();
        }

        void loadComboNhomND()
        {
            try
            {
                this.cT_NHOMNGUOIDUNG_NGUOIDUNG_DKTableAdapter.Fill_ND_Nhom(this.dataSetBida.CT_NHOMNGUOIDUNG_NGUOIDUNG_DK, nHOMNGUOIDUNGComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}