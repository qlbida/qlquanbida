using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; //để chỉnh chuỗi cấu hình
using XuLy;

namespace demo23
{
    public partial class FrmCauHinh : Form
    {
        public QLy_NguoiDung cauhinh = new QLy_NguoiDung();
        public FrmCauHinh()
        {
            InitializeComponent();
        }

        public FrmCauHinh(string connect)
        {
            InitializeComponent();
            cauhinh.connect = connect;
        }

        private void cboServer_DropDown(object sender, EventArgs e)
        {
            loadServer();
        }

        void loadServer()
        {
            DataTable dt = cauhinh.GetServerName();

            cboServer.Properties.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                    cboServer.Properties.Items.Add(row[col]);
                }
            }
        }

        private void cboDatabase_DropDown(object sender, EventArgs e)
        {
            //if (CheckedBeforSearchNameDB())
            //{
            cboDatabase.Properties.Items.Clear();
                List<string> _list = cauhinh.GetDatabaseName(cboServer.Text, txtUsername.Text, txtPassword.Text);
                if (_list == null)
                {
                    MessageBox.Show("Thông tin cấu hình chưa chính xác");
                    return;
                }
                foreach (string item in _list)
                {
                    cboDatabase.Properties.Items.Add(item);
                }
            //}
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string newConnect = "Data Source=" + cboServer.Text + ";Initial Catalog=" + cboDatabase.Text + ";User ID=" + txtUsername.Text + ";Password=" + txtPassword.Text;
            string oldConnect = cauhinh.connect;

            Configuration configManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); //hoặc dùng var

            configManager.ConnectionStrings.ConnectionStrings["demo23.Properties.Settings.LTWNCConn"].ConnectionString = newConnect;
            configManager.ConnectionStrings.ConnectionStrings["demo23.Properties.Settings.LTWNCConn"].ProviderName = "System.Data.SqlClient";
            configManager.Save(ConfigurationSaveMode.Modified);



            MessageBox.Show(configManager.ConnectionStrings.ConnectionStrings["demo23.Properties.Settings.LTWNCConn"].ConnectionString);
            if (Properties.Settings.Default.LTWNCConn != configManager.ConnectionStrings.ConnectionStrings["demo23.Properties.Settings.LTWNCConn"].ConnectionString)
                MessageBox.Show("Sửa chuỗi kết nối thành công !!");
            else
                MessageBox.Show("Sửa chuỗi kết nối thất bại !!");

            //this.Close();
        }

        private void FrmCauHinh_Load(object sender, EventArgs e)
        {
            loadServer();
        }
        
    }
}
