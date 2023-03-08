using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BANGAS_TN
{
    public partial class Giaodienchinh : Form
    {
        public Giaodienchinh()
        {
            InitializeComponent();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        #region Kiem Tra Tab
        bool trangThai = false;
        private String tentabmo;
        private bool Kiemtramotab(string name)
        {
            for (int i = 0; i < tab_main.Tabs.Count; i++)
            {
                if (tab_main.Tabs[i].Text == name)
                {
                    tab_main.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }
        private void DongTab()
        {
            foreach (TabItem item in tab_main.Tabs)
            {
                if (item.IsSelected == true)
                {
                    tab_main.Tabs.Remove(item);
                    return;
                }
            }
        }
        #endregion
        public Giaodienchinh frm;
        public delegate void _dongTap();
        private void btnKH_Click(object sender, EventArgs e)
        {
            try
            {
                this.trangThai = true;
                this.tentabmo = "Khách Hàng";
                if (!Kiemtramotab(tentabmo))
                {
                    TabItem t = tab_main.CreateTab(tentabmo);
                    t.Name = "KhachHang";

                    FrmKhachhang KH = new FrmKhachhang()
                    {
                        DongTap = new FrmKhachhang._dongTap(DongTab),
                        frm = this,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                    };
                    t.AttachedControl.Controls.Add(KH);
                    KH.Show();
                    tab_main.SelectedTabIndex = tab_main.Tabs.Count - 1;
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Mở Tab Khách Hàng !");
            }

        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            try
            {
                this.trangThai = true;
                this.tentabmo = "Nhân Viên";
                if (!Kiemtramotab(tentabmo))
                {
                    TabItem t = tab_main.CreateTab(tentabmo);
                    t.Name = "NhanVien";

                    FrmNhanvien NV = new FrmNhanvien()
                    {
                        DongTap = new FrmNhanvien._dongTap(DongTab),
                        frm = this,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                    };
                    t.AttachedControl.Controls.Add(NV);
                    NV.Show();
                    tab_main.SelectedTabIndex = tab_main.Tabs.Count - 1;
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Mở Tab Nhân Viên !");
            }
        }

        public void btnGas_Click(object sender, EventArgs e)
        {
            try
            {
                this.trangThai = true;
                this.tentabmo = "GAS";
                if (!Kiemtramotab(tentabmo))
                {
                    TabItem t = tab_main.CreateTab(tentabmo);
                    t.Name = "GAS";

                    FrmGas gas = new FrmGas()
                    {
                        DongTap = new FrmGas._dongTap(DongTab),
                        frm = this,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                    };
                    t.AttachedControl.Controls.Add(gas);
                    gas.Show();
                    tab_main.SelectedTabIndex = tab_main.Tabs.Count - 1;
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Mở Tab Gas !");
            }

        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            try
            {
                this.trangThai = true;
                this.tentabmo = "Nhà cung cấp";
                if (!Kiemtramotab(tentabmo))
                {
                    TabItem t = tab_main.CreateTab(tentabmo);
                    t.Name = "Nhacungcap";

                    FrmNCC NCC = new FrmNCC()
                    {
                        DongTap = new FrmNCC._dongTap(DongTab),
                        frm = this,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                    };
                    t.AttachedControl.Controls.Add(NCC);
                    NCC.Show();
                    tab_main.SelectedTabIndex = tab_main.Tabs.Count - 1;
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Mở Tab Nhà cung cấp !");
            }
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            try
            {
                this.trangThai = true;
                this.tentabmo = "Loại Gas";
                if (!Kiemtramotab(tentabmo))
                {
                    TabItem t = tab_main.CreateTab(tentabmo);
                    t.Name = "LoaiGas";

                    FrmLoaiGas Lgas = new FrmLoaiGas()
                    {
                        DongTap = new FrmLoaiGas._dongTap(DongTab),
                        frm = this,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                    };
                    t.AttachedControl.Controls.Add(Lgas);
                    Lgas.Show();
                    tab_main.SelectedTabIndex = tab_main.Tabs.Count - 1;
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Mở Tab Loại Gas !");
            }
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            try
            {
                this.trangThai = true;
                this.tentabmo = "CTHD";
                if (!Kiemtramotab(tentabmo))
                {
                    TabItem t = tab_main.CreateTab(tentabmo);
                    t.Name = "CTHD";

                    FrmHoaDon hd = new FrmHoaDon()
                    {
                        DongTap = new FrmHoaDon._dongTap(DongTab),
                        frm = this,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                    };
                    t.AttachedControl.Controls.Add(hd);
                    hd.Show();
                    tab_main.SelectedTabIndex = tab_main.Tabs.Count - 1;
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Mở Tab Hóa Đơn !");
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                this.trangThai = true;
                this.tentabmo = "Backup";
                if (!Kiemtramotab(tentabmo))
                {
                    TabItem t = tab_main.CreateTab(tentabmo);
                    t.Name = "Backup";

                    FrmBackup ba = new FrmBackup()
                    {
                        DongTap = new FrmBackup._dongTap(DongTab),
                        frm = this,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                    };
                    t.AttachedControl.Controls.Add(ba);
                    ba.Show();
                    tab_main.SelectedTabIndex = tab_main.Tabs.Count - 1;
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Mở Tab Backup !");
            }
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            try
            {
                this.trangThai = true;
                this.tentabmo = "Phiếu Nhập";
                if (!Kiemtramotab(tentabmo))
                {
                    TabItem t = tab_main.CreateTab(tentabmo);
                    t.Name = "PhieuNhap";

                    FrmPN ba = new FrmPN()
                    {
                        DongTap = new FrmPN._dongTap(DongTab),
                        frm = this,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                    };
                    t.AttachedControl.Controls.Add(ba);
                    ba.Show();
                    tab_main.SelectedTabIndex = tab_main.Tabs.Count - 1;
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Mở Tab Phiếu nhập !");
            }
        }
    }
}
