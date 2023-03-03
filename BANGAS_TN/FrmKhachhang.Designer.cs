
namespace BANGAS_TN
{
    partial class FrmKhachhang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_Clear = new DevComponents.DotNetBar.ButtonX();
            this.btn_SuaKH = new DevComponents.DotNetBar.ButtonX();
            this.btn_XoaKH = new DevComponents.DotNetBar.ButtonX();
            this.btn_themKH = new DevComponents.DotNetBar.ButtonX();
            this.txt_GhichuKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DiachiKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SdtKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_TenKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Makh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.data_KhachHang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_lichsumua = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btn_lichsumua);
            this.groupPanel1.Controls.Add(this.btn_Clear);
            this.groupPanel1.Controls.Add(this.btn_SuaKH);
            this.groupPanel1.Controls.Add(this.btn_XoaKH);
            this.groupPanel1.Controls.Add(this.btn_themKH);
            this.groupPanel1.Controls.Add(this.txt_GhichuKH);
            this.groupPanel1.Controls.Add(this.txt_DiachiKH);
            this.groupPanel1.Controls.Add(this.txt_SdtKH);
            this.groupPanel1.Controls.Add(this.txt_TenKH);
            this.groupPanel1.Controls.Add(this.txt_Makh);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(946, 198);
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
            this.groupPanel1.Text = "KHÁCH HÀNG";
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Clear.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Clear.Image = global::BANGAS_TN.Properties.Resources.THEM;
            this.btn_Clear.Location = new System.Drawing.Point(734, 129);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(99, 34);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "Làm Mới";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_SuaKH
            // 
            this.btn_SuaKH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SuaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaKH.Image = global::BANGAS_TN.Properties.Resources.SUA;
            this.btn_SuaKH.Location = new System.Drawing.Point(734, 49);
            this.btn_SuaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SuaKH.Name = "btn_SuaKH";
            this.btn_SuaKH.Size = new System.Drawing.Size(99, 34);
            this.btn_SuaKH.TabIndex = 12;
            this.btn_SuaKH.Text = "Sửa";
            this.btn_SuaKH.Click += new System.EventHandler(this.btn_SuaKH_Click);
            // 
            // btn_XoaKH
            // 
            this.btn_XoaKH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_XoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaKH.Image = global::BANGAS_TN.Properties.Resources.XOA;
            this.btn_XoaKH.Location = new System.Drawing.Point(734, 91);
            this.btn_XoaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_XoaKH.Name = "btn_XoaKH";
            this.btn_XoaKH.Size = new System.Drawing.Size(99, 34);
            this.btn_XoaKH.TabIndex = 11;
            this.btn_XoaKH.Text = "Xóa";
            this.btn_XoaKH.Click += new System.EventHandler(this.btn_XoaKH_Click);
            // 
            // btn_themKH
            // 
            this.btn_themKH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_themKH.BackColor = System.Drawing.Color.SeaShell;
            this.btn_themKH.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_themKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_themKH.Image = global::BANGAS_TN.Properties.Resources.THEM;
            this.btn_themKH.Location = new System.Drawing.Point(734, 2);
            this.btn_themKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_themKH.Name = "btn_themKH";
            this.btn_themKH.Size = new System.Drawing.Size(99, 34);
            this.btn_themKH.TabIndex = 10;
            this.btn_themKH.Text = "Thêm";
            this.btn_themKH.Click += new System.EventHandler(this.btn_themKH_Click);
            // 
            // txt_GhichuKH
            // 
            // 
            // 
            // 
            this.txt_GhichuKH.Border.Class = "TextBoxBorder";
            this.txt_GhichuKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GhichuKH.Location = new System.Drawing.Point(468, 14);
            this.txt_GhichuKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_GhichuKH.Name = "txt_GhichuKH";
            this.txt_GhichuKH.Size = new System.Drawing.Size(218, 28);
            this.txt_GhichuKH.TabIndex = 9;
            this.txt_GhichuKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_DiachiKH
            // 
            // 
            // 
            // 
            this.txt_DiachiKH.Border.Class = "TextBoxBorder";
            this.txt_DiachiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiachiKH.Location = new System.Drawing.Point(125, 137);
            this.txt_DiachiKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_DiachiKH.Name = "txt_DiachiKH";
            this.txt_DiachiKH.Size = new System.Drawing.Size(218, 28);
            this.txt_DiachiKH.TabIndex = 8;
            this.txt_DiachiKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_SdtKH
            // 
            // 
            // 
            // 
            this.txt_SdtKH.Border.Class = "TextBoxBorder";
            this.txt_SdtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SdtKH.Location = new System.Drawing.Point(125, 97);
            this.txt_SdtKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_SdtKH.Name = "txt_SdtKH";
            this.txt_SdtKH.Size = new System.Drawing.Size(218, 28);
            this.txt_SdtKH.TabIndex = 7;
            this.txt_SdtKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TenKH
            // 
            // 
            // 
            // 
            this.txt_TenKH.Border.Class = "TextBoxBorder";
            this.txt_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Location = new System.Drawing.Point(125, 55);
            this.txt_TenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(218, 28);
            this.txt_TenKH.TabIndex = 6;
            this.txt_TenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Makh
            // 
            // 
            // 
            // 
            this.txt_Makh.Border.Class = "TextBoxBorder";
            this.txt_Makh.Enabled = false;
            this.txt_Makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Makh.Location = new System.Drawing.Point(125, 14);
            this.txt_Makh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Makh.Name = "txt_Makh";
            this.txt_Makh.Size = new System.Drawing.Size(218, 28);
            this.txt_Makh.TabIndex = 5;
            this.txt_Makh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(28, 65);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(82, 19);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Tên KH";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(28, 106);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(82, 19);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Điện Thoại";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(28, 147);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(82, 19);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Địa Chỉ";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(369, 24);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(82, 19);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Ghi Chú";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(28, 24);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(82, 19);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã KH";
            // 
            // data_KhachHang
            // 
            this.data_KhachHang.AllowUserToAddRows = false;
            this.data_KhachHang.AllowUserToDeleteRows = false;
            this.data_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_KhachHang.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.data_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_KhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_KhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.data_KhachHang.Location = new System.Drawing.Point(0, 198);
            this.data_KhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_KhachHang.Name = "data_KhachHang";
            this.data_KhachHang.ReadOnly = true;
            this.data_KhachHang.RowHeadersWidth = 51;
            this.data_KhachHang.RowTemplate.Height = 24;
            this.data_KhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_KhachHang.Size = new System.Drawing.Size(946, 349);
            this.data_KhachHang.TabIndex = 1;
            this.data_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_KhachHang_CellClick);
            // 
            // btn_lichsumua
            // 
            this.btn_lichsumua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_lichsumua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lichsumua.Image = global::BANGAS_TN.Properties.Resources.ql;
            this.btn_lichsumua.Location = new System.Drawing.Point(369, 55);
            this.btn_lichsumua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_lichsumua.Name = "btn_lichsumua";
            this.btn_lichsumua.Size = new System.Drawing.Size(159, 40);
            this.btn_lichsumua.TabIndex = 55;
            this.btn_lichsumua.Text = "Lịch sử mua";
            this.btn_lichsumua.Click += new System.EventHandler(this.btn_lichsumua_Click);
            // 
            // FrmKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.data_KhachHang);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmKhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmKhachhang";
            this.Load += new System.EventHandler(this.FrmKhachhang_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_KhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX data_KhachHang;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Makh;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_GhichuKH;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_DiachiKH;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SdtKH;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TenKH;
        private DevComponents.DotNetBar.ButtonX btn_SuaKH;
        private DevComponents.DotNetBar.ButtonX btn_XoaKH;
        private DevComponents.DotNetBar.ButtonX btn_themKH;
        private DevComponents.DotNetBar.ButtonX btn_Clear;
        private DevComponents.DotNetBar.ButtonX btn_lichsumua;
    }
}