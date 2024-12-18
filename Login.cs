using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using PBO_Gymly.DataBase;
using static System.Windows.Forms.DataFormats;

namespace PBO_Gymly
{
    public partial class Login : Form
    {
        private int userId;

        public Login()
        {
            InitializeComponent();
        }
        private void Button_Login_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;

            // Validasi input kosong
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Data salah, isi kembali!");
                return;
            }

            // Ambil role dan id user
            int idUser;
            string role = GetUserRole(username, password, out idUser);

            if (role == "admin")
            {
                userId = idUser;
                HomePage homepage = new HomePage();
                homepage.Show();
                this.Hide();
            }
            else if (role == "customer")
            {
                userId = idUser;
                HomepageCustomer customerpage = new HomepageCustomer(userId); 
                customerpage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah, isi kembali!");
            }
        }

        private string GetUserRole(string username, string password, out int idUser)
        {
            idUser = -1; 
            string queryAdmin = "SELECT id_admin FROM Akun_admin WHERE Nama_admin = @Username AND Password_admin = @Password";
            string queryCustomer = "SELECT id_customer FROM Akun_customer WHERE Nama_customer = @Username AND Password_customer = @Password";

            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@Username", username),
                new NpgsqlParameter("@Password", password)
            };

            try
            {
                DataTable adminResult = Database_Gymly.queryExecutor(queryAdmin, parameters);
                if (adminResult.Rows.Count > 0)
                {
                    idUser = Convert.ToInt32(adminResult.Rows[0]["id_admin"]);
                    return "admin";
                }

                DataTable customerResult = Database_Gymly.queryExecutor(queryCustomer, parameters);
                if (customerResult.Rows.Count > 0)
                {
                    idUser = Convert.ToInt32(customerResult.Rows[0]["id_customer"]);
                    return "customer";
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return string.Empty;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Button_Regist_Click(object sender, EventArgs e)
        {
            Registrasi registrasi = new Registrasi();
            registrasi.Show();
            this.Hide();
        }
    }
}