using Npgsql;
using PBO_Gymly.CRUD;
using PBO_Gymly.StrukturData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PBO_Gymly.Status_Membership
{
    public partial class UbahStatus : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=1412;Database=Database_Gymly";
        private int idstatus;
        public UbahStatus(int selectedId)
        {
            InitializeComponent();
            this.idstatus = selectedId;
            LoadStatusData();
        }
        private void UbahStatus_Load(object sender, EventArgs e)
        {
            comboBoxstatus.Items.AddRange(new[] { "Aktif", "Tidak AKtif" });
        }
        private void LoadStatusData()
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

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id_status", idstatus);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TextBoxtNama.Text = reader["Naleng_customer"].ToString();
                                TextBoxtJenis.Text = reader["Jenis_membership"].ToString();
                                comboBoxstatus.SelectedItem = reader["status"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal memuat data status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonChange_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string updateQuery = @"
                UPDATE Status_Membership 
                SET 
                    status = @status,
                    id_profil = @id_profil, 
                    id_membership = @id_membership 
                WHERE id_status = @id_status";  // Using id_status to match the record to update

                    using (var cmd = new NpgsqlCommand(updateQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@status", comboBoxstatus.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@id_profil", GetProfilId(TextBoxtNama.Text)); 
                        cmd.Parameters.AddWithValue("@id_membership", GetMembershipId(TextBoxtJenis.Text)); 
                        cmd.Parameters.AddWithValue("@id_status", idstatus); 

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data status berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Gagal memperbarui data status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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