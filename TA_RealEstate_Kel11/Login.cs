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

namespace TA_RealEstate_Kel11
{
    public partial class FormLogin : Form
    {
        private string username = "";
        private string password = "";
        private string nama = "";
        private string jabatan = "";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           /* checkLogin();

            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Gagal", "Username atau Password salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormLogin dash = new FormLogin(nama, jabatan);
                dash.Visible = true;
                this.Visible = false;
            }*/
        }

        /*public void checkLogin()
        {
            SqlConnection connection = Program.koneksi();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Pengguna WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
            command.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                username = dr["Username"].ToString();
                password = dr["Password"].ToString();
                nama = dr["Nama_User"].ToString();
                jabatan = dr["Hak_Akses"].ToString();
            }
            connection.Close();
        }*/
    }
}
