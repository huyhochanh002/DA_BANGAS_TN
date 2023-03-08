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
    public partial class FrmPN : Form
    {
        public FrmPN()
        {
            InitializeComponent();
        }

        public Giaodienchinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

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

        public void ComboMaGas()
        {
            Runnow();
            SqlCommand cmd = new SqlCommand("select * from Gas", cnn);
            SqlDataAdapter daGas = new SqlDataAdapter(cmd);
            DataSet dsGas = new DataSet();
            daGas.Fill(dsGas);
            cmd.ExecuteNonQuery();
            cnn.Close();
            cb_Magas.DataSource = null;
            cb_Magas.DataSource = dsGas.Tables[0];
            cb_Magas.DisplayMember = "Magas";
            cb_Magas.ValueMember = "Magas";

        }
        private void ComboDaiLi()
        {
            Runnow();
            SqlCommand cmd = new SqlCommand("select * from NhaCungCap", cnn);
            SqlDataAdapter daNCC = new SqlDataAdapter(cmd);
            DataSet dsNCC = new DataSet();
            daNCC.Fill(dsNCC);
            cmd.ExecuteNonQuery();
            cnn.Close();
            cb_daili.DataSource = null;
            cb_daili.DataSource = dsNCC.Tables[0];
            cb_daili.DisplayMember = "Tenncc";
            cb_daili.ValueMember = "Mancc";
        }

        private void FrmPN_Load(object sender, EventArgs e)
        {
            ComboMaGas();
            ComboDaiLi();
            ondataviewPN();
        }

        public void ondataviewPN()
        {
            try
            {
                Runnow();
                string s = "Select * From PhieuNhap";
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_PN.DataSource = bin;
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu Phiếu nhập ! ");
            }
        }

        public void ClearvaLoad()
        {
            txt_MaPN.Text = "";
            txt_sl.Text = "";
            txt_ngaythang.Text = "";
            btn_Them.Enabled = true;

            dt.Clear();
            da.Fill(dt);
            ComboMaGas();
            ComboDaiLi();
           
        }

        private void data_PN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txt_MaPN.Text = Convert.ToString(data_PN.CurrentRow.Cells["Manhap"].Value);
                    cb_Magas.SelectedValue = Convert.ToInt32(data_PN.CurrentRow.Cells["Magas"].Value);

                    txt_sl.Text = Convert.ToString(data_PN.CurrentRow.Cells["Soluong"].Value);

                    txt_ngaythang.Text = Convert.ToString(data_PN.CurrentRow.Cells["Ngaythang"].Value);
                    cb_daili.SelectedValue = Convert.ToInt32(data_PN.CurrentRow.Cells["Tendaili"].Value);


                    //soluonggasthuhoi = int.Parse(Convert.ToString(data_PN.CurrentRow.Cells["Soluong"].Value));


                }
            }
            catch (Exception e2)
            {
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // cập nhật số tồn của gas

            try
            {

                Runnow();
                string s = "Select MAX(Slton) From Gas where Magas = @Magas";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.Text);
                int sltonkho = (int)cmd.ExecuteScalar();
                cnn.Close();
                // Kiểm tra đủ sl để bán không
                int soluongnhap = int.Parse(txt_sl.Text);
                
                    Runnow();
                    s = "Update Gas set Slton =" + (sltonkho + soluongnhap) + " where Magas = @Magas ";
                    cmd = new SqlCommand(s, cnn);
                    cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.Text);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                

            }
            catch (Exception e3)
            {
                cnn.Close();
            }
            try
            {
                Runnow();
                string s = "insert into PhieuNhap (Magas,Soluong,Ngaythang,Tendaili) values " +
                    "(@Magas,@Soluong,@Ngaythang,@Tendaili)";
                SqlCommand cmd = new SqlCommand(s, cnn);
                //cmd.Parameters.Add("@Manhap", SqlDbType.Int).Value = int.Parse(txt_MaPN.Text);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.SelectedValue.ToString());
                cmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = int.Parse(txt_sl.Text);
                cmd.Parameters.Add("@Ngaythang", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@Tendaili", SqlDbType.NVarChar).Value = int.Parse(cb_daili.SelectedValue.ToString());
             
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
        int soluonggasthuhoi = 0;
        private void btn_suaPN_Click(object sender, EventArgs e)
        {
            // cập nhật số tồn của gas

            try
            {
                Runnow();
                string s = "Select Soluong From PhieuNhap where Manhap = @Manhap";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Manhap", SqlDbType.Int).Value = int.Parse(txt_MaPN.Text);
                int slcu = (int)cmd.ExecuteScalar();
                cnn.Close();
                if(slcu< int.Parse(txt_sl.Text))
                {
                    Runnow();
                    s = "Select MAX(Slton) From Gas where Magas = @Magas";
                    cmd = new SqlCommand(s, cnn);
                    cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.Text);
                    int sltonkho = (int)cmd.ExecuteScalar();
                    cnn.Close();
                    
                    int soluongthem = int.Parse(txt_sl.Text)-slcu;

                    Runnow();
                    s = "Update Gas set Slton =" + (sltonkho + soluongthem) + " where Magas = @Magas ";
                    cmd = new SqlCommand(s, cnn);
                    cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.Text);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                        else
                {
                    Runnow();
                    s = "Select MAX(Slton) From Gas where Magas = @Magas";
                    cmd = new SqlCommand(s, cnn);
                    cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.Text);
                    int sltonkho = (int)cmd.ExecuteScalar();
                    cnn.Close();

                    int soluongbo = slcu- int.Parse(txt_sl.Text);

                    Runnow();
                    s = "Update Gas set Slton =" + (sltonkho -soluongbo) + " where Magas = @Magas ";
                    cmd = new SqlCommand(s, cnn);
                    cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.Text);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }


            }
            catch (Exception e3)
            {
                cnn.Close();
            }

            try
            {
                Runnow();
                string s = "Update PhieuNhap set Magas=@Magas,Soluong=@Soluong,Tendaili=@Tendaili, Ngaythang=@Ngaythang where Manhap=@Manhap";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Manhap", SqlDbType.Int).Value = int.Parse(txt_MaPN.Text);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.SelectedValue.ToString());
                cmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = int.Parse(txt_sl.Text);
                cmd.Parameters.Add("@Tendaili", SqlDbType.NVarChar).Value = int.Parse(cb_daili.SelectedValue.ToString());
                cmd.Parameters.Add("@Ngaythang", SqlDbType.DateTime).Value = DateTime.Now;
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

        private void btn_xoaPN_Click(object sender, EventArgs e)
        {
            // cập nhật số tồn của gas

            try
            {
                Runnow();
                string s = "Select Soluong From PhieuNhap where Manhap = @Manhap";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Manhap", SqlDbType.Int).Value = int.Parse(txt_MaPN.Text);
                int sl = (int)cmd.ExecuteScalar();
                cnn.Close();
                Runnow();
                s = "Select MAX(Slton) From Gas where Magas = @Magas";
                cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.Text);
                int sltonkho = (int)cmd.ExecuteScalar();
                cnn.Close();
                // Kiểm tra đủ sl để bán không
                int soluongnhap = int.Parse(txt_sl.Text);

                Runnow();
                s = "Update Gas set Slton =" + (sltonkho -sl) + " where Magas = @Magas ";
                cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();
                try
                {
                    Runnow();
                    s = "DELETE FROM PhieuNhap Where Manhap = @Manhap";
                    cmd = new SqlCommand(s, cnn);
                    cmd.Parameters.Add("@Manhap", SqlDbType.Int).Value = int.Parse(txt_MaPN.Text);
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
            catch (Exception e3)
            {
                cnn.Close();
            }
            
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ClearvaLoad();
        }

     
        

  

        private void txt_sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cb_daili_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
