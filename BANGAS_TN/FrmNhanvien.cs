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
    public partial class FrmNhanvien : Form
    {
        public FrmNhanvien()
        {
            InitializeComponent();
        }
        public Giaodienchinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        // Khai báo các biến cần thiết;
        Khaibao kb = new Khaibao();

        SqlConnection cnn = new SqlConnection();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bin = new BindingSource();

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
        public void ondataviewNV()
        {
            try
            {
                Runnow();
                string s = "Select * From NhanVien";
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_Nhanvien.DataSource = bin;
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
            txt_Manv.Text = "";
            txt_Tennv.Text = "";
            txt_Dienthoainv.Text = "";
            txt_Diachinv.Text = "";
            txt_Ghichunv.Text = "";
            if (btn_ThemNV.Enabled == false)
            {
                btn_ThemNV.Enabled = true;
            }
            dt.Clear();
            da.Fill(dt);
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "insert into NhanVien (Tennv,Diachi,Dienthoai,Ghichu) values " +
                    "(@Tennv,@Dienthoai,@Diachi,@Ghichu)";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Tennv", SqlDbType.NVarChar).Value = txt_Tennv.Text;
                cmd.Parameters.Add("@Dienthoai", SqlDbType.Int).Value = int.Parse(txt_Dienthoainv.Text);
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = txt_Diachinv.Text;
                cmd.Parameters.Add("@Ghichu", SqlDbType.NVarChar).Value = txt_Ghichunv.Text;
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

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "Update NhanVien set Tennv=@Tennv,Dienthoai=@Dienthoai,Diachi=@Diachi,Ghichu=@Ghichu where Manv=@Manv";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Manv", SqlDbType.Int).Value = int.Parse(txt_Manv.Text);
                cmd.Parameters.Add("@Tennv", SqlDbType.NVarChar).Value = txt_Tennv.Text;
                cmd.Parameters.Add("@Dienthoai", SqlDbType.Int).Value = int.Parse(txt_Dienthoainv.Text);
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = txt_Diachinv.Text;
                cmd.Parameters.Add("@Ghichu", SqlDbType.NVarChar).Value = txt_Ghichunv.Text;
                cmd.ExecuteNonQuery();
                cnn.Close();
                ClearvaLoad();
                MessageBox.Show("Đã Sữa Thành Công");


            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Dữ Liệu nhập ! ");
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "DELETE FROM NhanVien Where Manv = @Manv";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Manv", SqlDbType.Int).Value = int.Parse(txt_Manv.Text);
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

        private void data_Nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txt_Manv.Text = Convert.ToString(data_Nhanvien.CurrentRow.Cells["Manv"].Value);
                    txt_Tennv.Text = Convert.ToString(data_Nhanvien.CurrentRow.Cells["Tennv"].Value);
                    txt_Dienthoainv.Text = Convert.ToString(data_Nhanvien.CurrentRow.Cells["Dienthoai"].Value);
                    txt_Diachinv.Text = Convert.ToString(data_Nhanvien.CurrentRow.Cells["Diachi"].Value);
                    txt_Ghichunv.Text = Convert.ToString(data_Nhanvien.CurrentRow.Cells["Ghichu"].Value);
                    btn_ThemNV.Enabled = false;
                }
            }
            catch (Exception e2)
            {
            }
        }

        private void btn_clearNV_Click(object sender, EventArgs e)
        {
            ClearvaLoad();
        }

        private void FrmNhanvien_Load(object sender, EventArgs e)
        {
            ondataviewNV();
        }
    }
}
