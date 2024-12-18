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

namespace PBO_Gymly.Pembayaran
{
    public partial class RiwayatPembayaranAdmin : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";
        public RiwayatPembayaranAdmin()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM pembayaran";
                    using (var adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();

            homepage.Show();

            this.Hide();
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_pembayaran"].Value);
                UbahPembayaran form3 = new UbahPembayaran(selectedId);
                form3.ShowDialog();

                LoadData();
            }
            else
            {
                MessageBox.Show("Pilih pembayaran yang ingin diubah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
