using PBO_Gymly.JadwalGym;
using PBO_Gymly.Pembayaran;
using PBO_Gymly.ProfilCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Gymly
{
    public partial class HomepageCustomer : Form
    {
        private int idCustomer;

        public HomepageCustomer(int id)
        {
            InitializeComponent();
            idCustomer = id;
        }

        private void Button_Jadwal_Click(object sender, EventArgs e)
        {
            // Kirim id_customer ke form TampilanJadwal
            TampilanJadwal tampilanJadwal = new TampilanJadwal(idCustomer);
            tampilanJadwal.Show();
            this.Hide();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Button_Profil_Click(object sender, EventArgs e)
        {
            // Kirim id_customer ke form TampilanProfil
            TampilanProfil tampilanProfil = new TampilanProfil(idCustomer);
            tampilanProfil.Show();
            this.Hide();
        }

        private void Button_Pembayaran_Click(object sender, EventArgs e)
        {
            RiwayatPembayaran riwayatpembayaran = new RiwayatPembayaran(idCustomer);
            riwayatpembayaran.Show();
            this.Hide();
        }
    }
}