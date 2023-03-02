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
    public partial class CTHD : Form
    {
        public CTHD()
        {
            InitializeComponent();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtNameKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void CTHD_Load(object sender, EventArgs e)
        {
            try
            {
                ondataviewGas();
                ondataviewKH();
                ondataviewNV();
            }
            catch (Exception e2)
            {

            }
        }
        public Giaodienchinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
        // Khai báo các biến cần thiết;
        Khaibao kb = new Khaibao();

        SqlConnection cnn = new SqlConnection();

        // Biến Khách hàng
        SqlDataAdapter daKH = new SqlDataAdapter();
        DataTable dtKH = new DataTable();
        BindingSource binKH = new BindingSource();

        // Biến Nhân Viên
        SqlDataAdapter daNV = new SqlDataAdapter();
        DataTable dtNV = new DataTable();
        BindingSource binNV = new BindingSource();
        // Biến Gas
        SqlDataAdapter daGAS = new SqlDataAdapter();
        DataTable dtGAS = new DataTable();
        BindingSource binGAS = new BindingSource();

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

        // CÁI HÀM NÀY SẼ CLEAR MẤY Ô KHI THÊM VÀ ĐỒNG THỜI LOAD LẠI LIST DỮ LIỆU
        public void ClearvaLoad()
        {
            txt_Magas.Text = "";
            txt_Makh.Text = "";
            txt_Manv.Text = "";
            txt_Dgia.Text = "";
            txt_ghichu.Text = "";
            txt_Soluong.Text = "";
            txt_Tongtien.Text = "";
            check_notien.Checked = false;
            check_tratien.Checked = false;
            check_novo.Checked = false;
            check_travo.Checked = false;
            check_trangthai.Checked = false;
            dtKH.Clear();
            daKH.Fill(dtKH);
            dtNV.Clear();
            daNV.Fill(dtNV);
            dtGAS.Clear();
            daGAS.Fill(dtGAS);

        }
        // On view data lên list
        public void ondataviewKH()
        {
            try
            {
                Runnow();
                string s = "Select * From KhachHang";
                SqlCommand cmd = new SqlCommand(s, cnn);
                daKH.SelectCommand = cmd;
                daKH.Fill(dtKH);
                binKH.DataSource = dtKH;
                data_khachang.DataSource = binKH;
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu Khách Hàng ! ");
            }
        }
        public void ondataviewNV()
        {
            try
            {
                Runnow();
                string s = "Select * From NhanVien";
                SqlCommand cmd = new SqlCommand(s, cnn);
                daNV.SelectCommand = cmd;
                daNV.Fill(dtNV);
                binNV.DataSource = dtNV;
                data_nhanvien.DataSource = binNV;
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu Nhân Viên ! ");
            }
        }
        public void ondataviewGas()
        {
            try
            {
                Runnow();
                string s = "Select * From Gas";
                SqlCommand cmd = new SqlCommand(s, cnn);
                daGAS.SelectCommand = cmd;
                daGAS.Fill(dtGAS);
                binGAS.DataSource = dtGAS;
                data_gas.DataSource = binGAS;
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu GAS ! ");
            }
        }
        /// <summary>
        /// Biến lấy số hóa đơn ( KHI NHẤN BÁN HÀNG )
        /// </summary>
        int laysohoaodnmoi;
        private void btn_banhang_Click(object sender, EventArgs e)
        {
            // cập nhật số tồn của gas
            try
            {

                Runnow();
                string s = "Select MAX(Slton) From Gas where Magas = @Magas";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(txt_Magas.Text);
                int sltonkho = (int)cmd.ExecuteScalar();
                cnn.Close();
                // Kiểm tra đủ sl để bán không
                int soluongmua = int.Parse(txt_Soluong.Text);
                if (sltonkho < soluongmua)
                {
                    MessageBox.Show("Không đủ gas để bán ");
                    return;
                }
                else
                {
                    Runnow();
                    s = "Update Gas set Slton =" + (sltonkho - soluongmua) + " where Magas = @Magas ";
                    cmd = new SqlCommand(s, cnn);
                    cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(txt_Magas.Text);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }

            }
            catch (Exception e3)
            {
                cnn.Close();
            }

            // ADD HÓA ĐƠN
            try
            {
                Runnow();
                string s = "insert into HoaDon (Manv,Makh,NgaylapHD) values " +
                    "(@Manv,@Makh,@NgaylapHD)";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Manv", SqlDbType.Int).Value = int.Parse(txt_Manv.Text);
                cmd.Parameters.Add("@Makh", SqlDbType.Int).Value = int.Parse(txt_Makh.Text);
                cmd.Parameters.Add("@NgaylapHD", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.ExecuteNonQuery();
                cnn.Close();
                //lấy số hóa đơn mới
                Runnow();
                s = "Select MAX(Mahd) From Hoadon";
                cmd = new SqlCommand(s, cnn);
                laysohoaodnmoi = (int)cmd.ExecuteScalar();
                cnn.Close();


            }
            catch (Exception e2)
            {
                cnn.Close();
            }

            //ADD CHI TIẾT HÓA ĐƠN
            try
            {
                Runnow();
                string s = "insert into CTHD (Mahd,Magas,Dgia,Soluong,Tongtien,Ghichu,Tratien,Notien,Travo,Novo,Trangthai,isDelete) values " +
                    "(@Mahd,@Magas,@Dgia,@Soluong,@Tongtien,@Ghichu,@Tratien,@Notien,@Travo,@Novo,@Trangthai,@isDelete)";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Mahd", SqlDbType.Int).Value = laysohoaodnmoi;
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(txt_Magas.Text);
                cmd.Parameters.Add("@Dgia", SqlDbType.Float).Value = float.Parse(txt_Dgia.Text);
                cmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = int.Parse(txt_Soluong.Text);
                cmd.Parameters.Add("@Tongtien", SqlDbType.Float).Value = float.Parse(txt_Tongtien.Text);
                cmd.Parameters.Add("@Ghichu", SqlDbType.NVarChar).Value = txt_ghichu.Text;
                cmd.Parameters.Add("@Tratien", SqlDbType.Bit).Value = check_tratien.Checked;
                cmd.Parameters.Add("@Notien", SqlDbType.Bit).Value = check_notien.Checked;
                cmd.Parameters.Add("@Travo", SqlDbType.Bit).Value = check_travo.Checked;
                cmd.Parameters.Add("@Novo", SqlDbType.Bit).Value = check_novo.Checked;
                cmd.Parameters.Add("@Trangthai", SqlDbType.Bit).Value = check_trangthai.Checked;
                cmd.Parameters.Add("@isDelete", SqlDbType.Bit).Value = false;
                cmd.ExecuteNonQuery();
                cnn.Close();
                ClearvaLoad();
                MessageBox.Show("Thêm Thành Công");
                this.Close();

            }
            catch (Exception e4)
            {
                cnn.Close();
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Dữ Liệu nhập ! ");
            }
        }

        private void data_khachang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txt_Makh.Text = Convert.ToString(data_khachang.CurrentRow.Cells["Makh"].Value);

                }
            }
            catch (Exception e2)
            {
            }
        }

        private void data_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txt_Manv.Text = Convert.ToString(data_nhanvien.CurrentRow.Cells["Manv"].Value);

                }
            }
            catch (Exception e2)
            {
            }
        }

        private void data_gas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    double thanhtien = 0;
                    txt_Magas.Text = Convert.ToString(data_gas.CurrentRow.Cells["Magas"].Value);
                    txt_Dgia.Text = Convert.ToString(data_gas.CurrentRow.Cells["Dgia"].Value);
                    txt_Soluong.Text = "1";
                    thanhtien = 1000 * double.Parse(txt_Dgia.Text);
                    txt_Tongtien.Text = thanhtien.ToString();


                }
            }
            catch (Exception e2)
            {
            }
        }

        private void txt_Soluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Tongtien.Text = (int.Parse(txt_Soluong.Text) * (1000 * float.Parse(txt_Dgia.Text))).ToString();

            }
            catch (Exception e2)
            {

            }
        }


        // các nút check
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


        // chỉ cho nhập số 
        private void txt_Dgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_Soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ClearvaLoad();
        }
    }
}
