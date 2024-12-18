using Npgsql;
using PBO_Gymly.CRUD;
using PBO_Gymly.Pembayaran;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Gymly.Status_Membership
{
    public partial class Tampilanstatus : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";
        public Tampilanstatus()
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
                    string query = @"
                SELECT 
                    sm.id_status, 
                    sm.status, 
                    pc.Naleng_customer,
                    m.Jenis_membership
                FROM
                    Status_Membership sm
                JOIN
                    Profil_customer pc ON sm.id_profil = pc.id_profil
                JOIN
                    Membership m ON sm.id_membership = m.id_membership";
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

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_status"].Value);
                UbahStatus form3 = new UbahStatus(selectedId);
                form3.ShowDialog();

                LoadData();
            }
            else
            {
                MessageBox.Show("Pilih status yang ingin diubah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            TambahStatus tambahstatus = new TambahStatus();
            
            tambahstatus.Show();
            
            this.Hide();
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();

            homepage.Show();
            
            this.Hide();
        }
        private void Status_Load(object sender, EventArgs e)
        {
            LoadDataStatus();
        }

        public void LoadDataStatus()
        {
            try
            {
                DataTable data = BagianStatus.All();
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
