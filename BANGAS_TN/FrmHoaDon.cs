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
        // COMBOBOX 
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
        public void ComboKhachhang()
        {
            Runnow();
            SqlCommand cmd = new SqlCommand("select * from KhachHang", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            cnn.Close();
            cb_khach.DataSource = null;
            cb_khach.DataSource = ds.Tables[0];
            cb_khach.DisplayMember = "Tenkh";
            cb_khach.ValueMember = "Makh";

        }
        public void ComboNhanVien()
        {
            Runnow();
            SqlCommand cmd = new SqlCommand("select * from NhanVien", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            cnn.Close();
            cb_nhanvien.DataSource = null;
            cb_nhanvien.DataSource = ds.Tables[0];
            cb_nhanvien.DisplayMember = "Tennv";
            cb_nhanvien.ValueMember = "Manv";

        }

        // On view data lên list
        public void ondataviewHoaDon()
        {
            try
            {
                Runnow();
                string s = "select * from CTHD LEFT JOIN HoaDon on CTHD.Mahd = HoaDon.Mahd";
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_HD.DataSource = bin;
                btn_suaHD.Enabled = false;
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
            check_notien.Checked = false;
            check_tratien.Checked = false;
            check_novo.Checked = false;
            check_travo.Checked = false;
            check_trangthai.Checked = false;
            check_isDelete.Checked = false;
            txt_ngaythang.Text = "";
            lb_delete.Text = ". . .";
            txt_timkiem.Text = "";
            ComboMaGas();
            ComboKhachhang();
            ComboNhanVien();
            dt.Clear();
            ondataviewHoaDon();
            btn_suaHD.Enabled = false;

            // refresh Ngày lọc 
            txt_ngay.Text = "";
            txt_nam.Text = "";
            txt_thang.Text = "";
            txt_ngay1.Text = "";
            txt_nam1.Text = "";
            txt_thang1.Text = "";
        }

        // BIẾN GAS THU HỒI 
        int soluonggasthuhoi = 0;
        private void btn_suaHD_Click(object sender, EventArgs e)
        {
            //UPDATE LẠI SỐ LƯỢNG TỒN
            try
            {

                Runnow();
                string s = "Select MAX(Slton) From Gas where Magas = @Magas";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.SelectedValue.ToString());
                int sltonkho = (int)cmd.ExecuteScalar();
                int tonggasthu = sltonkho + soluonggasthuhoi;
                cnn.Close();

                // Kiểm tra đủ sl để bán không
                int soluongmua = int.Parse(txt_soluong.Text);
                if (tonggasthu < soluongmua)
                {
                    MessageBox.Show("Không đủ gas để bán ");
                    return;
                }
                else
                {
                    // UPDATE LẠI GAS ĐÃ THU 
                    Runnow();
                    s = "Update Gas set Slton =" + tonggasthu + " where Magas = @Magas ";
                    cmd = new SqlCommand(s, cnn);
                    cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    cnn.Close();

                    //Bán gas
                    Runnow();
                    s = "Update Gas set Slton =" + (tonggasthu - soluongmua) + " where Magas = @Magas ";
                    cmd = new SqlCommand(s, cnn);
                    cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }

            }
            catch (Exception e3)
            {
                cnn.Close();
            }
            //UPDATE LẠI BÊN HÓA ĐƠN
            try
            {
                Runnow();
                string s = "Update HoaDon set Manv=@Manv,Makh=@Makh Where Mahd=@Mahd ";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Mahd", SqlDbType.Int).Value = int.Parse(txt_MaHD.Text);
                cmd.Parameters.Add("@Manv", SqlDbType.Int).Value = int.Parse(cb_nhanvien.SelectedValue.ToString());
                cmd.Parameters.Add("@Makh", SqlDbType.Int).Value = int.Parse(cb_khach.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
            }
            
            //UPDATE BÊN CHI TIẾT HÓA ĐƠN
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
                cmd.Parameters.Add("@Mahd", SqlDbType.Int).Value = int.Parse(txt_MaHD.Text);
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
                    btn_suaHD.Enabled = true;
                    txt_MaHD.Text = Convert.ToString(data_HD.CurrentRow.Cells["Mahd"].Value);
                    txt_dongia.Text = Convert.ToString(data_HD.CurrentRow.Cells["Dgia"].Value);
                    txt_soluong.Text = Convert.ToString(data_HD.CurrentRow.Cells["Soluong"].Value);
                    // lấy số lượng gas
                    soluonggasthuhoi =int.Parse(Convert.ToString(data_HD.CurrentRow.Cells["Soluong"].Value)) ;
                    //--------
                    txt_tongtien.Text = Convert.ToString(data_HD.CurrentRow.Cells["Tongtien"].Value);
                    txt_ghichu.Text = Convert.ToString(data_HD.CurrentRow.Cells["Ghichu"].Value);
                    cb_Magas.SelectedValue = Convert.ToString(data_HD.CurrentRow.Cells["Magas"].Value);
                    check_notien.Checked = Convert.ToBoolean(data_HD.CurrentRow.Cells["Notien"].Value);
                    check_tratien.Checked = Convert.ToBoolean(data_HD.CurrentRow.Cells["Tratien"].Value);
                    check_novo.Checked = Convert.ToBoolean(data_HD.CurrentRow.Cells["Novo"].Value);
                    check_travo.Checked = Convert.ToBoolean(data_HD.CurrentRow.Cells["Travo"].Value);
                    check_trangthai.Checked = Convert.ToBoolean(data_HD.CurrentRow.Cells["Trangthai"].Value);
                    check_isDelete.Checked =  Convert.ToBoolean(data_HD.CurrentRow.Cells["isDelete"].Value);
                    txt_ngaythang.Text= Convert.ToString(data_HD.CurrentRow.Cells["NgaylapHD"].Value);
                    // MÓC TỪ BẢN KHÁC
                    cb_khach.SelectedValue = Convert.ToString(data_HD.CurrentRow.Cells["Makh"].Value);
                    cb_nhanvien.SelectedValue = Convert.ToString(data_HD.CurrentRow.Cells["Manv"].Value);
                    lb_delete.Text = "Hóa đơn này còn tồn tại!";

                    if (check_isDelete.Checked == true)
                    {
                        btn_suaHD.Enabled = false;
                        lb_delete.Text = "Hóa đơn này đã bị xóa!";
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
            try
            {
                ondataviewHoaDon();
                ComboMaGas();
                ComboKhachhang();
                ComboNhanVien();
               
                
            }
            catch (Exception e2)
            {

            }

        }

        private void btn_Banhang_Click(object sender, EventArgs e)
        {
            CTHD cthd = new CTHD();
            cthd.ShowDialog();
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
        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
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


        // Khi các giá trị số lượng thay đổi
        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            try
            {

                int sl = int.Parse(txt_soluong.Text);
                txt_tongtien.Text = (sl * (int.Parse(txt_dongia.Text)*1000)).ToString();
            }
            catch (Exception e2)
            {

            }
        }


        // Khi mã gas thay đổi
        private void cb_Magas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Magas_SelectedValueChanged(object sender, EventArgs e)
        {
         
        }

        private void cb_Magas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "Select MAX(Dgia) From Gas where Magas=@Magas";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@Magas", SqlDbType.Int).Value = int.Parse(cb_Magas.SelectedValue.ToString());
                Double dgia =Convert.ToDouble(cmd.ExecuteScalar());
                txt_tongtien.Text = ((dgia * 1000)*int.Parse(txt_soluong.Text)).ToString();
                txt_dongia.Text=dgia.ToString();
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
            }
        }
        // CHỨC NĂNG TÌM KIẾM
        private void txt_timkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    DataView dv = new DataView(dt);
                    string value = "CONVERT(Makh, System.String) LIKE '%{0}%'";

                    dv.RowFilter = string.Format(value, txt_timkiem.Text);
                    data_HD.DataSource = dv;

                }
                catch (Exception e2)
                {
                    ClearvaLoad();
                }
            }
        }

        private void btn_locngay_Click(object sender, EventArgs e)
        {
            try
            {
               if (txt_nam1.Text == "" || txt_ngay1.Text == "" || txt_thang1.Text == ""){
                    Runnow();
                    string s = "Select *  From CTHD LEFT JOIN HoaDon on CTHD.Mahd = HoaDon.Mahd Where (NgaylapHD>=" + "'" + txt_nam.Text + "-" + txt_thang.Text + "-" + txt_ngay.Text + " 00:00:00.000" + "'"
                        + " )and " + "(NgaylapHD <= " + "'" + txt_nam.Text + "-" + txt_thang.Text + "-" + txt_ngay.Text + " 23:59:59.999" + "'"
                        + " )";
                    SqlCommand cmd = new SqlCommand(s, cnn);
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    bin.DataSource = dt;
                    data_HD.DataSource = bin;
                    cnn.Close();
                }
                else
                {
                    Runnow();
                    string s1 = "Select *  From CTHD LEFT JOIN HoaDon on CTHD.Mahd = HoaDon.Mahd Where (NgaylapHD>=" + "'" + txt_nam.Text + "-" + txt_thang.Text + "-" + txt_ngay.Text + " 00:00:00.00" + "'"
                        + " )and " + "(NgaylapHD <= " + "'" + txt_nam1.Text + "-" + txt_thang1.Text + "-" + txt_ngay1.Text + " 23:59:59.999" + "'"
                        + " )";
                    SqlCommand cmd1 = new SqlCommand(s1, cnn);
                    da.SelectCommand = cmd1;
                    dt.Clear();
                    da.Fill(dt);
                    bin.DataSource = dt;
                    data_HD.DataSource = bin;
                    cnn.Close();
                }
            }
            catch(Exception e2)
            {
                cnn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
