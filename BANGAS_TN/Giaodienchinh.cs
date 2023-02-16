using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANGAS_TN
{
    public partial class Giaodienchinh : Form
    {
        public Giaodienchinh()
        {
            InitializeComponent();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            FrmKhachhang k = new FrmKhachhang();
            k.ShowDialog();

        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            FrmNhanvien n = new FrmNhanvien();
            n.ShowDialog();
        }

        private void btnGas_Click(object sender, EventArgs e)
        {
            FrmGas g = new FrmGas();
            g.ShowDialog();

        }
    }
}
