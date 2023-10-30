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
    public partial class FormKhachHang : Form
    {
        int vitri = 0;
        string flag = "";
        string macn = "";
        string cmndcu = "";
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhachHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // dS.EnforceConstraints = false; câu lệnh này tải về và không kiểm tra các ràng buộc
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            // thiếu lệnh này (sẽ lấy tài khoản HTKN kết nối server 1 khi lấy tài khoản khác sẽ không thể lấy dữ liệu) nên phải lưu lại connstr
            this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);

            //macn = ((DataRowView)bdsKhachHang[0])["MACN"].ToString();
            cbxChiNhanh.DataSource = Program.bds_dspm;
            cbxChiNhanh.DisplayMember = "TENCN";
            cbxChiNhanh.ValueMember = "TENSERVER";
            cbxChiNhanh.SelectedIndex = Program.mChiNhanh;
            txtMaCN.Enabled = false;

            if (Program.mGroup == "CHINHANH")
            {
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = gcTaiKhoan.Enabled = true;
                cbxChiNhanh.Enabled = false;
            }
            if (Program.mGroup == "NGANHANG")
            {
                cbxChiNhanh.Enabled = true;
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKhachHang.Position;
            pnDetail.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled  = btnThoat.Enabled = false;
            bdsKhachHang.AddNew();
            txtMaCN.Text = ((DataRowView)bdsKhachHang[0])["MACN"].ToString();
            txtCMND.Focus();
            flag = "add";
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Chứng minh nhân dân không được để trống !", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }

            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống !", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }

            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống !", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }

            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không đúng định dạng.\nHãy chắc chắn sdt có 10 chữ số và bắt đầu với 0 !", "", MessageBoxButtons.OK);
                txtSDT.Focus();
                return;
            }

            if (flag == "add")
            {
                string queryCheckCMND = "EXEC SP_CheckCMND '" + txtCMND.Text + "'";
                Program.myReader = Program.execSqlDataReader(queryCheckCMND);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                int check = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (check == 1)
                {
                    MessageBox.Show("Khách hàng này đang tồn tại ở phân mảnh hiện tại !", "", MessageBoxButtons.OK);
                    txtCMND.Focus();
                    return;
                }
                else if (check == 2)
                {
                    MessageBox.Show("Khách hàng này đang tồn tại ở phân mảnh khác !", "", MessageBoxButtons.OK);
                    txtCMND.Focus();
                    return;
                }

                try
                {
                    bdsKhachHang.EndEdit();
                    bdsKhachHang.ResetCurrentItem();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Update(this.dS.KhachHang);
                }
                catch (Exception ex)
                {
                    bdsKhachHang.RemoveCurrent();
                    MessageBox.Show("Lỗi thêm khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (flag == "edit")
            {
                try
                {
                    bdsKhachHang.EndEdit();
                    bdsKhachHang.ResetCurrentItem();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Update(this.dS.KhachHang);
                }
                catch (Exception ex)
                {
                    bdsKhachHang.RemoveCurrent();
                    MessageBox.Show("Lỗi chỉnh sửa khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            pnDetail.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKhachHang.Position;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = pnDetail.Enabled = true;
            flag = "edit";
            cmndcu = txtCMND.Text;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cbxChiNhanh_SelectedIndexChanged_1(object sender, EventArgs e)
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
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);

                // Cập nhật giá trị mới cho biến macn dựa trên dòng đầu tiên của bdsKhachHang sau khi đã lấy dữ liệu mới
               /* macn = ((DataRowView)bdsKhachHang[0])["MACN"].ToString();*/
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cmnd = "";

            if (taiKhoanBindingSource.Count > 0)
            {
                MessageBox.Show("Khách hàng này đã có tài khoản, nên không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    cmnd = ((DataRowView)bdsKhachHang[bdsKhachHang.Position])["CMND"].ToString();
                    bdsKhachHang.RemoveCurrent();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Update(this.dS.KhachHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khách hàng. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                    bdsKhachHang.Position = bdsKhachHang.Find("CMND", cmnd);
                    return;
                }
            }
            if (bdsKhachHang.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void toolStripThem_Click(object sender, EventArgs e)
        {
            taiKhoanBindingSource.AddNew();
            if (Program.servername == "LAPTOP-8SBAMO62\\SERVER1")
                gridView2.SetFocusedRowCellValue(colMACN1, "BENTHANH");
            //colMACN1.Caption = "BENTHANH";
            else
                gridView2.SetFocusedRowCellValue(colMACN1, "TANDINH");
        }

        private void toolStripGhi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn mở tài khoản mới cho khách hàng này ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    string query = "EXEC SP_MoTaiKhoan '" + ((DataRowView)bdsKhachHang[bdsKhachHang.Position])["CMND"].ToString() + "', '"
                                                    + ((DataRowView)bdsKhachHang[0])["MACN"].ToString() + "'";
                    Program.execSqlNonQuery(query);
                    MessageBox.Show("Mở tài khoản mới thành công", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi mở tài khoản mới. Vui lòng thử lại !\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhachHang.CancelEdit();
            bdsKhachHang.Position = vitri;

            btnGhi.Enabled = btnPhucHoi.Enabled = pnDetail.Enabled = pnChiNhanh.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = khachHangGridControl.Enabled = true;
        }
    }
}
