using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using PBO_Gymly.CRUD;
using PBO_Gymly.DataBase;
using PBO_Gymly.StrukturData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBO_Gymly
{
    public partial class AddFasilitasGym : Form
    {
        private FasilitasGym _parentForm;
        public AddFasilitasGym(FasilitasGym parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxNamaFasilitas.Text) ||
                string.IsNullOrWhiteSpace(TextBoxJumlahFasilitas.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fasilitasBaru = new Struktur_FasilitasGym
            {
                nama_fasilitas = TextBoxNamaFasilitas.Text,
                jumlah_fasilitas = int.Parse(TextBoxJumlahFasilitas.Text),
                fasilitas_baik = int.Parse(TextBoxJumlahFasilitas.Text),
                fasilitas_rusak = 0
            };

            try
            {
                BagianFasilitasGym.AddFasilitas(fasilitasBaru);
                MessageBox.Show("Fasilitas berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _parentForm.LoadDataFasilitasGym();
                TextBoxNamaFasilitas.Clear();
                TextBoxJumlahFasilitas.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menambahkan fasilitas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

    }
}
