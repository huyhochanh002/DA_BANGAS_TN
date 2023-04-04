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
    public partial class Frmlogin : Form
    {
        List<TaiKhoan> listtaikhoan = ListAccount.Instance.Listtaikhoan;
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        bool isThoat = true;
        private void btn_login_Click(object sender, EventArgs e)
        {
             
              
          
        }

       

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
        }

        bool Kiemtradangnhap(string tentaikhoan, string matkhau)
        {
           for(int i = 0; i< listtaikhoan.Count;i++)
            {
                if (tentaikhoan == listtaikhoan[i].Name && matkhau == listtaikhoan[i].Password)
                    return true;
            }    
            return false;
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (Kiemtradangnhap(txt_name.Text, txt_pass.Text))
            {
                isThoat = false;
                Giaodienchinh g = new Giaodienchinh();
                g.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu rồi!");
                txt_name.Focus();
            }
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }
    }
}
