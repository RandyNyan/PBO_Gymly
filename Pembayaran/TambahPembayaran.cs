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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBO_Gymly.Pembayaran
{
    public partial class TambahPembayaran : Form
    {
        private int idCustomer;
        private string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";
        public TambahPembayaran(int id)
        {
            InitializeComponent();
            idCustomer = id;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            RiwayatPembayaran riwayatpembayaran = new RiwayatPembayaran(idCustomer);

            riwayatpembayaran.Show();

            this.Hide();
        }

        private void TambahPembayaran_Load(object sender, EventArgs e)
        {
            comboBox_jenis.Items.AddRange(new[] { "Reguler", "VIP" });
            comboBoxmetod.Items.AddRange(new[] { "Transfer Banks", "E-Wallet" });
        }
        private int GetIdJenisMembership()
        {
            string selectedJenis = comboBox_jenis.SelectedItem?.ToString();
            int id_jenismembership = 0;
            if (selectedJenis == "Reguler")
            {
                id_jenismembership = 2;
            }
            else if (selectedJenis == "VIP")
            {
                id_jenismembership = 1;
            }
            else
            {
                MessageBox.Show("Jenis membership tidak valid atau belum dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return id_jenismembership;
        }

        private int GetIdProfil(int idCustomer)
        {
            int idProfil = 0;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id_profil FROM profil_customer WHERE id_customer = @idCustomer";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("idCustomer", idCustomer);

                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            idProfil = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Tidak ditemukan id_profil untuk id_customer tersebut.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return idProfil;
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(comboBox_jenis.Text) ||
                    string.IsNullOrEmpty(comboBoxmetod.Text) ||
                    string.IsNullOrEmpty(textBox_jumlah.Text))
                {
                    MessageBox.Show("Harap lengkapi semua field!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Simpan data ke database
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "INSERT INTO pembayaran (metode_pembayaran, jumlah_pembayaran, id_profil, id_membership) VALUES (@metode_pembayaran, @jumlah_pembayaran, @id_profil, @id_membership)";

                        using (var cmd = new NpgsqlCommand(query, connection))
                        {
                            string metodePembayaran = comboBoxmetod.Text;
                            int jumlahPembayaran = int.Parse(textBox_jumlah.Text);
                            int idProfil = GetIdProfil(idCustomer);
                            int idMembership = GetIdJenisMembership();

                            // Tambahkan parameter ke perintah SQL
                            cmd.Parameters.AddWithValue("metode_pembayaran", metodePembayaran);
                            cmd.Parameters.AddWithValue("jumlah_pembayaran", jumlahPembayaran);
                            cmd.Parameters.AddWithValue("id_profil", idProfil);
                            cmd.Parameters.AddWithValue("id_membership", idMembership);

                            // Eksekusi perintah
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Data pembayaran berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RiwayatPembayaran riwayatPembayaran = new RiwayatPembayaran(idCustomer);
                        riwayatPembayaran.Show();

                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void comboBoxmetod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}