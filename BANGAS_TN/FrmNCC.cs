using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANGAS_TN
{
    public partial class FrmNCC : Form
    {
        public FrmNCC()
        {
            InitializeComponent();
        }
        public Giaodienchinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        private void FrmNCC_Load(object sender, EventArgs e)
        {
            ondataviewNCC();
        }

        // Khai báo các biến cần thiết;
        Khaibao kb = new Khaibao();

        SqlConnection cnn = new SqlConnection();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bin = new BindingSource();

        FrmGas gasload = new FrmGas();

        public void Runnow()
        {
            try
            {
                string s = kb.laychuoi(); /*"Server=" + khaibao.Server + ";database="+khaibao.Database+";uid="+khaibao.Uid+";pwd="+khaibao.Pwd;*/
                cnn.ConnectionString = s;
                cnn.Open();
            }
            catch (Exception e2)
            {
                MessageBox.Show("Có Lỗi Khi Kết Nối Dữ Liệu Server ! ");
            }
        }

        // On view data lên list
        public void ondataviewNCC()
        {
            try
            {
                Runnow();
                string s = "Select [Mancc],[Tenncc],[Diachi] From NhaCungCap";
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_NCC.DataSource = bin;

                data_NCC.Columns[0].HeaderText = "Mã NCC";
                data_NCC.Columns[1].HeaderText = "Tên NCC";
                data_NCC.Columns[2].HeaderText = "Địa Chỉ";
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu Nhân Viên! ");
            }
        }
        // CÁI HÀM NÀY SẼ CLEAR MẤY Ô KHI THÊM VÀ ĐỒNG THỜI LOAD LẠI LIST DỮ LIỆU
        public void ClearvaLoad()
        {
            txt_Mancc.Text = "";
            txt_Tencc.Text = "";
            txt_Diachincc.Text = "";
            if (btn_ThemNCC.Enabled == false)
            {
                btn_ThemNCC.Enabled = true;
            }
            dt.Clear();
            da.Fill(dt);
            
           
        }

        private void btn_ThemNCC_Click(object sender, EventArgs e)
        {
            try
            { if(txt_Mancc.Text==""&&txt_Diachincc.Text=="")
                {
                    MessageBox.Show("Vui Lòng Kiểm Tra Lại Dữ Liệu nhập ! ");
                    return;
                }
                Runnow();
                string s = "insert into NhaCungCap (Tenncc,Diachi) values " +
                    "(@Tenncc,@Diachi)";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Tenncc", SqlDbType.NVarChar).Value = txt_Tencc.Text;
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = txt_Diachincc.Text;
                cmd.ExecuteNonQuery();
                cnn.Close();
                ClearvaLoad();
                MessageBox.Show("Thêm Thành Công");

            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Dữ Liệu nhập ! ");
            }
        }

        private void btn_SuaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "Update NhaCungCap set Tenncc=@Tenncc,Diachi=@Diachi where Mancc=@Mancc";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Mancc", SqlDbType.Int).Value = int.Parse(txt_Mancc.Text);
                cmd.Parameters.Add("@Tenncc", SqlDbType.NVarChar).Value = txt_Tencc.Text;
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = txt_Diachincc.Text;
                cmd.ExecuteNonQuery();
                cnn.Close();
                ClearvaLoad();
                MessageBox.Show("Đã Sửa Thành Công");


            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Dữ Liệu nhập ! ");
            }
        }

        private void btn_XoaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "DELETE FROM NhaCungCap Where Mancc = @Mancc";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Mancc", SqlDbType.Int).Value = int.Parse(txt_Mancc.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();
                ClearvaLoad();
                MessageBox.Show("Đã Xóa Thành Công");


            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Xóa Thất Bại ! ");
            }
        }

        private void btn_clearNCC_Click(object sender, EventArgs e)
        {
            ClearvaLoad();
        }

        private void data_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txt_Mancc.Text = Convert.ToString(data_NCC.CurrentRow.Cells["Mancc"].Value);
                    txt_Tencc.Text = Convert.ToString(data_NCC.CurrentRow.Cells["Tenncc"].Value);
                    txt_Diachincc.Text = Convert.ToString(data_NCC.CurrentRow.Cells["Diachi"].Value);
                    btn_ThemNCC.Enabled = false;
                }
            }
            catch (Exception e2)
            {
            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
