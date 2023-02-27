
namespace BANGAS_TN
{
    partial class FrmNCC
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
            this.btn_clearNCC = new DevComponents.DotNetBar.ButtonX();
            this.btn_SuaNCC = new DevComponents.DotNetBar.ButtonX();
            this.btn_XoaNCC = new DevComponents.DotNetBar.ButtonX();
            this.btn_ThemNCC = new DevComponents.DotNetBar.ButtonX();
            this.txt_Diachincc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Tencc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Mancc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.data_NCC = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_NCC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btn_clearNCC);
            this.groupPanel1.Controls.Add(this.btn_SuaNCC);
            this.groupPanel1.Controls.Add(this.btn_XoaNCC);
            this.groupPanel1.Controls.Add(this.btn_ThemNCC);
            this.groupPanel1.Controls.Add(this.txt_Diachincc);
            this.groupPanel1.Controls.Add(this.txt_Tencc);
            this.groupPanel1.Controls.Add(this.txt_Mancc);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX3);
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
            this.groupPanel1.Text = "NHÀ CUNG CẤP";
            // 
            // btn_clearNCC
            // 
            this.btn_clearNCC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_clearNCC.BackColor = System.Drawing.Color.SeaShell;
            this.btn_clearNCC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_clearNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearNCC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clearNCC.Image = global::BANGAS_TN.Properties.Resources.THEM;
            this.btn_clearNCC.Location = new System.Drawing.Point(720, 144);
            this.btn_clearNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clearNCC.Name = "btn_clearNCC";
            this.btn_clearNCC.Size = new System.Drawing.Size(99, 34);
            this.btn_clearNCC.TabIndex = 40;
            this.btn_clearNCC.Text = "Làm Mới";
            this.btn_clearNCC.Click += new System.EventHandler(this.btn_clearNCC_Click);
            // 
            // btn_SuaNCC
            // 
            this.btn_SuaNCC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SuaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaNCC.Image = global::BANGAS_TN.Properties.Resources.SUA;
            this.btn_SuaNCC.Location = new System.Drawing.Point(720, 52);
            this.btn_SuaNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SuaNCC.Name = "btn_SuaNCC";
            this.btn_SuaNCC.Size = new System.Drawing.Size(99, 34);
            this.btn_SuaNCC.TabIndex = 39;
            this.btn_SuaNCC.Text = "Sửa";
            this.btn_SuaNCC.Click += new System.EventHandler(this.btn_SuaNCC_Click);
            // 
            // btn_XoaNCC
            // 
            this.btn_XoaNCC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_XoaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaNCC.Image = global::BANGAS_TN.Properties.Resources.XOA;
            this.btn_XoaNCC.Location = new System.Drawing.Point(720, 98);
            this.btn_XoaNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_XoaNCC.Name = "btn_XoaNCC";
            this.btn_XoaNCC.Size = new System.Drawing.Size(99, 34);
            this.btn_XoaNCC.TabIndex = 38;
            this.btn_XoaNCC.Text = "Xóa";
            this.btn_XoaNCC.Click += new System.EventHandler(this.btn_XoaNCC_Click);
            // 
            // btn_ThemNCC
            // 
            this.btn_ThemNCC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ThemNCC.BackColor = System.Drawing.Color.SeaShell;
            this.btn_ThemNCC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ThemNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNCC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ThemNCC.Image = global::BANGAS_TN.Properties.Resources.THEM;
            this.btn_ThemNCC.Location = new System.Drawing.Point(720, 3);
            this.btn_ThemNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ThemNCC.Name = "btn_ThemNCC";
            this.btn_ThemNCC.Size = new System.Drawing.Size(99, 34);
            this.btn_ThemNCC.TabIndex = 37;
            this.btn_ThemNCC.Text = "Thêm";
            this.btn_ThemNCC.Click += new System.EventHandler(this.btn_ThemNCC_Click);
            // 
            // txt_Diachincc
            // 
            // 
            // 
            // 
            this.txt_Diachincc.Border.Class = "TextBoxBorder";
            this.txt_Diachincc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Diachincc.Location = new System.Drawing.Point(457, 63);
            this.txt_Diachincc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Diachincc.Name = "txt_Diachincc";
            this.txt_Diachincc.Size = new System.Drawing.Size(218, 28);
            this.txt_Diachincc.TabIndex = 35;
            this.txt_Diachincc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Tencc
            // 
            // 
            // 
            // 
            this.txt_Tencc.Border.Class = "TextBoxBorder";
            this.txt_Tencc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tencc.Location = new System.Drawing.Point(123, 83);
            this.txt_Tencc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Tencc.Name = "txt_Tencc";
            this.txt_Tencc.Size = new System.Drawing.Size(218, 28);
            this.txt_Tencc.TabIndex = 33;
            this.txt_Tencc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Mancc
            // 
            // 
            // 
            // 
            this.txt_Mancc.Border.Class = "TextBoxBorder";
            this.txt_Mancc.Enabled = false;
            this.txt_Mancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mancc.Location = new System.Drawing.Point(123, 41);
            this.txt_Mancc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Mancc.Name = "txt_Mancc";
            this.txt_Mancc.Size = new System.Drawing.Size(218, 28);
            this.txt_Mancc.TabIndex = 32;
            this.txt_Mancc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(25, 93);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(82, 19);
            this.labelX5.TabIndex = 31;
            this.labelX5.Text = "Tên NCC";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(358, 72);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(82, 19);
            this.labelX3.TabIndex = 29;
            this.labelX3.Text = "Địa Chỉ";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(25, 52);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(82, 19);
            this.labelX1.TabIndex = 27;
            this.labelX1.Text = "Mã NCC";
            // 
            // data_NCC
            // 
            this.data_NCC.AllowUserToAddRows = false;
            this.data_NCC.AllowUserToDeleteRows = false;
            this.data_NCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_NCC.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.data_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_NCC.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_NCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_NCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.data_NCC.Location = new System.Drawing.Point(0, 198);
            this.data_NCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_NCC.Name = "data_NCC";
            this.data_NCC.ReadOnly = true;
            this.data_NCC.RowHeadersWidth = 51;
            this.data_NCC.RowTemplate.Height = 24;
            this.data_NCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_NCC.Size = new System.Drawing.Size(946, 349);
            this.data_NCC.TabIndex = 1;
            this.data_NCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_NCC_CellClick);
            // 
            // FrmNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.data_NCC);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmNCC";
            this.Text = "FrmNCC";
            this.Load += new System.EventHandler(this.FrmNCC_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_NCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX data_NCC;
        private DevComponents.DotNetBar.ButtonX btn_clearNCC;
        private DevComponents.DotNetBar.ButtonX btn_SuaNCC;
        private DevComponents.DotNetBar.ButtonX btn_XoaNCC;
        private DevComponents.DotNetBar.ButtonX btn_ThemNCC;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Diachincc;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Tencc;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Mancc;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}