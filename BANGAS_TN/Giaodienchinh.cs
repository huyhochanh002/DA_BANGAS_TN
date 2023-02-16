﻿using DevComponents.DotNetBar;
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

        private void btnGas_Click(object sender, EventArgs e)
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
    }
}
