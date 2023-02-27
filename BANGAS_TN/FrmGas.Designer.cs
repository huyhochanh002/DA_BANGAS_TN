
namespace BANGAS_TN
{
    partial class FrmGas
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
            this.btn_Clear = new DevComponents.DotNetBar.ButtonX();
            this.cb_Ncc = new System.Windows.Forms.ComboBox();
            this.cb_LoaiGas = new System.Windows.Forms.ComboBox();
            this.txt_SltonGAS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btn_SuaGAS = new DevComponents.DotNetBar.ButtonX();
            this.btn_XoaGAS = new DevComponents.DotNetBar.ButtonX();
            this.btn_ThemGAS = new DevComponents.DotNetBar.ButtonX();
            this.txt_SizeGAS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DgiaGAS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_MagasGAS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.data_Gas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Gas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btn_Clear);
            this.groupPanel1.Controls.Add(this.cb_Ncc);
            this.groupPanel1.Controls.Add(this.cb_LoaiGas);
            this.groupPanel1.Controls.Add(this.txt_SltonGAS);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.btn_SuaGAS);
            this.groupPanel1.Controls.Add(this.btn_XoaGAS);
            this.groupPanel1.Controls.Add(this.btn_ThemGAS);
            this.groupPanel1.Controls.Add(this.txt_SizeGAS);
            this.groupPanel1.Controls.Add(this.txt_DgiaGAS);
            this.groupPanel1.Controls.Add(this.txt_MagasGAS);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1261, 244);
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
            this.groupPanel1.Text = "Gas";
            this.groupPanel1.Click += new System.EventHandler(this.v);
            // 
            // btn_Clear
            // 
            this.btn_Clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Clear.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Clear.Image = global::BANGAS_TN.Properties.Resources.THEM;
            this.btn_Clear.Location = new System.Drawing.Point(943, 175);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(132, 42);
            this.btn_Clear.TabIndex = 45;
            this.btn_Clear.Text = "Làm Mới";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // cb_Ncc
            // 
            this.cb_Ncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Ncc.FormattingEnabled = true;
            this.cb_Ncc.Location = new System.Drawing.Point(161, 119);
            this.cb_Ncc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Ncc.Name = "cb_Ncc";
            this.cb_Ncc.Size = new System.Drawing.Size(289, 33);
            this.cb_Ncc.TabIndex = 44;
            // 
            // cb_LoaiGas
            // 
            this.cb_LoaiGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiGas.FormattingEnabled = true;
            this.cb_LoaiGas.Location = new System.Drawing.Point(161, 69);
            this.cb_LoaiGas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_LoaiGas.Name = "cb_LoaiGas";
            this.cb_LoaiGas.Size = new System.Drawing.Size(289, 33);
            this.cb_LoaiGas.TabIndex = 43;
            // 
            // txt_SltonGAS
            // 
            // 
            // 
            // 
            this.txt_SltonGAS.Border.Class = "TextBoxBorder";
            this.txt_SltonGAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SltonGAS.Location = new System.Drawing.Point(628, 69);
            this.txt_SltonGAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SltonGAS.Name = "txt_SltonGAS";
            this.txt_SltonGAS.Size = new System.Drawing.Size(236, 34);
            this.txt_SltonGAS.TabIndex = 42;
            this.txt_SltonGAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(496, 80);
            this.labelX7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(109, 23);
            this.labelX7.TabIndex = 41;
            this.labelX7.Text = "SL Tồn";
            // 
            // btn_SuaGAS
            // 
            this.btn_SuaGAS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SuaGAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaGAS.Image = global::BANGAS_TN.Properties.Resources.SUA;
            this.btn_SuaGAS.Location = new System.Drawing.Point(943, 62);
            this.btn_SuaGAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SuaGAS.Name = "btn_SuaGAS";
            this.btn_SuaGAS.Size = new System.Drawing.Size(132, 42);
            this.btn_SuaGAS.TabIndex = 38;
            this.btn_SuaGAS.Text = "Sửa";
            this.btn_SuaGAS.Click += new System.EventHandler(this.btn_SuaGAS_Click);
            // 
            // btn_XoaGAS
            // 
            this.btn_XoaGAS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_XoaGAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaGAS.Image = global::BANGAS_TN.Properties.Resources.XOA;
            this.btn_XoaGAS.Location = new System.Drawing.Point(943, 119);
            this.btn_XoaGAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XoaGAS.Name = "btn_XoaGAS";
            this.btn_XoaGAS.Size = new System.Drawing.Size(132, 42);
            this.btn_XoaGAS.TabIndex = 37;
            this.btn_XoaGAS.Text = "Xóa";
            this.btn_XoaGAS.Click += new System.EventHandler(this.btn_XoaGAS_Click);
            // 
            // btn_ThemGAS
            // 
            this.btn_ThemGAS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ThemGAS.BackColor = System.Drawing.Color.SeaShell;
            this.btn_ThemGAS.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ThemGAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemGAS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ThemGAS.Image = global::BANGAS_TN.Properties.Resources.THEM;
            this.btn_ThemGAS.Location = new System.Drawing.Point(943, 2);
            this.btn_ThemGAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThemGAS.Name = "btn_ThemGAS";
            this.btn_ThemGAS.Size = new System.Drawing.Size(132, 42);
            this.btn_ThemGAS.TabIndex = 36;
            this.btn_ThemGAS.Text = "Thêm";
            this.btn_ThemGAS.Click += new System.EventHandler(this.btn_ThemGAS_Click);
            // 
            // txt_SizeGAS
            // 
            // 
            // 
            // 
            this.txt_SizeGAS.Border.Class = "TextBoxBorder";
            this.txt_SizeGAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SizeGAS.Location = new System.Drawing.Point(628, 17);
            this.txt_SizeGAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SizeGAS.Name = "txt_SizeGAS";
            this.txt_SizeGAS.Size = new System.Drawing.Size(236, 34);
            this.txt_SizeGAS.TabIndex = 35;
            this.txt_SizeGAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_DgiaGAS
            // 
            // 
            // 
            // 
            this.txt_DgiaGAS.Border.Class = "TextBoxBorder";
            this.txt_DgiaGAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DgiaGAS.Location = new System.Drawing.Point(161, 169);
            this.txt_DgiaGAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DgiaGAS.Name = "txt_DgiaGAS";
            this.txt_DgiaGAS.Size = new System.Drawing.Size(291, 34);
            this.txt_DgiaGAS.TabIndex = 34;
            this.txt_DgiaGAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_MagasGAS
            // 
            // 
            // 
            // 
            this.txt_MagasGAS.Border.Class = "TextBoxBorder";
            this.txt_MagasGAS.Enabled = false;
            this.txt_MagasGAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MagasGAS.Location = new System.Drawing.Point(161, 17);
            this.txt_MagasGAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MagasGAS.Name = "txt_MagasGAS";
            this.txt_MagasGAS.Size = new System.Drawing.Size(291, 34);
            this.txt_MagasGAS.TabIndex = 31;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(31, 80);
            this.labelX5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(109, 23);
            this.labelX5.TabIndex = 30;
            this.labelX5.Text = "Mã Loại";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(31, 130);
            this.labelX4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(109, 23);
            this.labelX4.TabIndex = 29;
            this.labelX4.Text = "Mã NCC";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(31, 181);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(109, 23);
            this.labelX3.TabIndex = 28;
            this.labelX3.Text = "Đơn Giá";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(496, 30);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(109, 23);
            this.labelX2.TabIndex = 27;
            this.labelX2.Text = "Size";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(31, 30);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(109, 23);
            this.labelX1.TabIndex = 26;
            this.labelX1.Text = "Mã Gas";
            // 
            // data_Gas
            // 
            this.data_Gas.AllowUserToAddRows = false;
            this.data_Gas.AllowUserToDeleteRows = false;
            this.data_Gas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Gas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.data_Gas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_Gas.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_Gas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_Gas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.data_Gas.Location = new System.Drawing.Point(0, 244);
            this.data_Gas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_Gas.Name = "data_Gas";
            this.data_Gas.ReadOnly = true;
            this.data_Gas.RowHeadersWidth = 51;
            this.data_Gas.RowTemplate.Height = 24;
            this.data_Gas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Gas.Size = new System.Drawing.Size(1261, 429);
            this.data_Gas.TabIndex = 1;
            this.data_Gas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Gas_CellClick);
            // 
            // FrmGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.data_Gas);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmGas";
            this.Load += new System.EventHandler(this.FrmGas_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_Gas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX data_Gas;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SltonGAS;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btn_SuaGAS;
        private DevComponents.DotNetBar.ButtonX btn_XoaGAS;
        private DevComponents.DotNetBar.ButtonX btn_ThemGAS;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SizeGAS;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_DgiaGAS;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_MagasGAS;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox cb_Ncc;
        private System.Windows.Forms.ComboBox cb_LoaiGas;
        private DevComponents.DotNetBar.ButtonX btn_Clear;
    }
}