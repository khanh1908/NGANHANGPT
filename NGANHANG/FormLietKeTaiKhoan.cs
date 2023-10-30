using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG
{
    public partial class FormLietKeTaiKhoan : Form
    {
        public FormLietKeTaiKhoan()
        {
            InitializeComponent();
            cbxChiNhanh.DataSource = Program.bds_dspm;
            cbxChiNhanh.DisplayMember = "TENCN";
            cbxChiNhanh.ValueMember = "TENSERVER";
            cbxChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "NGANHANG")
            {
                cbxChiNhanh.Enabled = checkbxToanChiNhanh.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                int tatCa = 0;
                if (checkbxToanChiNhanh.Checked)
                {
                    tatCa = 1;
                }
                ReportLietKeTaiKhoan rpt = new ReportLietKeTaiKhoan(tatCa, cbxChiNhanh.Text.Trim(), dtTuNgay.Value, dtDenNgay.Value);

                if (tatCa == 0)
                    rpt.lblChiNhanh.Text = "Chi nhánh: " + cbxChiNhanh.Text.Trim();
                else
                    rpt.lblChiNhanh.Text = "Chi nhánh: Tất cả chi nhánh";
                string dateStart = dtTuNgay.Value.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                string dateEnd = dtDenNgay.Value.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                rpt.lblTuNgay.Text = "TỪ NGÀY: " + dateStart;
                rpt.lblDenNgay.Text = "ĐẾN NGÀY: " + dateEnd;
                rpt.lblNguoiTao.Text = "Người tạo báo cáo:" + Program.mHoTen;
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liệt kê tài khoản thất bại, xin vui lòng thử lại !" + ex.ToString(), "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
