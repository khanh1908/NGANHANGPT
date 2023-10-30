using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG
{
    public partial class FormGuiRut : Form
    {
        int vitri = 0;
        public FormGuiRut()
        {
            InitializeComponent();
        }

        private void gD_GOIRUTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gD_GOIRUTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormGuiRut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            //this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);

            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);

            cbxChiNhanh.DataSource = Program.bds_dspm;
            cbxChiNhanh.DisplayMember = "TENCN";
            cbxChiNhanh.ValueMember = "TENSERVER";
            cbxChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "CHINHANH")
            {
                pnChiNhanh.Enabled = false;
                btnThem.Enabled = true;
            }
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
            else
            {
                dS.EnforceConstraints = false;
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);

                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);

                // Cập nhật giá trị mới cho biến macn dựa trên dòng đầu tiên của bdsKhachHang sau khi đã lấy dữ liệu mới
                //macn = ((DataRowView)bdsKhachHang[0])["MACN"].ToString();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = gD_GOIRUTBindingSource.Position;
            pnlDetail.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            gD_GOIRUTBindingSource.AddNew();
            txtMaNV.Text = Program.username;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gD_GOIRUTBindingSource.EndEdit();
                gD_GOIRUTBindingSource.ResetCurrentItem();

                if (cbSoTk.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn số tài khoản !", "", MessageBoxButtons.OK);
                    cbSoTk.Focus();
                    return;
                }

                if (cbLoaiGD.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn loại giao dịch !", "", MessageBoxButtons.OK);
                    cbLoaiGD.Focus();
                    return;
                }

                if (Convert.ToInt32(txtSoTien.EditValue) < 100000 || txtSoTien.EditValue == null)
                {
                    MessageBox.Show("Số tiền giao dịch tối thiểu phải là 100.000đ !", "", MessageBoxButtons.OK);
                    txtSoTien.Focus();
                    return;
                }

                string query = "EXEC SP_GDGoiRut '"
                                + cbSoTk.SelectedValue.ToString().Trim() + "', '"
                                + cbLoaiGD.SelectedItem.ToString().Trim() + "', "
                                + txtSoTien.EditValue.ToString().Trim() + ", '"
                                + txtMaNV.Text.ToString().Trim() + "'";
                 Program.myReader = Program.execSqlDataReader(query);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                int check = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (check == -1)
                {
                    MessageBox.Show("Số tài khoản không tồn tại.\nVui lòng thử lại.", "Thông báo", MessageBoxButtons.OK);
                    cbSoTk.Focus();
                    return;
                }
                else if (check == 1)
                {
                    MessageBox.Show("Thực hiện giao dịch thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else if (check == 0)
                {
                    MessageBox.Show("Thực hiện giao dịch thất bại.\nVui lòng thử lại.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Số dư ko đủ để thực hiện rút tiền.", "Thông báo", MessageBoxButtons.OK);
                    txtSoTien.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                gD_GOIRUTBindingSource.RemoveCurrent();
                MessageBox.Show("Lỗi thực hiện giao dịch.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            pnlDetail.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
