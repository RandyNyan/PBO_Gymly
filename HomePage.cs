using PBO_Gymly.JadwalGym;
using PBO_Gymly.Pembayaran;
using PBO_Gymly.Status_Membership;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void ButtonFasilitasGym_Click(object sender, EventArgs e)
        {
            FasilitasGym fasilitas_gym = new FasilitasGym();

            fasilitas_gym.Show();

            this.Hide();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
        }

        private void Button_JadwalAdmin_Click(object sender, EventArgs e)
        {
            TampilanJadwalAdmin tampilanjadwaladmin = new TampilanJadwalAdmin();

            tampilanjadwaladmin.Show();

            this.Hide();
        }

        private void Button_Status_Click(object sender, EventArgs e)
        {
            Tampilanstatus perubahanstatus = new Tampilanstatus();

            perubahanstatus.Show();

            this.Hide();
        }

        private void ButtonPembayaran_Click(object sender, EventArgs e)
        {
            RiwayatPembayaranAdmin pembayaranadmin = new RiwayatPembayaranAdmin();

            pembayaranadmin.Show();

            this.Hide();
        }
    }
}
