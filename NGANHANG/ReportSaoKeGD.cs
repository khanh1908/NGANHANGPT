using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NGANHANG
{
    public partial class ReportSaoKeGD : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportSaoKeGD()
        {
            InitializeComponent();
        }

        public ReportSaoKeGD(string soTK, DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = soTK;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = tuNgay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = denNgay;
            this.sqlDataSource1.Fill();
        }

    }
}
