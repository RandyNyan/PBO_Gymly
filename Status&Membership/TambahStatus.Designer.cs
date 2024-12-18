namespace PBO_Gymly.Status_Membership
{
    partial class TambahStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahStatus));
            comboBoxstatus = new ComboBox();
            LabelFasilitasBaik = new Label();
            LabelJumlahFasilitas = new Label();
            TextBoxtNama = new TextBox();
            LabelNamaFasilitas = new Label();
            ButtonSimpan = new Button();
            ButtonCancel = new Button();
            comboBoxJenis = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxstatus
            // 
            comboBoxstatus.FormattingEnabled = true;
            comboBoxstatus.Location = new Point(12, 215);
            comboBoxstatus.Name = "comboBoxstatus";
            comboBoxstatus.Size = new Size(121, 23);
            comboBoxstatus.TabIndex = 25;
            // 
            // LabelFasilitasBaik
            // 
            LabelFasilitasBaik.AutoSize = true;
            LabelFasilitasBaik.BackColor = Color.Transparent;
            LabelFasilitasBaik.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LabelFasilitasBaik.ForeColor = Color.Black;
            LabelFasilitasBaik.Location = new Point(12, 184);
            LabelFasilitasBaik.Name = "LabelFasilitasBaik";
            LabelFasilitasBaik.Size = new Size(67, 28);
            LabelFasilitasBaik.TabIndex = 24;
            LabelFasilitasBaik.Text = "Status";
            // 
            // LabelJumlahFasilitas
            // 
            LabelJumlahFasilitas.AutoSize = true;
            LabelJumlahFasilitas.BackColor = Color.Transparent;
            LabelJumlahFasilitas.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LabelJumlahFasilitas.ForeColor = Color.Black;
            LabelJumlahFasilitas.Location = new Point(12, 101);
            LabelJumlahFasilitas.Name = "LabelJumlahFasilitas";
            LabelJumlahFasilitas.Size = new Size(178, 28);
            LabelJumlahFasilitas.TabIndex = 22;
            LabelJumlahFasilitas.Text = "Jenis Membership";
            // 
            // TextBoxtNama
            // 
            TextBoxtNama.BackColor = Color.White;
            TextBoxtNama.BorderStyle = BorderStyle.None;
            TextBoxtNama.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxtNama.ForeColor = Color.Black;
            TextBoxtNama.Location = new Point(12, 47);
            TextBoxtNama.Name = "TextBoxtNama";
            TextBoxtNama.Size = new Size(250, 24);
            TextBoxtNama.TabIndex = 21;
            // 
            // LabelNamaFasilitas
            // 
            LabelNamaFasilitas.AutoSize = true;
            LabelNamaFasilitas.BackColor = Color.Transparent;
            LabelNamaFasilitas.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LabelNamaFasilitas.ForeColor = Color.Black;
            LabelNamaFasilitas.Location = new Point(12, 16);
            LabelNamaFasilitas.Name = "LabelNamaFasilitas";
            LabelNamaFasilitas.Size = new Size(159, 28);
            LabelNamaFasilitas.TabIndex = 20;
            LabelNamaFasilitas.Text = "Nama Customer";
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.BackColor = Color.FromArgb(45, 48, 71);
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonSimpan.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonSimpan.Location = new Point(309, 396);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(63, 36);
            ButtonSimpan.TabIndex = 19;
            ButtonSimpan.Text = "Simpan";
            ButtonSimpan.UseVisualStyleBackColor = true;
            ButtonSimpan.Click += ButtonSimpan_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.FromArgb(45, 48, 71);
            ButtonCancel.FlatAppearance.BorderSize = 0;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonCancel.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonCancel.Location = new Point(235, 396);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(68, 36);
            ButtonCancel.TabIndex = 18;
            ButtonCancel.Text = "Kembali";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // comboBoxJenis
            // 
            comboBoxJenis.FormattingEnabled = true;
            comboBoxJenis.Location = new Point(12, 132);
            comboBoxJenis.Name = "comboBoxJenis";
            comboBoxJenis.Size = new Size(121, 23);
            comboBoxJenis.TabIndex = 26;
            // 
            // TambahStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(400, 450);
            Controls.Add(comboBoxJenis);
            Controls.Add(comboBoxstatus);
            Controls.Add(LabelFasilitasBaik);
            Controls.Add(LabelJumlahFasilitas);
            Controls.Add(TextBoxtNama);
            Controls.Add(LabelNamaFasilitas);
            Controls.Add(ButtonSimpan);
            Controls.Add(ButtonCancel);
            Name = "TambahStatus";
            Text = "TambahStatus";
            Load += TambahStatus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxstatus;
        private Label LabelFasilitasBaik;
        private Label LabelJumlahFasilitas;
        private TextBox TextBoxtNama;
        private Label LabelNamaFasilitas;
        private Button ButtonSimpan;
        private Button ButtonCancel;
        private ComboBox comboBoxJenis;
    }
}