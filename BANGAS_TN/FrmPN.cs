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
                string s = "select * from PhieuNhap LEFT JOIN Gas on PhieuNhap.Magas = Gas.Magas";
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_PN.DataSource = bin;

                data_PN.Columns[0].HeaderText = "Mã Nhập";
                data_PN.Columns[1].HeaderText = "Mã Gas";
                data_PN.Columns[2].HeaderText = "Số Lượng";
                data_PN.Columns[3].HeaderText = "Ngày Tháng";
                data_PN.Columns[4].HeaderText = "Tên Đại Lí";
                // ẩn
                data_PN.Columns[5].HeaderText = "Mã Gas 1";
                data_PN.Columns[5].Visible = false;
                //--
                data_PN.Columns[6].HeaderText = "Mã Loại";
                //------ hiện mã loại lấy tên
                //--
                data_PN.Columns[7].HeaderText = "Mã NCC";
                data_PN.Columns[7].Visible = false;
                //---
                data_PN.Columns[8].HeaderText = "SIZE";
                data_PN.Columns[8].Visible = false;
                //--
                data_PN.Columns[9].HeaderText = "Số Lượng Tồn";
                data_PN.Columns[9].Visible = false;
                //--
                data_PN.Columns[10].HeaderText = "Đơn Giá";
                data_PN.Columns[10].Visible = false;
                //---
                data_PN.Columns[11].HeaderText = "ISDELETE";
                data_PN.Columns[11].Visible = false;
                //---

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
            //-- xoa cbb
            cb_LoaiGas.DataSource = null;

        }

        private void data_PN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    ComboLoaiGas();
                    txt_MaPN.Text = Convert.ToString(data_PN.CurrentRow.Cells["Manhap"].Value);
                    cb_Magas.SelectedValue = Convert.ToInt32(data_PN.CurrentRow.Cells["Magas"].Value);

                    txt_sl.Text = Convert.ToString(data_PN.CurrentRow.Cells["Soluong"].Value);

                    txt_ngaythang.Text = Convert.ToString(data_PN.CurrentRow.Cells["Ngaythang"].Value);
                    cb_daili.SelectedValue = Convert.ToInt32(data_PN.CurrentRow.Cells["Tendaili"].Value);

                    cb_LoaiGas.SelectedValue = Convert.ToInt32(data_PN.CurrentRow.Cells["Maloai"].Value);

                    btn_Them.Enabled = false;


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
                // Kiểm tra sl nhập
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
                return; // thêm sl ko được thì ko làm bước thêm phiếu
                cnn.Close();
            }
            try
            {
                Runnow();
                string s = "insert into PhieuNhap (Magas,Soluong,Ngaythang,Tendaili) values " +
                    "(@Magas,@Soluong,@Ngaythang,@Tendaili)";
                SqlCommand cmd = new SqlCommand(s, cnn);
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
        private void btn_suaPN_Click(object sender, EventArgs e)
        {
            // cập nhật số tồn của gas
            try
            {
                Runnow();
                string s = "Select MAX(Soluong) From PhieuNhap where Manhap = @Manhap";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Manhap", SqlDbType.Int).Value = int.Parse(txt_MaPN.Text);
                // lấy sl gás cũ
                int slgasdanhap = (int)cmd.ExecuteScalar(); //50
                cnn.Close();

                // lấy sl gá tồn kho
                Runnow();
                s = "Select MAX(Slton) From Gas where Magas = @Magas";
                cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.Text);
                int sltonkho = (int)cmd.ExecuteScalar(); //100
                cnn.Close();

                // update lại sl tồn
                Runnow();
                s = "Update Gas set Slton =" + (sltonkho - slgasdanhap + int.Parse(txt_sl.Text)) + " where Magas = @Magas "; //110
                cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.SelectedValue.ToString());

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
                string s = "Update PhieuNhap set Magas=@Magas,Soluong=@Soluong,Tendaili=@Tendaili where Manhap=@Manhap";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Manhap", SqlDbType.Int).Value = int.Parse(txt_MaPN.Text);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.SelectedValue.ToString());
                cmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = int.Parse(txt_sl.Text);
                cmd.Parameters.Add("@Tendaili", SqlDbType.NVarChar).Value = int.Parse(cb_daili.SelectedValue.ToString());
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
            //

            try
            {
                // lấy sl trong phiếu
                Runnow();
                string s = "Select Soluong From PhieuNhap where Manhap = @Manhap";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Manhap", SqlDbType.Int).Value = int.Parse(txt_MaPN.Text);
                int slphieunhap = (int)cmd.ExecuteScalar();
                cnn.Close();

                //lấy sl trong tồn kho
                Runnow();
                s = "Select MAX(Slton) From Gas where Magas = @Magas";
                cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.SelectedValue.ToString());
                int sltonkho = (int)cmd.ExecuteScalar();
                cnn.Close();

                if(sltonkho<slphieunhap)
                {
                    MessageBox.Show("Khổng thể chỉnh sữa số lượng khi gas tồn ít hơn sl nhập !");

                }
                else {

                    //Update sl khi xóa
                    Runnow();
                     s = "Update Gas set Slton="+(sltonkho-slphieunhap)+" where Magas=@Magas";
                    cmd = new SqlCommand(s, cnn);
                    cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    cnn.Close();

                    // Tiến hành xóa phiếu nhập
                    Runnow();
                    s = "DELETE FROM PhieuNhap Where Manhap = @Manhap";
                    cmd = new SqlCommand(s, cnn);
                    cmd.Parameters.Add("@Manhap", SqlDbType.Int).Value = int.Parse(txt_MaPN.Text);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    ClearvaLoad();
                    MessageBox.Show("Đã Xóa Thành Công");
                }



            }
            catch (Exception e3)
            {
                cnn.Close();
                MessageBox.Show("Đã Xóa Thất Bại");
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
