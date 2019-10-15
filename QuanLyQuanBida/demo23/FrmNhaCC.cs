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
    public partial class FrmNhaCC : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhaCC()
        {
            InitializeComponent();
        }

        private void FrmNhaCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBida.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.dataSetBida.NHACUNGCAP);

            maNCCTextEdit.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //DataTable dt = nHACUNGCAPTableAdapter.GetData();
            //int soban = dt.Rows.Count;
            clearTextbox();
            
            //nHACUNGCAPTableAdapter.Insert(maNCCTextEdit.Text, tenNCCTextEdit.Text, diaChiTextEdit.Text, soDTTextEdit.Text);
        }

        void clearTextbox()
        {
            tenNCCTextEdit.Text = "\0";
            diaChiTextEdit.Text = "\0";
            soDTTextEdit.Text = "\0";
            
            tenNCCTextEdit.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}