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
    public partial class FormChuyenTien : Form
    {
        int viTri = 0;
        public FormChuyenTien()
        {
            InitializeComponent();
        }

        private void gD_CHUYENTIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gD_CHUYENTIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormChuyenTien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);

            // TODO: This line of code loads data into the 'nGANHANGDataSet.TKNhan' table. You can move, or remove it, as needed.
            this.tKNhanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tKNhanTableAdapter.Fill(this.dS.TKNhan);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.TKChuyen' table. You can move, or remove it, as needed.
            this.tKChuyenTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tKChuyenTableAdapter.Fill(this.dS.TKChuyen);
            cbxChiNhanh.DataSource = Program.bds_dspm;
            cbxChiNhanh.DisplayMember = "TENCN";
            cbxChiNhanh.ValueMember = "TENSERVER";
            cbxChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "NGANHANG")
            {
                cbxChiNhanh.Enabled = true;
            }
            if (Program.mGroup == "CHINHANH")
            {
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
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh !", "", MessageBoxButtons.OK);
                return;
            }

            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.TKNhan' table. You can move, or remove it, as needed.
            this.tKNhanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tKNhanTableAdapter.Fill(this.dS.TKNhan);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.TKChuyen' table. You can move, or remove it, as needed.
            this.tKChuyenTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tKChuyenTableAdapter.Fill(this.dS.TKChuyen);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = gD_CHUYENTIENBindingSource.Position;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = gD_CHUYENTIENGridControl.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = panelControl1.Enabled = true;
            gD_CHUYENTIENBindingSource.AddNew();
            MessageBox.Show(Program.username);
            txtMaNV.Text = Program.username;

/*            flag = "add";
*/        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(cbxSoTKChuyen.Text))
            {
                MessageBox.Show("Vui lòng chọn số tài khoản chuyển !", "Thông báo", MessageBoxButtons.OK);
                cbxSoTKChuyen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cbxSoTKNhan.Text))
            {
                MessageBox.Show("Vui lòng chọn số tài khoản nhận !", "Thông báo", MessageBoxButtons.OK);
                cbxSoTKNhan.Focus();
                return;
            }

            if (cbxSoTKNhan.Text == cbxSoTKChuyen.Text)
            {
                MessageBox.Show("Tài khoản chuyển và tài khoản gửi là 1 tài khoản !", "Thông báo", MessageBoxButtons.OK);
                cbxSoTKNhan.Focus();
                return;
            }
            if (txtSoTien.Text == "" || Convert.ToInt32(txtSoTien.EditValue) < 100000)
            {
                MessageBox.Show("Số tiền gửi ít nhất 100.000 đ. Vui lòng nhập số tiền gửi !", "Thông báo", MessageBoxButtons.OK);
                txtSoTien.Focus();
                return;
            }


            if (MessageBox.Show("Bạn có muốn thực hiện giao dịch chuyển tiền ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    gD_CHUYENTIENBindingSource.EndEdit();
                    gD_CHUYENTIENBindingSource.ResetCurrentItem();

                    //string tkChuyen = cbxSoTKChuyen.Text.Trim();
                    //string tkNhan = cbxSoTKNhan.Text.Trim();

                    string queryChuyenTien = "EXEC SP_ChuyenTien '"
                        + cbxSoTKChuyen.Text.Trim() + "', '"
                        + cbxSoTKNhan.Text.Trim() + "', "
                        + txtSoTien.EditValue.ToString().Trim() + ", '"
                        + txtMaNV.Text.ToString().Trim() + "'";

                    Program.myReader = Program.execSqlDataReader(queryChuyenTien);

                    if (Program.myReader == null)
                        return;

                    Program.myReader.Read();
                    int isCheck = Program.myReader.GetInt32(0);
                    Program.myReader.Close();
                    if (isCheck == 2)
                    {
                        MessageBox.Show("Số tài khoản chuyển " + cbxSoTKChuyen.Text.Trim() + " không đúng, nhập lại tài khoản !", "Thông báo", MessageBoxButtons.OK);
                        cbxSoTKChuyen.Focus();
                        return;
                    }
                    if (isCheck == 3)
                    {
                        MessageBox.Show("Số tài khoản nhận " + cbxSoTKNhan.Text.Trim() + " không đúng, nhập lại tài khoản !", "Thông báo", MessageBoxButtons.OK);
                        cbxSoTKNhan.Focus();
                        return;
                    }
                    if (isCheck == 4)
                    {
                        MessageBox.Show("Số dư tài khoản không đủ !", "Thông báo", MessageBoxButtons.OK);
                        txtSoTien.Focus();
                        return;
                    }

                    if (isCheck == 1)
                    {
                        MessageBox.Show("Chuyển tiền thành công !", "Thông báo", MessageBoxButtons.OK);
                    }
                    if (isCheck == 0)
                    {
                        MessageBox.Show("Chuyển tiền thất bại, xin vui lòng thử lại !", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chuyển tiền thất bại, xin vui lòng thử lại !" + ex.ToString(), "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            btnGhi.Enabled = btnPhucHoi.Enabled = panelControl1.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = gD_CHUYENTIENGridControl.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gD_CHUYENTIENBindingSource.CancelEdit();
            gD_CHUYENTIENBindingSource.Position = viTri;
            gD_CHUYENTIENGridControl.Enabled = btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = panelControl1.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtCMNDNN_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cMNDLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cMNDLabel_Click(object sender, EventArgs e)
        {

        }

        private void sOTKLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void hOTENLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbxSoTKChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTenNC_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCMNDNC_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
