﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace demo
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        List<SimpleButton> dsban = new List<SimpleButton>();

        private void timer1_Tick(object sender, EventArgs e)
        {
           btnThoiGian.Caption = DateTime.Now.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8) //nhận phím backspace
                e.Handled = false;
            else
                e.Handled = true; //bỏ qua lần nhấn phím ko hợp lệ
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            taoBanBida(14); //số bàn có thể thay đổi

            //Chỗ truyền dữ liệu từ form đăng nhập
            btnNguoiDung.Caption += "Tuấn Khôi";
            btnNhomQuyen.Caption += " Admin";
        }

        void taoBanBida(int n)
        {
            int soban = 1;
            for (int i = 1; i <= Math.Ceiling((double)n / 6); i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    SimpleButton ban = new SimpleButton();

                    if (soban <= n)
                    {
                        ban.Size = new Size(200, 200);
                        ban.Top = i * 250;
                        ban.Left = j * 250;

                        ban.Text = "Bàn " + soban.ToString() + "\n Sẵn sàng đón khách";
                        ban.Name = "Btn" + soban.ToString();

                        ban.LookAndFeel.SetSkinStyle("Office 2007 Green");

                        ban.ContextMenuStrip = contextMSDatBan;

                        this.Controls.Add(ban);
                        dsban.Add(ban);
                        soban++;
                    }
                }
            }
        }// hết hàm taoBanBida
            

    }
}
 