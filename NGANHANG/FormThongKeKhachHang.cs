using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace NGANHANG
{
    public partial class FormThongKeKhachHang : Form
    {
        public FormThongKeKhachHang()
        {
            InitializeComponent();
        }

        private void cbxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = cbxChiNhanh.SelectedValue.ToString();

            if (cbxChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.login = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.login = Program.mLoginDN;
                Program.password = Program.mPasswordDN;
            }

            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới !", "", MessageBoxButtons.OK);
        }

        private void FormThongKeKhachHang_Load(object sender, EventArgs e)
        {
            cbxChiNhanh.DataSource = Program.bds_dspm;
            cbxChiNhanh.DisplayMember = "TENCN";
            cbxChiNhanh.ValueMember = "TENSERVER";
            cbxChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "CHINHANH")
            {
                panelControl1.Enabled = false;
            }
        }

        private void btnInds_Click(object sender, EventArgs e)
        {
            ReportThongKeKhachHang report = new ReportThongKeKhachHang();
            report.lbTieuDe.Text = "DANH SÁCH KHÁCH HÀNG CỦA " + cbxChiNhanh.Text.ToString().Trim().ToUpper();
            report.lblNguoiTao.Text = "Người tạo sao kê:" + Program.mHoTen;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }
    }
}
