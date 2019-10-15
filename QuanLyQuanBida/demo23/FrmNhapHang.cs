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
    public partial class FrmNhapHang : DevExpress.XtraEditors.XtraForm
    {
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
            // TODO: This line of code loads data into the 'dataSetBida.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.dataSetBida.NHACUNGCAP);

        }
    }
}