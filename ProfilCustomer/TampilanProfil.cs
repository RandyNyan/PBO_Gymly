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

namespace PBO_Gymly.ProfilCustomer
{
    public partial class TampilanProfil : Form
    {
        private int idCustomer;
        private string namaCustomer;
        private string alamatCustomer;
        private string notelCustomer;
        public TampilanProfil(int id)
        {
            InitializeComponent();
            idCustomer = id;
        }

        private void Button_Tambah_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(namaCustomer) && !string.IsNullOrEmpty(alamatCustomer) && !string.IsNullOrEmpty(notelCustomer))
            {
                MessageBox.Show("Data profil sudah ada. Anda tidak dapat menambahkan data baru.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Jika data belum ada, buka form TambahProfil
                TambahProfil tambahprofil = new TambahProfil(idCustomer);
                tambahprofil.Show();
                this.Hide();
            }
        }

        private void Button_Ubah_Click(object sender, EventArgs e)
        {
            UbahProfil ubahprofil = new UbahProfil(idCustomer, namaCustomer, alamatCustomer, notelCustomer);
            ubahprofil.Show();
            this.Hide();
        }

        private void Button_Kembali_Click(object sender, EventArgs e)
        {
            HomepageCustomer homepagecustomer = new HomepageCustomer(idCustomer);
            homepagecustomer.Show();
            this.Hide();
        }

        private void TampilanProfil_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly;";
            string query = @"
        SELECT 
            naleng_customer, 
            alamat_customer, 
            notel_customer
        FROM profil_customer
        WHERE id_customer = @id_customer;";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_customer", idCustomer);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                namaCustomer = reader["naleng_customer"].ToString();
                                alamatCustomer = reader["alamat_customer"].ToString();
                                notelCustomer = reader["notel_customer"].ToString();

                                Label_Nama.Text = namaCustomer;
                                Label_Alamat.Text = alamatCustomer;
                                Label_Notel.Text = notelCustomer;
                            }
                            else
                            {
                                Label_Nama.Text = "Tidak ada data";
                                Label_Alamat.Text = "Tidak ada data";
                                Label_Notel.Text = "Tidak ada data";
                                MessageBox.Show("Data tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}