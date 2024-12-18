using Npgsql;
using PBO_Gymly.JadwalGym;
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

namespace PBO_Gymly
{
    public partial class NambahJadwal : Form
    {
        private int idCustomer;
        private string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";
        public NambahJadwal(int id)
        {
            InitializeComponent();
            idCustomer = id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Harap lengkapi semua field!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Jadwal_gym (Nama_hari, Tanggal, Nama_aktivitas, Waktu_latihan) VALUES (@Nama_hari, @Tanggal, @Jenis_aktivitas, @Waktu_latihan)";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("Nama_hari", comboBox1.Text);
                        cmd.Parameters.AddWithValue("Tanggal", textBox1.Text);
                        cmd.Parameters.AddWithValue("Jenis_aktivitas", comboBox2.Text);
                        cmd.Parameters.AddWithValue("Waktu_latihan", GetSelectedTime());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenForm2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenForm2()
        {
            TampilanJadwal tambahjadwal = new TampilanJadwal(idCustomer);
            this.Hide();
            tambahjadwal.Show();
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

        private void NambahJadwal_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new[] { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" });
            comboBox2.Items.AddRange(new[] { "Cardio", "Arm Day", "Leg Day", "Back Day", "Chest Day", "Shoulder Day", "Rest" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TampilanJadwal tambahjadwal2 = new TampilanJadwal(idCustomer);
            this.Hide();
            tambahjadwal2.Show();
        }
    }
}
