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

namespace PBO_Gymly
{
    public partial class FasilitasGym : Form
    {
        public FasilitasGym()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();

            homepage.Show();

            this.Hide();
        }

        private void ButtonAddFasilitasGym_Click(object sender, EventArgs e)
        {
            AddFasilitasGym addfasilitasgym = new AddFasilitasGym(this);

            addfasilitasgym.Show();
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (DataGridView_FasilitasGym.SelectedRows.Count > 0)
            {
                var row = DataGridView_FasilitasGym.SelectedRows[0];
                int idFasilitas = Convert.ToInt32(row.Cells["id_fasilitas_gym"].Value);

                // Ambil data lainnya dari baris yang dipilih
                string namaFasilitas = row.Cells["nama_fasilitas"].Value.ToString();
                string jumlahFasilitas = row.Cells["jumlah_fasilitas"].Value.ToString();
                string fasilitasBaik = row.Cells["fasilitas_baik"].Value.ToString();
                string fasilitasRusak = row.Cells["fasilitas_rusak"].Value.ToString();

                ChangeFasilitasGym changeFasilitasGym = new ChangeFasilitasGym(idFasilitas, namaFasilitas, jumlahFasilitas, fasilitasBaik, fasilitasRusak, this);
                changeFasilitasGym.Show();
            }
            else
            {
                MessageBox.Show("Silakan pilih fasilitas yang ingin diubah.");
            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (DataGridView_FasilitasGym.SelectedRows.Count > 0)
            {
                var row = DataGridView_FasilitasGym.SelectedRows[0];
                int idFasilitas = Convert.ToInt32(row.Cells["id_fasilitas_gym"].Value);

                // Konfirmasi penghapusan
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus fasilitas ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        BagianFasilitasGym.DeleteFasilitasGym(idFasilitas);

                        LoadDataFasilitasGym();
                        MessageBox.Show("Fasilitas berhasil dihapus.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting data: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih fasilitas yang ingin dihapus.");
            }
        }

        private void FasilitasGym_Load(object sender, EventArgs e)
        {
            LoadDataFasilitasGym();
        }

        public void LoadDataFasilitasGym()
        {
            try
            {
                DataTable data = BagianFasilitasGym.All();
                DataGridView_FasilitasGym.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
