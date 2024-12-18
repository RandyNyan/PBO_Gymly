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
using static System.Windows.Forms.DataFormats;

namespace PBO_Gymly.JadwalGym
{
    public partial class UbahJadwal : Form
    {
        private int idCustomer;
        private string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";
        private int jadwalId;

        public UbahJadwal(int jadwalId, int id)
        {
            InitializeComponent();
            this.jadwalId = jadwalId;

            comboBox1.Items.AddRange(new[] { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" });
            comboBox2.Items.AddRange(new[] { "Cardio", "Arm Day", "Leg Day", "Back Day", "Chest Day", "Shoulder Day", "Rest" });
            idCustomer = id;
        }
        private void UbahJadwal_Load(object sender, EventArgs e)
        {
            LoadSelectedData();
        }

        private void LoadSelectedData()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Jadwal_gym WHERE id_jadwal = @id_jadwal";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("id_jadwal", jadwalId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Set nilai default ComboBox
                                comboBox1.SelectedItem = reader["Nama_hari"].ToString();
                                comboBox2.SelectedItem = reader["Nama_aktivitas"].ToString();

                                // Set nilai tanggal
                                textBox1.Text = reader["Tanggal"].ToString();

                                // Set radio button sesuai waktu latihan
                                string waktuLatihan = reader["Waktu_latihan"].ToString();
                                foreach (var control in this.Controls)
                                {
                                    if (control is RadioButton rb && rb.Text == waktuLatihan)
                                    {
                                        rb.Checked = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Data tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private string GetSelectedTime()
        {
            foreach (var control in this.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    return rb.Text;
                }
            }
            return string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string selectedTime = GetSelectedTime();

            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(selectedTime))
            {
                MessageBox.Show("Harap lengkapi semua field!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi perubahan
            DialogResult result = MessageBox.Show(
                "1. Perubahan jadwal hanya bisa dilakukan setiap satu minggu sekali.\n" +
                "2. Pastikan Anda benar-benar yakin ingin mengubah jadwal latihan.\n" +
                "3. Jadwal yang sudah diubah tidak bisa diubah lagi.\n\n" +
                "Apakah Anda yakin ingin melanjutkan?",
                "Konfirmasi Perubahan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                UpdateSchedule();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TampilanJadwal form1 = new TampilanJadwal(idCustomer);
            this.Hide();
            form1.Show();
        }

        private void UpdateSchedule()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Jadwal_gym SET Nama_hari = @Nama_hari,Tanggal = @Tanggal, Nama_aktivitas = @Nama_aktivitas, Waktu_latihan = @Waktu_latihan WHERE id_jadwal = @id_jadwal";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("Nama_hari", comboBox1.Text);
                        cmd.Parameters.AddWithValue("Tanggal", textBox1.Text);
                        cmd.Parameters.AddWithValue("Nama_aktivitas", comboBox2.Text);
                        cmd.Parameters.AddWithValue("Waktu_latihan", GetSelectedTime());
                        cmd.Parameters.AddWithValue("id_jadwal", jadwalId);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Jadwal berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}