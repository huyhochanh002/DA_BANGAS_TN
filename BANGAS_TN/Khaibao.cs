using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANGAS_TN
{
    internal class Khaibao
    {
        String NguyenChuoi;
        public string laychuoi()
        {
            String s;
            StreamReader rd = new StreamReader("ketNoi.txt");
            s = rd.ReadToEnd();
            rd.Close();
            return s;
        }
        public Khaibao()
        {
            NguyenChuoi = laychuoi();
        }
    }
}
