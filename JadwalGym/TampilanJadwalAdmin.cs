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

namespace PBO_Gymly.JadwalGym
{
    public partial class TampilanJadwalAdmin : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";
        public TampilanJadwalAdmin()
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
                    string query = "SELECT * FROM Jadwal_gym ORDER BY Tanggal";
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
        private void TampilanJadwalAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();

            homepage.Show();

            this.Hide();
        }
    }
}
