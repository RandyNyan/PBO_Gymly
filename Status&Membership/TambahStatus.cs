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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBO_Gymly.Status_Membership
{
    public partial class TambahStatus : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";
        public TambahStatus()
        {
            InitializeComponent();
        }

        private void TambahStatus_Load(object sender, EventArgs e)
        {
            // Isi combobox hari
            comboBoxJenis.Items.AddRange(new[] { "Reguler", "VIP"});
            // Isi combobox jenis aktivitas
            comboBoxstatus.Items.AddRange(new[] { "Aktif", "Tidak Aktif"});
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Tampilanstatus tampilanstatus = new Tampilanstatus();
            this.Hide();
            tampilanstatus.Show();
        }

        public int GetProfilId(string nalengCustomer)
        {
            int idProfil = 0;

            string connString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT id_profil FROM Profil_customer WHERE Naleng_customer = @nalengCustomer";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nalengCustomer", nalengCustomer);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idProfil = reader.GetInt32(0);
                        }
                    }
                }
            }

            return idProfil;
        }

        public int GetMembershipId(string jenisMembership)
        {
            int idMembership = 0;

            string connString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT id_membership FROM Membership WHERE Jenis_membership = @jenisMembership";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@jenisMembership", jenisMembership);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idMembership = reader.GetInt32(0);
                        }
                    }
                }
            }
            return idMembership;
        }
        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(TextBoxtNama.Text) || string.IsNullOrEmpty(comboBoxJenis.Text) || string.IsNullOrEmpty(comboBoxstatus.Text))
                {
                    MessageBox.Show("Harap lengkapi semua field!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO Status_Membership(status, id_profil, id_membership) VALUES (@status, @id_profil, @id_membership)";
                        using (var cmd = new NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("id_profil", GetProfilId(TextBoxtNama.Text));
                            cmd.Parameters.AddWithValue("id_membership", GetMembershipId(comboBoxJenis.Text));
                            cmd.Parameters.AddWithValue("status", comboBoxstatus.Text);

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
        }
        private void OpenForm2()
        {
            Tampilanstatus tampilanstatus = new Tampilanstatus();
            this.Hide();
            tampilanstatus.Show();
        }
    }
}
