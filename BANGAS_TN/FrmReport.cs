using Microsoft.Reporting.WinForms;
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
    public partial class FrmReport : Form
    {
        private string _message;
        private string _sql;
        private int _status;

        public FrmReport(string Message, int status, string sql) : this()
        {
            _message = Message;
            _status = status;
            _sql = sql;
        }
        public FrmReport()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection();
        DataSet dSet;
        SqlDataAdapter myAdapter;



        private void FrmReport_Load(object sender, EventArgs e)
        {
            if (_status == 1)
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-C2CRRUL\\SQLEXPRESS;Initial Catalog=DA_BANGAS_SQL;User ID=sa;Password=123456";
                String sql;
                sql = "Select * from CTHD where Mahd= '" + _message + "'";
                DataSet ds;
                ds = ReadDataSet(sql);

                reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

                reportViewer1.LocalReport.ReportPath = "Report1.rdlc";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rd = new ReportDataSource("CTHD", ds.Tables[0]);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rd);
                    reportViewer1.RefreshReport();
                }

                this.reportViewer1.RefreshReport();
            }
            if(_status==2)
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Data Source=DESKTOP-C2CRRUL\\SQLEXPRESS;Initial Catalog=DA_BANGAS_SQL;User ID=sa;Password=123456";
                String sql;
                sql = _sql;
                DataSet ds;
                ds = ReadDataSet(sql);

                reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

                reportViewer1.LocalReport.ReportPath = "Report2.rdlc";

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rd = new ReportDataSource("CTHD", ds.Tables[0]);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rd);
                    reportViewer1.RefreshReport();
                }

                this.reportViewer1.RefreshReport();
            }                
                    
                    
           
          
                    
                    
             
        }

        DataSet ReadDataSet(string sql)
        {
            dSet = new DataSet();
            myAdapter = new SqlDataAdapter(sql, conn);
            myAdapter.Fill(dSet);
            return dSet;
        }
    }
}