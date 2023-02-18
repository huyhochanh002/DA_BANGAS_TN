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
    public partial class FrmKhachhang : Form
    {
        public FrmKhachhang()
        {
            InitializeComponent();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }
        public Giaodienchinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
        private void FrmKhachhang_Load(object sender, EventArgs e)
        {
            ondataviewKH();
        }

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
        public void ondataviewKH()
        {
            try
            {
                Runnow();
                string s = "Select * From KhachHang";
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_KhachHang.DataSource = bin;
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu Khách Hàng ! ");
            }
        }
        // CÁI HÀM NÀY SẼ CLEAR MẤY Ô KHI THÊM VÀ ĐỒNG THỜI LOAD LẠI LIST DỮ LIỆU
        public void ClearvaLoad()
        {
            txt_Makh.Text = "";
            txt_TenKH.Text = "";
            txt_SdtKH.Text = "";
            txt_DiachiKH.Text = "";
            txt_GhichuKH.Text = "";
            dt.Clear();
            da.Fill(dt);
        }
        private void btn_themKH_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "insert into KhachHang (Tenkh,Dienthoai,Diachi,Ghichu) values " +
                    "(@Tenkh,@Dienthoai,@Diachi,@Ghichu)";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Tenkh", SqlDbType.NVarChar).Value = txt_TenKH.Text;
                cmd.Parameters.Add("@Dienthoai", SqlDbType.Int).Value = int.Parse(txt_SdtKH.Text);
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = txt_DiachiKH.Text;
                cmd.Parameters.Add("@Ghichu", SqlDbType.NVarChar).Value = txt_GhichuKH.Text;
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

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "Update KhachHang set Tenkh=@Tenkh,Dienthoai=@Dienthoai,Diachi=@Diachi,Ghichu=@Ghichu where Makh=@Makh";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Makh", SqlDbType.Int).Value = int.Parse(txt_Makh.Text);
                cmd.Parameters.Add("@Tenkh", SqlDbType.NVarChar).Value = txt_TenKH.Text;
                cmd.Parameters.Add("@Dienthoai", SqlDbType.Int).Value = int.Parse(txt_SdtKH.Text);
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = txt_DiachiKH.Text;
                cmd.Parameters.Add("@Ghichu", SqlDbType.NVarChar).Value = txt_GhichuKH.Text;
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

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "DELETE FROM KhachHang Where Makh = @Makh";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Makh", SqlDbType.Int).Value = int.Parse(txt_Makh.Text);
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

        private void data_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txt_Makh.Text = Convert.ToString(data_KhachHang.CurrentRow.Cells["Makh"].Value);
                    txt_TenKH.Text = Convert.ToString(data_KhachHang.CurrentRow.Cells["Tenkh"].Value);
                    txt_SdtKH.Text = Convert.ToString(data_KhachHang.CurrentRow.Cells["Dienthoai"].Value);
                    txt_DiachiKH.Text = Convert.ToString(data_KhachHang.CurrentRow.Cells["Diachi"].Value);
                    txt_GhichuKH.Text = Convert.ToString(data_KhachHang.CurrentRow.Cells["Ghichu"].Value);
                    btn_themKH.Enabled = false;
                }
            }
            catch (Exception e2)
            {
            }
        }
    }
}
