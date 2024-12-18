﻿using Npgsql;
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
    public partial class TampilanJadwal : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";
        private int lastUpdatedId;
        private int idCustomer;

        public TampilanJadwal(int id)
        {
            InitializeComponent();
            LoadData();
            idCustomer = id;
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

        private void TampilanJadwal_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void TambahJadwal(string hari, string tanggal, string jenisAktivitas, string waktuLatihan)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Jadwal_gym (Nama_hari, Tanggal, Nama_aktivitas, Waktu_latihan) VALUES (@Nama_hari, @Tanggal, @Nama_aktivitas, @Waktu_latihan)";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("Nama_hari", hari);
                        cmd.Parameters.AddWithValue("tanggal", tanggal);
                        cmd.Parameters.AddWithValue("Jenis_aktivitas", jenisAktivitas);
                        cmd.Parameters.AddWithValue("Waktu_latihan", waktuLatihan);

                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NambahJadwal form2 = new NambahJadwal(idCustomer);
            this.Hide();
            form2.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_jadwal"].Value);
                UbahJadwal form3 = new UbahJadwal(selectedId, idCustomer);
                form3.ShowDialog();

                LoadData();
            }
            else
            {
                MessageBox.Show("Pilih jadwal yang ingin diubah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomepageCustomer homepagecustomer = new HomepageCustomer(idCustomer);
            
            this.Hide();

            homepagecustomer.Show();
        }

        public void RefreshDataGridView()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Jadwal_gym";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (Convert.ToInt32(row.Cells["id_jadwal"].Value) == lastUpdatedId)
                                {
                                    row.Selected = true;
                                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}