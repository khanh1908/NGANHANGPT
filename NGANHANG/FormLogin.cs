using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG
{
    public partial class FormLogin : Form
    {

        private SqlConnection conn_publisher = new SqlConnection();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void getLiveServer(string query)
        {
            DataTable dataTable = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
                conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conn_publisher);
            da.Fill(dataTable);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dataTable;
            cbxChiNhanh.DataSource = Program.bds_dspm;
            
            cbxChiNhanh.DisplayMember = "TENCN";
            cbxChiNhanh.ValueMember = "TENSERVER";
        }

        private int connectCSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu gốc.\nBạn xem lại tên Server và tên CSDL.\n" + e.Message);
                return 0;
            }
        }


        private void cbxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbxChiNhanh.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (connectCSDLGOC() == 0)
                return;

            string query = "SELECT TOP 2 * FROM V_DS_PHANMANH";
            getLiveServer(query);

            conn_publisher.Close();
            cbxChiNhanh.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ tên đăng nhập và mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Program.login = txtTenDangNhap.Text;
            Program.password = txtMatKhau.Text;

            if (Program.KetNoi() == 0)
                return;
            Program.mChiNhanh = cbxChiNhanh.SelectedIndex;
            Program.mLoginDN = Program.login;
            Program.mPasswordDN = Program.password;

            string query = "EXEC SP_DANGNHAP '" + Program.mLoginDN+"'";
            Program.myReader = Program.execSqlDataReader(query);

            if (Program.myReader == null)
                return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login của bạn không có quyền xem dữ liệu.\nHãy đăng nhập lại.\n", "", MessageBoxButtons.OK);
                return;
            }

            Program.mHoTen = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.formMain.sslMaNV.Text = "MANV: " + Program.username;
            Program.formMain.sslHoTen.Text = "HOTEN: " + Program.mHoTen;
            Program.formMain.sslNHOM.Text = "MHOM: " + Program.mGroup;

            Program.formMain.barBtnTaoTaiKhoan.Enabled = true;
            Program.formMain.barBtnDangXuat.Enabled = true;
            Program.formMain.rbNghiepVu.Visible = Program.formMain.rbNhanVien.Visible = Program.formMain.rbBaoCao.Visible = true;
/*            Program.formMain.rbNhanVien.Visible = Program.formMain.rbpKH.Visible = Program.formMain.rbpTK.Visible = true;
*/            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}