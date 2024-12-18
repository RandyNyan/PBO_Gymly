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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PBO_Gymly.ProfilCustomer
{
    public partial class UbahProfil : Form
    {
        private int idcustomer;
        private TampilanProfil parentForm;
        private string namaCustomer;
        private string alamatCustomer;
        private string notelCustomer;

        public UbahProfil(int id, string nama, string alamat, string notel)
        {
            InitializeComponent();
            this.idcustomer = id;

            idcustomer = id;
            namaCustomer = nama;
            alamatCustomer = alamat;
            notelCustomer = notel;

            TextBoxNama.Text = namaCustomer;
            TextBoxAlamat.Text = alamatCustomer;
            TextBoxNotel.Text = notelCustomer;
        }

        private void Button_Simpan_Click(object sender, EventArgs e)
        {
            try
            {
                string namacustomer = TextBoxNama.Text;
                string alamatcustomer = TextBoxAlamat.Text;
                string notelcustomer = TextBoxNotel.Text;

                Struktur_Profil profil = new Struktur_Profil
                {
                    id_akun = idcustomer,
                    naleng_customer = namacustomer,
                    alamat_customer = alamatcustomer,
                    notel_customer = notelcustomer
                };

                BagianProfil.UpdateProfil(profil);
                MessageBox.Show("Profil berhasil diperbarui.");
                
                TampilanProfil tampilanprofil = new TampilanProfil(idcustomer);

                tampilanprofil.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
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
