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
    public partial class FrmNhaCC : DevExpress.XtraEditors.XtraForm
    {
        public DataTable ncc;
        public FrmNhaCC()
        {
            InitializeComponent();
        }

        private void FrmNhaCC_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            loadNhaCC();

            maNCCTextEdit.Enabled = false;
            tenNCCTextEdit.Focus();
        }

        string taoMaNCC()
        {
            return "NCC00" + (ncc.Rows.Count + 1).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nHACUNGCAPTableAdapter.Insert(taoMaNCC(), tenNCCTextEdit.Text, diaChiTextEdit.Text, soDTTextEdit.Text);
            MessageBox.Show("Thêm nhà cung cấp thành công !!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataRow dr = getRowChange(ncc);
            nHACUNGCAPTableAdapter.Update(dr);
            MessageBox.Show("Sửa thành công !!");
            loadNhaCC();
        }

        DataRow getRowChange(DataTable dt)
        {
            DataRow rowchange = null;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString() == maNCCTextEdit.Text)
                {
                    dr[1] = tenNCCTextEdit.Text;
                    dr[2] = diaChiTextEdit.Text;
                    dr[3] = soDTTextEdit.Text;
                    rowchange = dr;
                }
            }
            return rowchange;
        }

        void loadNhaCC()
        {
            // TODO: This line of code loads data into the 'dataSetBida.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.dataSetBida.NHACUNGCAP);
            ncc = nHACUNGCAPTableAdapter.GetData();

            repositoryItemHyperLinkEdit1.Click += repositoryItemHyperLinkEdit1_Click;
        }

        //Xóa
        private void repositoryItemHyperLinkEdit1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa !!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var rowHandle = gridViewND.FocusedRowHandle;
                string mancc = gridViewND.GetRowCellValue(rowHandle, "MaNCC").ToString();

                nHACUNGCAPTableAdapter.Delete(maNCCTextEdit.Text, string.Empty, string.Empty, string.Empty);
                MessageBox.Show("Xóa thành công !!");
                loadNhaCC();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}