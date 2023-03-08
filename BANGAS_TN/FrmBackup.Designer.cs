
namespace BANGAS_TN
{
    partial class FrmBackup
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
            this.btnBackup = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtServer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.txtData = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lblPercent = new DevComponents.DotNetBar.LabelX();
            this.lblstatus = new DevComponents.DotNetBar.LabelX();
            this.btn_thoat = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(691, 205);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(108, 27);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(89, 40);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Server: ";
            // 
            // txtServer
            // 
            // 
            // 
            // 
            this.txtServer.Border.Class = "TextBoxBorder";
            this.txtServer.Location = new System.Drawing.Point(171, 40);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(381, 23);
            this.txtServer.TabIndex = 2;
            this.txtServer.Text = "DESKTOP-C2CRRUL\\SQLEXPRESS";
            // 
            // progressBarX1
            // 
            this.progressBarX1.Location = new System.Drawing.Point(75, 205);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(610, 27);
            this.progressBarX1.TabIndex = 3;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // txtData
            // 
            // 
            // 
            // 
            this.txtData.Border.Class = "TextBoxBorder";
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(171, 81);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(381, 23);
            this.txtData.TabIndex = 5;
            this.txtData.Text = "DA_BANGAS_SQL";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(64, 81);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Database: ";
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.Border.Class = "TextBoxBorder";
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(171, 162);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(381, 23);
            this.txtPass.TabIndex = 9;
            this.txtPass.Text = "123456";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(64, 162);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(100, 23);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "Password: ";
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.Border.Class = "TextBoxBorder";
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(171, 121);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(381, 23);
            this.txtUser.TabIndex = 7;
            this.txtUser.Text = "sa";
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(58, 121);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(106, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Username: ";
            // 
            // lblPercent
            // 
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(353, 238);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(43, 23);
            this.lblPercent.TabIndex = 10;
            this.lblPercent.Text = "0 %";
            // 
            // lblstatus
            // 
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(75, 301);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(70, 23);
            this.lblstatus.TabIndex = 11;
            this.lblstatus.Text = "Status:";
            // 
            // btn_thoat
            // 
            this.btn_thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(394, 297);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(108, 27);
            this.btn_thoat.TabIndex = 12;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 341);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBackup";
            this.Text = "FrmBackup";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnBackup;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtServer;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtData;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPass;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUser;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX lblPercent;
        private DevComponents.DotNetBar.LabelX lblstatus;
        private DevComponents.DotNetBar.ButtonX btn_thoat;
    }
}