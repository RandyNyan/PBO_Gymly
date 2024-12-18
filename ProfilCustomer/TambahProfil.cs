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

namespace PBO_Gymly.ProfilCustomer
{
    public partial class TambahProfil : Form
    {
        private int idcustomer;
        public TambahProfil(int id)
        {
            InitializeComponent();
            idcustomer = id;
        }
        private void Button_Simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxNama.Text) ||
                string.IsNullOrWhiteSpace(TextBoxAlamat.Text) ||
                string.IsNullOrWhiteSpace(TextBoxNotel.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var profilbaru = new Struktur_Profil
            {
                naleng_customer = TextBoxNama.Text,
                alamat_customer = TextBoxAlamat.Text,
                notel_customer = TextBoxNotel.Text,
                id_akun = idcustomer
            };

            try
            {
                BagianProfil.AddProfil(profilbaru);
                MessageBox.Show("Profil berhasil ditambahkan!", "Suksaes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxNama.Clear();
                TextBoxAlamat.Clear();
                TextBoxNotel.Clear();
                
                TampilanProfil tampilanprofil = new TampilanProfil(idcustomer);

                tampilanprofil.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menambahkan profil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Kembali_Click(object sender, EventArgs e)
        {
            TampilanProfil tampilanprofil = new TampilanProfil(idcustomer);

            tampilanprofil.Show();

            this.Hide();
        }
    }
}
