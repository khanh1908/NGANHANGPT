using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace NGANHANG
{
    static class Program
    {

        public static SqlConnection conn = new SqlConnection();
        public static string connstr = "";
        public static string connstr_publisher = "Data Source=LAPTOP-8SBAMO62;Initial Catalog=NGANHANG;User ID=sa;Pwd=123456";

        public static SqlDataReader myReader;
        public static string servername = "";
        public static string username = "";
        public static string login = "";
        public static string password = "";

        public static string database = "NGANHANG";
        public static string remotelogin = "HTKN";
        public static string remotepassword = "123456";

        public static string mLoginDN = "";
        public static string mPasswordDN = "";
        public static string mGroup = "";
        public static string mHoTen = "";
        public static int mChiNhanh = 0;

        public static BindingSource bds_dspm = new BindingSource();

        public static FormMain formMain;

        public static int KetNoi()
        {
            if(conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                connstr = "Data Source="+servername+
                    ";Initial Catalog=" + database +
                                    ";User ID=" + login +
                                    ";Pwd=" + password;

                conn.ConnectionString = connstr;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối csdl.\nBạn xem lại username và password.\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader execSqlDataReader(string query)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(query, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if(conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch(Exception e)
            {
                conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataTable execDataTable(string query)
        {
            DataTable dataTable = new DataTable();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dataTable);
            conn.Close();
            return dataTable;
        }

        public static int execSqlNonQuery(string query)
        {
            SqlCommand sqlcmd = new SqlCommand(query, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
                return e.State;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain();
            Application.Run(formMain);
        }
    }
}
