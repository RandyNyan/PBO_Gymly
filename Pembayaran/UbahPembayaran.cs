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
    public partial class UbahPembayaran : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";
        private int idPembayaran;
        public UbahPembayaran(int selectedId)
        {
            InitializeComponent();
            this.idPembayaran = selectedId;
            LoadPembayaranData();

        }
        private void UbahPembayaran_Load(object sender, EventArgs e)
        {
            comboBoxmetod.Items.AddRange(new[] { "Transfer Bank", "E-Wallet" });
            comboBoxstatus.Items.AddRange(new[] { "sudah bayar", "belum bayar" });
        }
        private void LoadPembayaranData()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT metode_pembayaran, jumlah_pembayaran, status_pembayaran, id_profil, id_membership FROM pembayaran WHERE id_pembayaran = @id_pembayaran";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id_pembayaran", idPembayaran);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox_jumlah.Text = reader["jumlah_pembayaran"].ToString();
                                comboBoxmetod.SelectedItem = reader["metode_pembayaran"].ToString();
                                comboBoxstatus.SelectedItem = reader["status_pembayaran"].ToString();
                                textBoxidprofil.Text = reader["id_profil"].ToString();
                                textBoxidmembership.Text = reader["id_membership"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal memuat data pembayaran: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string updateQuery = @"UPDATE pembayaran 
                                           SET metode_pembayaran = @metode, 
                                               jumlah_pembayaran = @jumlah,
                                               status_pembayaran = @status_pembayaran,
                                               id_profil = @id_profil, 
                                               id_membership = @id_membership 
                                           WHERE id_pembayaran = @id_pembayaran";

                    using (var cmd = new NpgsqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@metode", comboBoxmetod.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@status_pembayaran", comboBoxstatus.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@jumlah", Convert.ToDecimal(textBox_jumlah.Text));
                        cmd.Parameters.AddWithValue("@id_profil", Convert.ToInt32(textBoxidprofil.Text));
                        cmd.Parameters.AddWithValue("@id_membership", Convert.ToInt32(textBoxidmembership.Text));
                        cmd.Parameters.AddWithValue("@id_pembayaran", idPembayaran);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data pembayaran berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Gagal memperbarui data pembayaran.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
