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
    public partial class FrmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBida);

        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBida.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.dataSetBida.KHACHHANG);

        }
    }
}