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
    public partial class FrmXemHD : Form
    {
        int laymakh;
        public FrmXemHD(int makh)
        {
            laymakh = makh;
            InitializeComponent();
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

        public void ondataviewLichsu()
        {
            try
            {
                Runnow();
                string s = "select * from CTHD LEFT JOIN HoaDon on CTHD.Mahd = HoaDon.Mahd where Makh="+laymakh;
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_lichsumua.DataSource = bin;
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu Chi Tiết Hóa Đơn ! ");
            }
        }

        private void data_lichsumua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                  
                    txt_Mahd.Text = Convert.ToString(data_lichsumua.CurrentRow.Cells["Mahd"].Value);
                    txt_Dongia.Text = Convert.ToString(data_lichsumua.CurrentRow.Cells["Dgia"].Value);
                    txt_Soluong.Text = Convert.ToString(data_lichsumua.CurrentRow.Cells["Soluong"].Value);

                    txt_tongtien.Text = Convert.ToString(data_lichsumua.CurrentRow.Cells["Tongtien"].Value);
                    txt_ghichu.Text = Convert.ToString(data_lichsumua.CurrentRow.Cells["Ghichu"].Value);
                    txt_Magas.Text = Convert.ToString(data_lichsumua.CurrentRow.Cells["Magas"].Value);
                    check_notien.Checked = Convert.ToBoolean(data_lichsumua.CurrentRow.Cells["Notien"].Value);
                    check_tratien.Checked = Convert.ToBoolean(data_lichsumua.CurrentRow.Cells["Tratien"].Value);
                    check_novo.Checked = Convert.ToBoolean(data_lichsumua.CurrentRow.Cells["Novo"].Value);
                    check_travo.Checked = Convert.ToBoolean(data_lichsumua.CurrentRow.Cells["Travo"].Value);
                    txt_ngaythang.Text = Convert.ToString(data_lichsumua.CurrentRow.Cells["NgaylapHD"].Value);

                    
                    bool check = Convert.ToBoolean(data_lichsumua.CurrentRow.Cells["isDelete"].Value);
             
                    txt_Makh.Text = Convert.ToString(data_lichsumua.CurrentRow.Cells["Makh"].Value);
                    txt_Manv.Text = Convert.ToString(data_lichsumua.CurrentRow.Cells["Manv"].Value);
                    lb_delete.Text = "Hóa đơn này còn tồn tại!";
                    if(check==true)
                    {
                        lb_delete.Text = "Hóa đơn này đã bị xóa !";
                    }

                }
            }
            catch (Exception e2)
            {

            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void FrmXemHD_Load(object sender, EventArgs e)
        {
            try
            {
                ondataviewLichsu();
            }catch(Exception e2)
            {

            }
        }
    }
}
