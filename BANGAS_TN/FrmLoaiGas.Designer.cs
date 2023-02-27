
namespace BANGAS_TN
{
    partial class FrmLoaiGas
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
            this.btn_cleargas = new DevComponents.DotNetBar.ButtonX();
            this.btn_Suagas = new DevComponents.DotNetBar.ButtonX();
            this.btn_Xoagas = new DevComponents.DotNetBar.ButtonX();
            this.btn_ThemGas = new DevComponents.DotNetBar.ButtonX();
            this.txtTenLoaiGas = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtMaLoaiGas = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.data_LoaiGas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_LoaiGas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btn_cleargas);
            this.groupPanel1.Controls.Add(this.btn_Suagas);
            this.groupPanel1.Controls.Add(this.btn_Xoagas);
            this.groupPanel1.Controls.Add(this.btn_ThemGas);
            this.groupPanel1.Controls.Add(this.txtTenLoaiGas);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtMaLoaiGas);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1262, 244);
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
            this.groupPanel1.Text = "LOẠI GAS";
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // btn_cleargas
            // 
            this.btn_cleargas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cleargas.BackColor = System.Drawing.Color.SeaShell;
            this.btn_cleargas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_cleargas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cleargas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cleargas.Image = global::BANGAS_TN.Properties.Resources.THEM;
            this.btn_cleargas.Location = new System.Drawing.Point(1040, 175);
            this.btn_cleargas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cleargas.Name = "btn_cleargas";
            this.btn_cleargas.Size = new System.Drawing.Size(132, 42);
            this.btn_cleargas.TabIndex = 30;
            this.btn_cleargas.Text = "Làm Mới";
            this.btn_cleargas.Click += new System.EventHandler(this.btn_cleargas_Click);
            // 
            // btn_Suagas
            // 
            this.btn_Suagas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Suagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suagas.Image = global::BANGAS_TN.Properties.Resources.SUA;
            this.btn_Suagas.Location = new System.Drawing.Point(1040, 62);
            this.btn_Suagas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Suagas.Name = "btn_Suagas";
            this.btn_Suagas.Size = new System.Drawing.Size(132, 42);
            this.btn_Suagas.TabIndex = 29;
            this.btn_Suagas.Text = "Sửa";
            this.btn_Suagas.Click += new System.EventHandler(this.btn_Suagas_Click);
            // 
            // btn_Xoagas
            // 
            this.btn_Xoagas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Xoagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoagas.Image = global::BANGAS_TN.Properties.Resources.XOA;
            this.btn_Xoagas.Location = new System.Drawing.Point(1040, 119);
            this.btn_Xoagas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoagas.Name = "btn_Xoagas";
            this.btn_Xoagas.Size = new System.Drawing.Size(132, 42);
            this.btn_Xoagas.TabIndex = 28;
            this.btn_Xoagas.Text = "Xóa";
            this.btn_Xoagas.Click += new System.EventHandler(this.btn_Xoagas_Click);
            // 
            // btn_ThemGas
            // 
            this.btn_ThemGas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ThemGas.BackColor = System.Drawing.Color.SeaShell;
            this.btn_ThemGas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ThemGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemGas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ThemGas.Image = global::BANGAS_TN.Properties.Resources.THEM;
            this.btn_ThemGas.Location = new System.Drawing.Point(1040, 2);
            this.btn_ThemGas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThemGas.Name = "btn_ThemGas";
            this.btn_ThemGas.Size = new System.Drawing.Size(132, 42);
            this.btn_ThemGas.TabIndex = 27;
            this.btn_ThemGas.Text = "Thêm";
            this.btn_ThemGas.Click += new System.EventHandler(this.btn_ThemGas_Click);
            // 
            // txtTenLoaiGas
            // 
            // 
            // 
            // 
            this.txtTenLoaiGas.Border.Class = "TextBoxBorder";
            this.txtTenLoaiGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiGas.Location = new System.Drawing.Point(588, 91);
            this.txtTenLoaiGas.Name = "txtTenLoaiGas";
            this.txtTenLoaiGas.Size = new System.Drawing.Size(309, 35);
            this.txtTenLoaiGas.TabIndex = 4;
            this.txtTenLoaiGas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTenLoaiGas.TextChanged += new System.EventHandler(this.textBoxX2_TextChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(485, 95);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(97, 31);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tên Loại";
            // 
            // txtMaLoaiGas
            // 
            // 
            // 
            // 
            this.txtMaLoaiGas.Border.Class = "TextBoxBorder";
            this.txtMaLoaiGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiGas.Location = new System.Drawing.Point(146, 91);
            this.txtMaLoaiGas.Name = "txtMaLoaiGas";
            this.txtMaLoaiGas.Size = new System.Drawing.Size(309, 35);
            this.txtMaLoaiGas.TabIndex = 2;
            this.txtMaLoaiGas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaLoaiGas.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX1.Location = new System.Drawing.Point(43, 95);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(97, 31);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã Loại";
            // 
            // data_LoaiGas
            // 
            this.data_LoaiGas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.data_LoaiGas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_LoaiGas.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_LoaiGas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_LoaiGas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.data_LoaiGas.Location = new System.Drawing.Point(0, 244);
            this.data_LoaiGas.Name = "data_LoaiGas";
            this.data_LoaiGas.RowHeadersWidth = 51;
            this.data_LoaiGas.RowTemplate.Height = 24;
            this.data_LoaiGas.Size = new System.Drawing.Size(1262, 429);
            this.data_LoaiGas.TabIndex = 1;
            this.data_LoaiGas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_LoaiGas_CellClick);
            // 
            // FrmLoaiGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.data_LoaiGas);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLoaiGas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoaiGas";
            this.Load += new System.EventHandler(this.FrmLoaiGas_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_LoaiGas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLoaiGas;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLoaiGas;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btn_cleargas;
        private DevComponents.DotNetBar.ButtonX btn_Suagas;
        private DevComponents.DotNetBar.ButtonX btn_Xoagas;
        private DevComponents.DotNetBar.ButtonX btn_ThemGas;
        private DevComponents.DotNetBar.Controls.DataGridViewX data_LoaiGas;
    }
}