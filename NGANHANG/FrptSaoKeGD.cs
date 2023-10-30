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
    public partial class FrptSaoKeGD : Form
    {
        public FrptSaoKeGD()
        {
            InitializeComponent();
        }

        private void FormSaoKeGD_Load(object sender, EventArgs e)
        {

            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.TKChuyen' table. You can move, or remove it, as needed.
            this.tKChuyenTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tKChuyenTableAdapter.Fill(this.dS.TKChuyen);

        }

        private void btnSaoKe_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbxSoTK.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng chọn hoặc nhập tài khoản sao kê", "Thông báo", MessageBoxButtons.OK);
                    cbxSoTK.Focus();
                    return;
                }

                bool isCheckSoTK = checkTK(cbxSoTK.Text.Trim(), tKChuyenBindingSource);
                if (!isCheckSoTK)
                {
                    MessageBox.Show("Tài khoản sao kê không tồn tại, vui lòng nhập lại tài khoản", "Thông báo", MessageBoxButtons.OK);
                    cbxSoTK.Focus();
                    return;
                }
                //MessageBox.Show(dtDenNgay.Value.ToString(), "Thông báo", MessageBoxButtons.OK);
                ReportSaoKeGD rpt = new ReportSaoKeGD(cbxSoTK.Text.Trim(), dtTuNgay.Value, dtDenNgay.Value);
                rpt.lblTaiKhoan.Text = "SỐ TÀI KHOẢN: " + cbxSoTK.Text.Trim();

                string dateStart = dtTuNgay.Value.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                string dateEnd = dtDenNgay.Value.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                rpt.lblTuNgay.Text = "TỪ NGÀY: " + dateStart;
                rpt.lblDenNgay.Text = "ĐẾN NGÀY: " + dateEnd;
                rpt.lblSoDuCuoi.Text = "Số dư tới ngày " + dateEnd + ":";
                rpt.xrNguoiTao.Text = "Người tạo sao kê:" + Program.mHoTen;
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sao kê thất bại, xin vui lòng thử lại !" + ex.ToString(), "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }
        private bool checkTK(string soTK, BindingSource tk)
        {
            foreach (DataRowView rowView in tk)
            {
                if (string.Equals(soTK.Trim(), rowView["SOTK"].ToString().Trim()))
                    return true;
            }
            return false;
        }
    }
}
