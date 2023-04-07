
namespace BANGAS_TN
{
    partial class FrmPN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_Them = new DevComponents.DotNetBar.ButtonX();
            this.btn_lammoi = new DevComponents.DotNetBar.ButtonX();
            this.btn_xoaPN = new DevComponents.DotNetBar.ButtonX();
            this.btn_suaPN = new DevComponents.DotNetBar.ButtonX();
            this.cb_daili = new System.Windows.Forms.ComboBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_sl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_ngaythang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cb_Magas = new System.Windows.Forms.ComboBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txt_MaPN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.data_PN = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cb_LoaiGas = new System.Windows.Forms.ComboBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_PN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btn_Them);
            this.groupPanel1.Controls.Add(this.cb_LoaiGas);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.btn_lammoi);
            this.groupPanel1.Controls.Add(this.btn_xoaPN);
            this.groupPanel1.Controls.Add(this.btn_suaPN);
            this.groupPanel1.Controls.Add(this.cb_daili);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_sl);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txt_ngaythang);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.cb_Magas);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.txt_MaPN);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(876, 196);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "PHIẾU NHẬP";
            // 
            // btn_Them
            // 
            this.btn_Them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Them.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Them.Image = global::BANGAS_TN.Properties.Resources.THEM;
            this.btn_Them.Location = new System.Drawing.Point(422, 123);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(101, 44);
            this.btn_Them.TabIndex = 73;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Image = global::BANGAS_TN.Properties.Resources.THEM;
            this.btn_lammoi.Location = new System.Drawing.Point(762, 123);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(103, 44);
            this.btn_lammoi.TabIndex = 72;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_xoaPN
            // 
            this.btn_xoaPN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaPN.Image = global::BANGAS_TN.Properties.Resources.XOA;
            this.btn_xoaPN.Location = new System.Drawing.Point(649, 123);
            this.btn_xoaPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xoaPN.Name = "btn_xoaPN";
            this.btn_xoaPN.Size = new System.Drawing.Size(103, 44);
            this.btn_xoaPN.TabIndex = 71;
            this.btn_xoaPN.Text = "Xóa";
            this.btn_xoaPN.Click += new System.EventHandler(this.btn_xoaPN_Click);
            // 
            // btn_suaPN
            // 
            this.btn_suaPN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_suaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suaPN.Image = global::BANGAS_TN.Properties.Resources.SUA;
            this.btn_suaPN.Location = new System.Drawing.Point(535, 123);
            this.btn_suaPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_suaPN.Name = "btn_suaPN";
            this.btn_suaPN.Size = new System.Drawing.Size(103, 44);
            this.btn_suaPN.TabIndex = 70;
            this.btn_suaPN.Text = "Sửa";
            this.btn_suaPN.Click += new System.EventHandler(this.btn_suaPN_Click);
            // 
            // cb_daili
            // 
            this.cb_daili.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_daili.FormattingEnabled = true;
            this.cb_daili.Location = new System.Drawing.Point(333, 72);
            this.cb_daili.Name = "cb_daili";
            this.cb_daili.Size = new System.Drawing.Size(125, 28);
            this.cb_daili.TabIndex = 38;
            this.cb_daili.SelectedIndexChanged += new System.EventHandler(this.cb_daili_SelectedIndexChanged);
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(243, 72);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(76, 26);
            this.labelX4.TabIndex = 37;
            this.labelX4.Text = "Tên đại lí";
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(108, 72);
            this.txt_sl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(124, 26);
            this.txt_sl.TabIndex = 36;
            this.txt_sl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sl_KeyPress);
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(20, 72);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(76, 26);
            this.labelX3.TabIndex = 35;
            this.labelX3.Text = "Số lượng";
            // 
            // txt_ngaythang
            // 
            this.txt_ngaythang.Enabled = false;
            this.txt_ngaythang.Location = new System.Drawing.Point(108, 111);
            this.txt_ngaythang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ngaythang.Name = "txt_ngaythang";
            this.txt_ngaythang.Size = new System.Drawing.Size(124, 26);
            this.txt_ngaythang.TabIndex = 34;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(20, 111);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(76, 26);
            this.labelX2.TabIndex = 33;
            this.labelX2.Text = "Ngày tháng";
            // 
            // cb_Magas
            // 
            this.cb_Magas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Magas.FormattingEnabled = true;
            this.cb_Magas.Location = new System.Drawing.Point(333, 32);
            this.cb_Magas.Name = "cb_Magas";
            this.cb_Magas.Size = new System.Drawing.Size(125, 28);
            this.cb_Magas.TabIndex = 32;
            // 
            // labelX6
            // 
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(243, 32);
            this.labelX6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(76, 26);
            this.labelX6.TabIndex = 31;
            this.labelX6.Text = "Mã Gas";
            // 
            // txt_MaPN
            // 
            this.txt_MaPN.Enabled = false;
            this.txt_MaPN.Location = new System.Drawing.Point(108, 31);
            this.txt_MaPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MaPN.Name = "txt_MaPN";
            this.txt_MaPN.Size = new System.Drawing.Size(124, 26);
            this.txt_MaPN.TabIndex = 30;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(20, 31);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(76, 26);
            this.labelX1.TabIndex = 29;
            this.labelX1.Text = "Mã PN";
            // 
            // data_PN
            // 
            this.data_PN.AllowUserToAddRows = false;
            this.data_PN.AllowUserToDeleteRows = false;
            this.data_PN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_PN.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.data_PN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_PN.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_PN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_PN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.data_PN.Location = new System.Drawing.Point(0, 196);
            this.data_PN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_PN.Name = "data_PN";
            this.data_PN.ReadOnly = true;
            this.data_PN.RowHeadersWidth = 51;
            this.data_PN.RowTemplate.Height = 24;
            this.data_PN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_PN.Size = new System.Drawing.Size(876, 246);
            this.data_PN.TabIndex = 1;
            this.data_PN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_PN_CellClick);
            // 
            // cb_LoaiGas
            // 
            this.cb_LoaiGas.Enabled = false;
            this.cb_LoaiGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiGas.FormattingEnabled = true;
            this.cb_LoaiGas.Location = new System.Drawing.Point(571, 25);
            this.cb_LoaiGas.Name = "cb_LoaiGas";
            this.cb_LoaiGas.Size = new System.Drawing.Size(263, 28);
            this.cb_LoaiGas.TabIndex = 51;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(473, 34);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(82, 19);
            this.labelX5.TabIndex = 50;
            this.labelX5.Text = "Tên Loại";
            // 
            // FrmPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 442);
            this.Controls.Add(this.data_PN);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPN";
            this.Load += new System.EventHandler(this.FrmPN_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_PN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.ComboBox cb_Magas;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_MaPN;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sl;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ngaythang;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ComboBox cb_daili;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.DataGridViewX data_PN;
        private DevComponents.DotNetBar.ButtonX btn_lammoi;
        private DevComponents.DotNetBar.ButtonX btn_xoaPN;
        private DevComponents.DotNetBar.ButtonX btn_suaPN;
        private DevComponents.DotNetBar.ButtonX btn_Them;
        private System.Windows.Forms.ComboBox cb_LoaiGas;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}