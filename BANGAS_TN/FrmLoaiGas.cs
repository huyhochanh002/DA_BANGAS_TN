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
    public partial class FrmLoaiGas : Form
    {
        public FrmLoaiGas()
        {
            InitializeComponent();
        }
        public Giaodienchinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLoaiGas_Load(object sender, EventArgs e)
        {
            ondataviewLoaiGas();
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
        public void ondataviewLoaiGas()
        {
            try
            {
                Runnow();
                string s = "Select * From LoaiGas";
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_LoaiGas.DataSource = bin;
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu Loại Gas! ");
            }
        }
        // CÁI HÀM NÀY SẼ CLEAR MẤY Ô KHI THÊM VÀ ĐỒNG THỜI LOAD LẠI LIST DỮ LIỆU
        public void ClearvaLoad()
        {
            txtMaLoaiGas.Text = "";
            txtTenLoaiGas.Text = "";
            if (btn_ThemGas.Enabled == false)
            {
                btn_ThemGas.Enabled = true;
            }
            dt.Clear();
            da.Fill(dt);
            
            
        }

        private void btn_ThemGas_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTenLoaiGas.Text=="")
                {
                    MessageBox.Show("Vui Lòng Kiểm Tra Lại Dữ Liệu nhập ! ");
                    return;
                }
                Runnow();
                string s = "insert into LoaiGas (TenLoai) values " +
                    "(@TenLoai)";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@TenLoai", SqlDbType.NVarChar).Value = txtTenLoaiGas.Text;
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

        private void btn_Suagas_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "Update LoaiGas set TenLoai=@TenLoai where MaLoai=@MaLoai";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MaLoai", SqlDbType.Int).Value = int.Parse(txtMaLoaiGas.Text);
                cmd.Parameters.Add("@TenLoai", SqlDbType.NVarChar).Value = txtTenLoaiGas.Text;
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

        private void btn_Xoagas_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "DELETE FROM LoaiGas Where MaLoai = @MaLoai";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MaLoai", SqlDbType.Int).Value = int.Parse(txtMaLoaiGas.Text);
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

        private void btn_cleargas_Click(object sender, EventArgs e)
        {
            ClearvaLoad();
        }

        private void data_LoaiGas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtMaLoaiGas.Text = Convert.ToString(data_LoaiGas.CurrentRow.Cells["MaLoai"].Value);
                    txtTenLoaiGas.Text = Convert.ToString(data_LoaiGas.CurrentRow.Cells["TenLoai"].Value);
                    btn_ThemGas.Enabled = false;
                }
            }
            catch (Exception e2)
            {
            }
        }
    }
}
