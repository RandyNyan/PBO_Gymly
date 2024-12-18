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

namespace PBO_Gymly.Pembayaran
{
    public partial class RiwayatPembayaran : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";
        private int idCustomer;
        private int idProfil; // Variabel untuk menyimpan id_profil

        public RiwayatPembayaran(int id)
        {
            InitializeComponent();
            idCustomer = id;

            // Ambil id_profil berdasarkan id_customer
            idProfil = GetIdProfil(idCustomer);

            if (idProfil != 0)
            {
                // Load data pembayaran berdasarkan id_profil
                LoadDataByIdProfil(idProfil);
            }
            else
            {
                MessageBox.Show("ID profil tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Metode 1: Mengambil id_profil berdasarkan id_customer
        private int GetIdProfil(int id_customer)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_profil FROM profil_customer WHERE id_customer = @id_customer";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_customer", id_customer);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result); // Kembalikan id_profil
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan saat mengambil id_profil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return 0; // Jika id_profil tidak ditemukan
        }

        // Metode 2: Load data pembayaran berdasarkan id_profil
        private void LoadDataByIdProfil(int id_profil)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM pembayaran WHERE id_profil = @id_profil";

                    using (var adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@id_profil", id_profil);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan saat memuat data pembayaran: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            HomepageCustomer homepagecustomer = new HomepageCustomer(idCustomer);
            homepagecustomer.Show();
            this.Hide();
        }

        private void ButtonAddFasilitasGym_Click(object sender, EventArgs e)
        {
            TambahPembayaran tambahpembayaran = new TambahPembayaran(idCustomer);
            tambahpembayaran.Show();
            this.Hide();
        }
    }
}