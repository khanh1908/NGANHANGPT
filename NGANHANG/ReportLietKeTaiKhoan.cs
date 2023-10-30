using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NGANHANG
{
    public partial class ReportLietKeTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportLietKeTaiKhoan()
        {
            InitializeComponent();
        }
        public ReportLietKeTaiKhoan(int tatCa, String chiNhanh, DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = tatCa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = chiNhanh;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = tuNgay;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = denNgay;
            this.sqlDataSource1.Fill();
        }

    }
}
