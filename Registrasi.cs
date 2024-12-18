using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Gymly
{
    public partial class Registrasi : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";
        public Registrasi()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
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

        private void Button_Daftar_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = textBox_Password.Text;

            // Validasi input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password harus diisi.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string checkUsernameQuery = "SELECT COUNT(*) FROM akun_customer WHERE nama_customer = @nama_customer";
                    using (var checkUsernameCmd = new NpgsqlCommand(checkUsernameQuery, conn))
                    {
                        checkUsernameCmd.Parameters.AddWithValue("nama_customer", username);
                        int usernameCount = Convert.ToInt32(checkUsernameCmd.ExecuteScalar());
                        if (usernameCount > 0)
                        {
                            MessageBox.Show("Username sudah digunakan. Silakan gunakan username lain.");
                            return;
                        }
                    }

                    string checkPasswordQuery = "SELECT COUNT(*) FROM akun_customer WHERE password_customer = @password_customer";
                    using (var checkPasswordCmd = new NpgsqlCommand(checkPasswordQuery, conn))
                    {
                        checkPasswordCmd.Parameters.AddWithValue("password_customer", password);
                        int passwordCount = Convert.ToInt32(checkPasswordCmd.ExecuteScalar());
                        if (passwordCount > 0)
                        {
                            MessageBox.Show("Password sudah digunakan. Silakan gunakan password lain.");
                            return;
                        }
                    }


                    string insertQuery = "INSERT INTO akun_customer (nama_customer, password_customer) VALUES (@nama_customer, @password_customer)";
                    using (var insertCmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("nama_customer", username);
                        insertCmd.Parameters.AddWithValue("password_customer", password);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registrasi berhasil!");

                Login login = new Login();
                login.Show();
                this.Hide();
            }
            catch (Npgsql.PostgresException ex) when (ex.SqlState == "23505")
            {
                MessageBox.Show("Username atau password sudah digunakan. Silakan gunakan data lain.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
        }
    }

}
