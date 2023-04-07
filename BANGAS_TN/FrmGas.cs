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
    public partial class FrmGas : Form
    {
        public FrmGas()
        {
            InitializeComponent();
        }


        public Giaodienchinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        private void FrmGas_Load(object sender, EventArgs e)
        {
            try {
                ComboLoaiGas();
                ComboNCC();
                ondataviewGAS();
            }catch(Exception e2)
            {

            }
        }
        // Khai báo các biến cần thiết;
        Khaibao kb = new Khaibao();

        SqlConnection cnn = new SqlConnection();

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bin = new BindingSource();


        //n Load lai data loai gas va ncc
       
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
        // Load ComBoBox 
        public void ComboLoaiGas()
        {
            Runnow();
            SqlCommand cmd = new SqlCommand("select * from LoaiGas", cnn);
            SqlDataAdapter daLoaiGas = new SqlDataAdapter(cmd);
            DataSet dsLoaiGas = new DataSet();
            daLoaiGas.Fill(dsLoaiGas);
            cmd.ExecuteNonQuery();
            cnn.Close();
            cb_LoaiGas.DataSource = null;
            cb_LoaiGas.DataSource = dsLoaiGas.Tables[0];
            cb_LoaiGas.DisplayMember = "Tenloai";
            cb_LoaiGas.ValueMember = "Maloai";
            
        }
        public void ComboNCC()
        {
            Runnow();
            SqlCommand cmd = new SqlCommand("select * from NhaCungCap", cnn);
            SqlDataAdapter daNCC = new SqlDataAdapter(cmd);
            DataSet dsNCC = new DataSet();
            daNCC.Fill(dsNCC);
            cmd.ExecuteNonQuery();
            cnn.Close();
            cb_Ncc.DataSource=null;
            cb_Ncc.DataSource = dsNCC.Tables[0];
            cb_Ncc.DisplayMember = "Tenncc";
            cb_Ncc.ValueMember = "Mancc";
        }


        // On view data lên list
        public void ondataviewGAS()
        {
            try
            {
                Runnow();
                string s = "Select [Magas],[Maloai],[Mancc],[Size],[Slton],[Dgia] From Gas";
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_Gas.DataSource = bin;

                data_Gas.Columns[0].HeaderText = "Mã Gas";
                data_Gas.Columns[1].HeaderText = "Mã Loại";
                data_Gas.Columns[2].HeaderText = "Mã NCC";
                data_Gas.Columns[3].HeaderText = "SIZE";
                data_Gas.Columns[4].HeaderText = "Số Lượng Tồn";
                data_Gas.Columns[5].HeaderText = "Đơn Giá";


                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu GAS ! ");
            }
        }
        // CÁI HÀM NÀY SẼ CLEAR MẤY Ô KHI THÊM VÀ ĐỒNG THỜI LOAD LẠI LIST DỮ LIỆU
        public void ClearvaLoad()
        {
            txt_MagasGAS.Text = "";
            txt_DgiaGAS.Text = "";
            txt_SizeGAS.Text = "";
            txt_SltonGAS.Text = "";
            btn_ThemGAS.Enabled = true;
            dt.Clear();
            da.Fill(dt);
            ComboLoaiGas();
            ComboNCC();
        }

        private void btn_ThemGAS_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "insert into Gas (Maloai,Mancc,Size,Slton,Dgia) values " +
                    "(@Maloai,@Mancc,@Size,@Slton,@Dgia)";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Maloai", SqlDbType.Int).Value = int.Parse(cb_LoaiGas.SelectedValue.ToString());
                cmd.Parameters.Add("@Mancc", SqlDbType.Int).Value = int.Parse(cb_Ncc.SelectedValue.ToString());
                cmd.Parameters.Add("@Size", SqlDbType.NVarChar).Value = txt_SizeGAS.Text;
                cmd.Parameters.Add("@Slton", SqlDbType.Int).Value = int.Parse(txt_SltonGAS.Text);
                cmd.Parameters.Add("@Dgia", SqlDbType.Float).Value = float.Parse(txt_SltonGAS.Text);
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

        private void btn_SuaGAS_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "Update Gas set Maloai=@Maloai,Mancc=@Mancc,Size=@Size,Slton=@Slton,Dgia=@Dgia where Magas=@Magas";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(txt_MagasGAS.Text);
                cmd.Parameters.Add("@Maloai", SqlDbType.Int).Value = int.Parse(cb_LoaiGas.SelectedValue.ToString());
                cmd.Parameters.Add("@Mancc", SqlDbType.Int).Value = int.Parse(cb_Ncc.SelectedValue.ToString());
                cmd.Parameters.Add("@Size", SqlDbType.NVarChar).Value = txt_SizeGAS.Text;
                cmd.Parameters.Add("@Slton", SqlDbType.Int).Value = int.Parse(txt_SltonGAS.Text);
                cmd.Parameters.Add("@Dgia", SqlDbType.Float).Value = float.Parse(txt_DgiaGAS.Text);
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

        private void btn_XoaGAS_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "DELETE FROM Gas Where Magas = @Magas";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(txt_MagasGAS.Text);
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

        private void data_Gas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txt_MagasGAS.Text = Convert.ToString(data_Gas.CurrentRow.Cells["Magas"].Value);
                    cb_LoaiGas.SelectedValue = Convert.ToInt32(data_Gas.CurrentRow.Cells["Maloai"].Value);
                    cb_Ncc.SelectedValue = Convert.ToInt32(data_Gas.CurrentRow.Cells["Mancc"].Value);
                    txt_DgiaGAS.Text = Convert.ToString(data_Gas.CurrentRow.Cells["Dgia"].Value);
                    txt_SizeGAS.Text = Convert.ToString(data_Gas.CurrentRow.Cells["Size"].Value);
                    txt_SltonGAS.Text = Convert.ToString(data_Gas.CurrentRow.Cells["Slton"].Value);
                    btn_ThemGAS.Enabled = false;
                }
            }
            catch (Exception e2)
            {
            }
        }

        private void v(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearvaLoad();
        }

        private void cb_Ncc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
