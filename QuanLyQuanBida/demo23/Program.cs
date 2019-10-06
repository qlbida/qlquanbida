using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo23
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static FrmDangNhap fdn = null;
        public static FrmMain fm = null;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static
            extern bool SetProcessDPIAware();
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //fdn = new FrmDangNhap();
            //Application.Run(fdn);
            //Application.Run(new FrmCauHinh());
            //Application.Run(new FrnNguoiDung());
            Application.Run(new FrmNguoiDung_NhomND());
        }
    }
}
