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
    public partial class FormTaoTaiKhoan : Form
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'nGANHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

            string query = "EXEC SP_LayNVChuaTaoLogin";
            DataTable dt = Program.execDataTable(query);

            cbxMaNV.DataSource = dt;
            cbxMaNV.DisplayMember = "MANV";
            cbxMaNV.ValueMember = "MANV";
            cbxMaNV.SelectedIndex = 0;

            txtRole.Text = Program.mGroup;
        }

        private void cbxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhanVienBindingSource.Count != 0) // Kiểm tra xem form đã được giải phóng chưa
            {
                int rowIndex = nhanVienBindingSource.Find("MANV", cbxMaNV.Text.Trim());
                if (rowIndex != -1)
                {
                    DataRowView foundRowView = (DataRowView)nhanVienBindingSource[rowIndex];
                    string ho = foundRowView["HO"].ToString().Trim();
                    string ten = foundRowView["TEN"].ToString().Trim();
                    txtHoTen.Text = ho + " " + ten;
                }
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            string regexPattern = "^[a-zA-Z0-9 ]*$";

            if (string.IsNullOrEmpty(cbxMaNV.Text))
            {
                MessageBox.Show("Bạn chưa chọn nhân viên !", "Thông báo", MessageBoxButtons.OK);
                cbxMaNV.Focus();
            }
            if (string.IsNullOrEmpty(txtTenDN.Text))
            {
                MessageBox.Show("Tên đăng nhập không được để trống !", "Thông báo", MessageBoxButtons.OK);
                txtTenDN.Focus();
            }
            if (!Regex.IsMatch(txtTenDN.Text, regexPattern))
            {
                MessageBox.Show("Tên đăng nhập không được có kí tự đặc biệt !", "Thông báo", MessageBoxButtons.OK);
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống !", "Thông báo", MessageBoxButtons.OK);
                txtMatKhau.Focus();
            }
            else
            {
                try
                {
                    MessageBox.Show(txtTenDN.Text, "Thông báo", MessageBoxButtons.OK);

                    string query = "EXEC SP_TaoTaiKhoan '"
                        + txtTenDN.Text + "', '"
                        + txtMatKhau.Text + "', '"
                        + cbxMaNV.Text.Trim() + "', '"
                        + Program.mGroup + "'";

                    Program.myReader = Program.execSqlDataReader(query);
                    if (Program.myReader == null)
                    {
                        return;
                    }

                    Program.myReader.Read();
                    int isCheck = Program.myReader.GetInt32(0);
                    Program.myReader.Close();

                    if (isCheck == 2)
                    {
                        MessageBox.Show("Nhân viên đã được tạo tài khoản !", "Thông báo", MessageBoxButtons.OK);
                        txtTenDN.Focus();
                    }
                    if (isCheck == 1)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại !", "Thông báo", MessageBoxButtons.OK);
                        txtTenDN.Focus();
                    }
                    if (isCheck == 0)
                    {
                        MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thao tác thất bại, vui lòng thử lại !" + ex.ToString(), "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
