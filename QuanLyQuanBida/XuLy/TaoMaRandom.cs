using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLy
{
    public static class TaoMaRandom
    {
        public static string taoMaRandom()
        {
            Random rd = new Random();
            string mard = "";
            for (int i = 0; i < 8; i++)
            {
                int chon = rd.Next(1, 4);
                if (chon == 3)
                {
                    string chuhoa = Convert.ToString((char)rd.Next(65, 91));
                    mard = mard + chuhoa;
                }
                if (chon == 2)
                {
                    string chuthuong = Convert.ToString((char)rd.Next(97, 123));
                    mard = mard + chuthuong;
                }
                if (chon == 1)
                {
                    string so = rd.Next(0, 10).ToString();
                    mard = mard + so;
                }
            }
            return mard;
        }
    }
}
