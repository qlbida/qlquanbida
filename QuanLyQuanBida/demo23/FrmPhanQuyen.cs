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
    public partial class FrmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public DataGridView dongchon;

        public FrmPhanQuyen()
        {
            InitializeComponent();
        }

        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
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
            btnLuu.Enabled = false;
        }

        //Mỗi lần lưu được 1 quyền
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var rowHandle = gridViewNhom.FocusedRowHandle;
            string manhom = gridViewNhom.GetRowCellValue(rowHandle, "MaNhom").ToString();

            var rowHandle1 = gridViewPQ.FocusedRowHandle;
            string mamh = gridViewPQ.GetRowCellValue(rowHandle1, "MaManHinh").ToString();
            string tenmh = gridViewPQ.GetRowCellValue(rowHandle1, "TenManHinh").ToString();
            bool? quyen = (bool?)gridViewPQ.GetRowCellValue(rowHandle1, "CoQuyen");

            if (kiemTraTonTai(manhom, mamh) == true)
            {
                if (layQuyen(manhom, mamh) == quyen.ToString())
                    MessageBox.Show("Nhóm " + manhom + " đã được phân quyền này rồi !!");
                else
                {
                    DataRow change = suaQuyen(manhom, mamh, quyen);
                    cT_NHOMNGUOIDUNG_MANHINHTableAdapter.Update(change);
                    MessageBox.Show("Đã cập nhật lại quyền cho nhóm này !!");
                }

            }
            else
            {
                cT_NHOMNGUOIDUNG_MANHINHTableAdapter.Insert(manhom, mamh, quyen);
                MessageBox.Show("Gán quyền cho " + manhom + " thành công !!");
            }
            btnLuu.Enabled = false;
        }

        string layQuyen(string s1, string s2)
        {
            string quyen = "";
            DataTable dt = cT_NHOMNGUOIDUNG_MANHINHTableAdapter.GetData();
            foreach (DataRow drct in dt.Rows)
            {
                if (drct["MaNhom"].ToString() == s1 && drct["MaManHinh"].ToString() == s2)
                    quyen = drct["CoQuyen"].ToString();
            }
            return quyen;
        }

        DataRow suaQuyen(string s1, string s2, bool? s3)
        {
            DataRow rowchange = null;
            DataTable dt = cT_NHOMNGUOIDUNG_MANHINHTableAdapter.GetData();
            foreach (DataRow drct in dt.Rows)
            {
                if (drct["MaNhom"].ToString() == s1 && drct["MaManHinh"].ToString() == s2)
                {
                    drct["CoQuyen"] = s3;
                    rowchange = drct;
                    break;
                }
            }
            return rowchange;
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

        private void gridViewPQ_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void gridViewPQ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //var rowHandle1 = gridViewPQ.FocusedRowHandle;
            //string mamh = gridViewPQ.GetRowCellValue(rowHandle1, "MaManHinh").ToString();
            //string tenmh = gridViewPQ.GetRowCellValue(rowHandle1, "TenManHinh").ToString();
            //bool? quyen = (bool?)gridViewPQ.GetRowCellValue(rowHandle1, "CoQuyen");

            //dongchon.Rows.Add(rowHandle1);
        }

    }
}