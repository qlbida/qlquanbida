using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace HuntControls
{
    public class dtDoiMauDong: DataGridView
    {
         public dtDoiMauDong()
        {
            this.RowEnter += new DataGridViewCellEventHandler(dtDoiMauDong_RowEnter);
        }

        private void dtDoiMauDong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < this.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    this.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                else
                    this.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }
    }
}
