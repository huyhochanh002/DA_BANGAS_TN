using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
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
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }
        public Giaodienchinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if(e.Error != null)
            {
                lblstatus.Invoke((MethodInvoker)delegate
                {
                    lblstatus.Text = e.Error.Message;
                });
            }    
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBarX1.Invoke((MethodInvoker)delegate
            {
                progressBarX1.Value = e.Percent;
                progressBarX1.Update();
            });
            lblPercent.Invoke((MethodInvoker)delegate
            {
                lblPercent.Text = $"{e.Percent}%";
            });
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            progressBarX1.Value = 0;
            try
            {
                Server dbServer = new Server(new ServerConnection(txtServer.Text, txtUser.Text, txtPass.Text));
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = txtData.Text };
                dbBackup.Devices.AddDevice(@"D:\Data\DA_BANGAS_SQL.bak", DeviceType.File);
                dbBackup.Initialize = true;
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackupAsync(dbServer);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DongTap();
        }
    }
}
