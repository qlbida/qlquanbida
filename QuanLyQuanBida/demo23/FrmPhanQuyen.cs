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
    public partial class FrmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public FrmPhanQuyen()
        {
            InitializeComponent();
        }

        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBida.CT_NHOMNGUOIDUNG_MANHINH' table. You can move, or remove it, as needed.
            this.cT_NHOMNGUOIDUNG_MANHINHTableAdapter.Fill(this.dataSetBida.CT_NHOMNGUOIDUNG_MANHINH);
            // TODO: This line of code loads data into the 'dataSetBida.CT_NHOMNGUOIDUNG_MANHINH' table. You can move, or remove it, as needed.
            this.cT_NHOMNGUOIDUNG_MANHINHTableAdapter.Fill(this.dataSetBida.CT_NHOMNGUOIDUNG_MANHINH);
            // TODO: This line of code loads data into the 'dataSetBida.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.dataSetBida.NHOMNGUOIDUNG);
        }

        void loadManHinh(string s)
        {
            try
            {
                this.pHANQUYENTableAdapter.Fill_PQ(this.dataSetBida.PHANQUYEN, s);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void gridViewNhom_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var rowHandle = gridViewNhom.FocusedRowHandle;
            string manhom = gridViewNhom.GetRowCellValue(rowHandle, "MaNhom").ToString();

            loadManHinh(manhom);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var rowHandle = gridViewNhom.FocusedRowHandle;
            string manhom = gridViewNhom.GetRowCellValue(rowHandle, "MaNhom").ToString();

            for (int i = 0; i < gridViewNhom.RowCount; i++)
            {
                bool? quyen = (bool?)gridViewPQ.GetRowCellValue(i, "CoQuyen");
                string tenmh = gridViewPQ.GetRowCellValue(i, "TenManHinh").ToString();
                string mamh = gridViewPQ.GetRowCellValue(i, "MaManHinh").ToString();

                if (quyen.ToString() == "True")
                {
                    if (kiemTraTonTai(manhom, mamh) == false) //khóa chính
                    {
                        cT_NHOMNGUOIDUNG_MANHINHTableAdapter.Insert(manhom, gridViewPQ.GetRowCellValue(i, "MaManHinh").ToString(), quyen);
                        MessageBox.Show("Gán quyền cho " + manhom + " thành công !!");
                    }
                    else
                    {
                        MessageBox.Show("Nhóm có mã " + manhom + " đã có quyền với màn hình " + tenmh);
                    }
                }
                else if (quyen.ToString() == "False")
                {
                    if (kiemTraTonTai(manhom, mamh) == false) //khóa chính
                    {
                        cT_NHOMNGUOIDUNG_MANHINHTableAdapter.Insert(manhom, gridViewPQ.GetRowCellValue(i, "MaManHinh").ToString(), quyen);
                        MessageBox.Show("Bỏ quyền cho " + manhom + " thành công !!");
                    }
                    else
                    {
                        MessageBox.Show("Nhóm có mã " + manhom + " đã bị xóa quyền với màn hình " + tenmh);
                    }
                }
            }
        }

        bool kiemTraTonTai(string s1, string s2)
        {
            DataTable dt = cT_NHOMNGUOIDUNG_MANHINHTableAdapter.GetData();
            foreach (DataRow drct in dt.Rows)
            {
                if (drct["MaNhom"].ToString() == s1 && drct["MaManHinh"].ToString() == s2)
                    return true; 
            }
            return false;
        }
    }
}