using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuntControls
{
    public class txtChiNhapHoa: TextBox
    {
        public txtChiNhapHoa()
        {
            this.KeyPress += new KeyPressEventHandler(txtChiNhapHoa_KeyPress);
        }

        private void txtChiNhapHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8) //nhận phím backspace
                e.Handled = false;
            else
                e.Handled = true; //bỏ qua lần nhấn phím ko hợp lệ
        }
    }
}
