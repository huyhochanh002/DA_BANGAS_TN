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
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
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
        // On view data lên list
        public void ondataviewHoaDon()
        {
            try
            {
                Runnow();
                string s = "Select * From CTHD";
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_HD.DataSource = bin;
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu Chi Tiết Hóa Đơn ! ");
            }
        }

        // CÁI HÀM NÀY SẼ CLEAR MẤY Ô KHI THÊM VÀ ĐỒNG THỜI LOAD LẠI LIST DỮ LIỆU
        public void ClearvaLoad()
        {
            txt_MaHD.Text = "";
            txt_dongia.Text = "";
            txt_soluong.Text = "";
            txt_tongtien.Text = "";
            txt_ghichu.Text = "";
            cb_Magas.SelectedText = "Mời chọn mã gas";
            check_notien.Checked = false;
            check_tratien.Checked = false; 
            check_novo  .Checked = false;
            check_travo .Checked = false;   
            check_trangthai .Checked = false;
            ComboMaGas();
            dt.Clear();
            da.Fill(dt);
            btn_suaHD.Enabled = true;
        }

        private void btn_suaHD_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "Update CTHD set Magas=@Magas,Dgia=@Dgia,Soluong=@Soluong,Tongtien=@Tongtien," +
                    "Ghichu=@Ghichu,Tratien=@Tratien,Notien=@Notien,Travo=@Travo,Novo=@Novo,Trangthai=@Trangthai where Mahd=@Mahd";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Mahd", SqlDbType.Int).Value = int.Parse(txt_MaHD.Text);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.SelectedValue.ToString());
                cmd.Parameters.Add("@Dgia", SqlDbType.Float).Value = float.Parse(txt_dongia.Text);
                cmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = int.Parse(txt_soluong.Text);
                cmd.Parameters.Add("@Tongtien", SqlDbType.Float).Value = float.Parse(txt_tongtien.Text);
                cmd.Parameters.Add("@Ghichu", SqlDbType.NVarChar).Value = txt_ghichu.Text;
                cmd.Parameters.Add("@Tratien", SqlDbType.Bit).Value = check_tratien.Checked;
                cmd.Parameters.Add("@Notien", SqlDbType.Bit).Value = check_notien.Checked;
                cmd.Parameters.Add("@Travo", SqlDbType.Bit).Value = check_travo.Checked;
                cmd.Parameters.Add("@Novo", SqlDbType.Bit).Value = check_novo.Checked;
                cmd.Parameters.Add("@Trangthai", SqlDbType.Bit).Value = check_trangthai.Checked;
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

        private void btn_xoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "Update CTHD set isDelete=@isDelete Where Mahd = @Mahd";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Mahd", SqlDbType.Int).Value=int.Parse(txt_MaHD.Text);
                cmd.Parameters.Add("@isDelete", SqlDbType.Bit).Value = true;
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

        private void data_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    txt_MaHD.Text = Convert.ToString(data_HD.CurrentRow.Cells["Mahd"].Value);
                    txt_dongia.Text = Convert.ToString(data_HD.CurrentRow.Cells["Dgia"].Value);
                    txt_soluong.Text = Convert.ToString(data_HD.CurrentRow.Cells["Soluong"].Value);
                    txt_tongtien.Text = Convert.ToString(data_HD.CurrentRow.Cells["Tongtien"].Value);
                    txt_ghichu.Text = Convert.ToString(data_HD.CurrentRow.Cells["Ghichu"].Value);
                    cb_Magas.SelectedItem = Convert.ToString(data_HD.CurrentRow.Cells["Magas"].Value);
                    check_notien.Checked = Convert.ToBoolean(data_HD.CurrentRow.Cells["Notien"].Value);
                    check_tratien.Checked = Convert.ToBoolean(data_HD.CurrentRow.Cells["Tratien"].Value);
                    check_novo.Checked = Convert.ToBoolean(data_HD.CurrentRow.Cells["Novo"].Value);
                    check_travo.Checked = Convert.ToBoolean(data_HD.CurrentRow.Cells["Travo"].Value);
                    check_trangthai.Checked = Convert.ToBoolean(data_HD.CurrentRow.Cells["Trangthai"].Value);
                    bool check_isdelete = Convert.ToBoolean(data_HD.CurrentRow.Cells["isDelete"].Value);
                    if (check_isdelete==true)
                    {
                        btn_suaHD.Enabled = false;
                    }
                    else
                    {
                        btn_suaHD.Enabled = true;
                    }

                }
            }
            catch (Exception e2)
            {
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ClearvaLoad();
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            try {
                ondataviewHoaDon();
                ComboMaGas();
            }
            catch(Exception e2)
            {

            }
            
        }

        private void btn_Banhang_Click(object sender, EventArgs e)
        {
            CTHD cthd = new CTHD();
            cthd.ShowDialog();
        }

        private void check_tratien_CheckedChanged(object sender, EventArgs e)
        {
            check_notien.Checked = false;
        }

        private void check_notien_CheckedChanged(object sender, EventArgs e)
        {
            check_tratien.Checked = false;
        }

        private void check_travo_CheckedChanged(object sender, EventArgs e)
        {
            check_novo.Checked = false;
        }

        private void check_novo_CheckedChanged(object sender, EventArgs e)
        {
            check_travo.Checked = false;
        }
    }
}
