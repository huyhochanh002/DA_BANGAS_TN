﻿using System;
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
    public partial class FrmKhachhang : Form
    {
        public FrmKhachhang()
        {
            InitializeComponent();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }
        public Giaodienchinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;


    }
}