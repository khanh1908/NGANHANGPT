using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG
{
    public partial class FormNhanVien : Form
    {
        int viTri = 0;
        string flag = "";
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);

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
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnChuyen.Enabled = true;
            }

            if (nhanVienBindingSource.Count == 0)
            {
                btnXoa.Enabled = false;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = nhanVienBindingSource.Position;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = nhanVienGridControl.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = pnNhap.Enabled = true;
            nhanVienBindingSource.AddNew();
            txtMaCN.Text = ((DataRowView)nhanVienBindingSource[0])["MaCN"].ToString();
            radBtnTrangThaiXoa.Checked = false;

            string maNVMoi = TaoMaNV();
            txtMaNV.Text = maNVMoi;

            flag = "add";
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = nhanVienBindingSource.Position;
            btnThem.Enabled = btnHieuChinh.Enabled = pnChuyenCN.Enabled = btnXoa.Enabled = nhanVienGridControl.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = pnNhap.Enabled =  true;
            flag = "edit";
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống !", "", MessageBoxButtons.OK);
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được để trống !", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống !", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND nhân viên không được để trống !", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }
            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không đúng định dạng.\nHãy chắc chắn sdt có 10 chữ số và bắt đầu với 0 !", "", MessageBoxButtons.OK);
                txtSDT.Focus();
                return;
            }
            if (cbxPhai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính !", "", MessageBoxButtons.OK);
                cbxPhai.Focus();
                return;
            }

            if (flag == "add")
            {
                string queryCheckMaNV = "EXEC SP_CheckMaNV '" + txtMaNV + "'";
                Program.myReader = Program.execSqlDataReader(queryCheckMaNV);
                if (Program.myReader == null)
                {
                    return;
                }
                Program.myReader.Read();
                int check = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (check == 1)
                {
                    MessageBox.Show("Mã nhân viên này đang tồn tại ở phân mảnh hiện tại!", "", MessageBoxButtons.OK);
                    txtMaNV.Focus();
                    return;
                }
                else if (check == 2)
                {
                    MessageBox.Show("Mã nhân viên này đang tồn tại ở phân mảnh khác!", "", MessageBoxButtons.OK);
                    txtMaNV.Focus();
                    return;
                }

                try
                {
                    nhanVienBindingSource.EndEdit();
                    nhanVienBindingSource.ResetCurrentItem();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                }
                catch (Exception ex)
                {
                    nhanVienBindingSource.RemoveCurrent();
                    MessageBox.Show("Lỗi thêm nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else if (flag == "edit")
            {
                try
                {
                    nhanVienBindingSource.EndEdit();
                    nhanVienBindingSource.ResetCurrentItem();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                }
                catch (Exception ex)
                {
                    nhanVienBindingSource.RemoveCurrent();
                    MessageBox.Show("Lỗi chỉnh sửa nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            btnGhi.Enabled = btnPhucHoi.Enabled = pnNhap.Enabled = pnChuyenCN.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = nhanVienGridControl.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = "";
            if (gD_CHUYENTIENBindingSource.Count > 0)
            {
                MessageBox.Show("Nhân viên này đã thực hiện giao dịch chuyển tiền, nên không thể xóa !", "", MessageBoxButtons.OK);
                return;
            }
            if (gD_GOIRUTBindingSource.Count > 0)
            {
                MessageBox.Show("Nhân viên này đã thực hiện giao dịch gửi rút tiền, nên không thể xóa !", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa nhân viên có mã " + txtMaNV.Text, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MaNV"].ToString();
                    nhanVienBindingSource.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    nhanVienBindingSource.Position = nhanVienBindingSource.Find("MaNV", manv);
                    return;
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhanVienBindingSource.CancelEdit();
            nhanVienBindingSource.Position = viTri;

            btnGhi.Enabled = btnPhucHoi.Enabled = pnNhap.Enabled = pnChuyenCN.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = nhanVienGridControl.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnChuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = nhanVienBindingSource.Position;
            string queryGetCNChuyen = "EXEC SP_GetCNChuyen";
            DataTable dt = Program.execDataTable(queryGetCNChuyen);
            pnChuyenCN.Enabled = btnPhucHoi.Enabled = true;
            pnNhap.Enabled = btnThem.Enabled = btnGhi.Enabled = btnHieuChinh.Enabled = nhanVienGridControl.Enabled = btnThoat.Enabled = false;
            cbChuyenCN.DataSource = dt;
            cbChuyenCN.DisplayMember = "TENCN";
            cbChuyenCN.ValueMember = "MACN";
            cbChuyenCN.SelectedIndex = 0;
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
            // TODO: This line of code loads data into the 'nGANHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
        }
        private string TaoMaNV()
        {
            string queryLayMaNV = "EXEC SP_LayMaNV";
            Program.myReader = Program.execSqlDataReader(queryLayMaNV);
            if (Program.myReader == null)
                return "";
            Program.myReader.Read();

            string maNVCC = Program.myReader.GetString(0);
            Program.myReader.Close();

            int maSoMoi = int.Parse(Regex.Replace(maNVCC, "[^0-9]", ""));
            maSoMoi++;
            string maNVMoi = "NV" + maSoMoi.ToString();

            return maNVMoi;
        }

        private void nhanVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void btnChuyenCN_Click_1(object sender, EventArgs e)
        {
            if (cbChuyenCN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            if (txtMaNV.Text == Program.username)
            {
                MessageBox.Show("Bạn không thể tự chuyển chính mình !\n", "", MessageBoxButtons.OK);
                return;
            }

            if (cbChuyenCN.SelectedIndex == Program.mChiNhanh)
            {
                MessageBox.Show("Nhân viên đang ở chi nhánh hiện tại !\n", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn muốn chuyển nhân viên có mã " + txtMaNV.Text.Trim()
                                + " từ " + txtMaCN.Text.Trim()
                                + " sang " + cbChuyenCN.SelectedValue.ToString().Trim(), "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    string maNVMoi = TaoMaNV();
                    if (maNVMoi == "")
                    {
                        MessageBox.Show("Lỗi chuyển nhân viên, lỗi tạo mã !\n", "", MessageBoxButtons.OK);
                        return;
                    }

                    string queryChuyenChiNhanhNV = "EXEC SP_ChuyenChiNhanh '" + txtMaNV.Text.Trim() + "', '" + maNVMoi + "'";
                    Program.myReader = Program.execSqlDataReader(queryChuyenChiNhanhNV);
                    if (Program.myReader == null)
                    {
                        return;
                    }
                    Program.myReader.Read();
                    Program.myReader.Close();
                    MessageBox.Show("Chuyển nhân viên thành công !\n", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chuyển nhân viên thất bại, lỗi kết nối server. Hãy thử kết nối lại !\n" + ex, "", MessageBoxButtons.OK);
                    return;
                }
            }

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = nhanVienGridControl.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = pnChuyenCN.Enabled = false;
        }

       
    }
}
