namespace PBO_Gymly.Status_Membership
{
    partial class UbahStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbahStatus));
            LabelFasilitasBaik = new Label();
            TextBoxtJenis = new TextBox();
            LabelJumlahFasilitas = new Label();
            TextBoxtNama = new TextBox();
            LabelNamaFasilitas = new Label();
            ButtonChange = new Button();
            ButtonCancel = new Button();
            comboBoxstatus = new ComboBox();
            SuspendLayout();
            // 
            // LabelFasilitasBaik
            // 
            LabelFasilitasBaik.AutoSize = true;
            LabelFasilitasBaik.BackColor = Color.Transparent;
            LabelFasilitasBaik.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LabelFasilitasBaik.ForeColor = Color.Black;
            LabelFasilitasBaik.Location = new Point(28, 181);
            LabelFasilitasBaik.Name = "LabelFasilitasBaik";
            LabelFasilitasBaik.Size = new Size(67, 28);
            LabelFasilitasBaik.TabIndex = 16;
            LabelFasilitasBaik.Text = "Status";
            // 
            // TextBoxtJenis
            // 
            TextBoxtJenis.BackColor = Color.White;
            TextBoxtJenis.BorderStyle = BorderStyle.None;
            TextBoxtJenis.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxtJenis.ForeColor = Color.Black;
            TextBoxtJenis.Location = new Point(28, 129);
            TextBoxtJenis.Name = "TextBoxtJenis";
            TextBoxtJenis.Size = new Size(250, 24);
            TextBoxtJenis.TabIndex = 15;
            // 
            // LabelJumlahFasilitas
            // 
            LabelJumlahFasilitas.AutoSize = true;
            LabelJumlahFasilitas.BackColor = Color.Transparent;
            LabelJumlahFasilitas.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LabelJumlahFasilitas.ForeColor = Color.Black;
            LabelJumlahFasilitas.Location = new Point(28, 98);
            LabelJumlahFasilitas.Name = "LabelJumlahFasilitas";
            LabelJumlahFasilitas.Size = new Size(178, 28);
            LabelJumlahFasilitas.TabIndex = 14;
            LabelJumlahFasilitas.Text = "Jenis Membership";
            // 
            // TextBoxtNama
            // 
            TextBoxtNama.BackColor = Color.White;
            TextBoxtNama.BorderStyle = BorderStyle.None;
            TextBoxtNama.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxtNama.ForeColor = Color.Black;
            TextBoxtNama.Location = new Point(28, 44);
            TextBoxtNama.Name = "TextBoxtNama";
            TextBoxtNama.Size = new Size(250, 24);
            TextBoxtNama.TabIndex = 13;
            // 
            // LabelNamaFasilitas
            // 
            LabelNamaFasilitas.AutoSize = true;
            LabelNamaFasilitas.BackColor = Color.Transparent;
            LabelNamaFasilitas.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LabelNamaFasilitas.ForeColor = Color.Black;
            LabelNamaFasilitas.Location = new Point(28, 13);
            LabelNamaFasilitas.Name = "LabelNamaFasilitas";
            LabelNamaFasilitas.Size = new Size(159, 28);
            LabelNamaFasilitas.TabIndex = 12;
            LabelNamaFasilitas.Text = "Nama Customer";
            // 
            // ButtonChange
            // 
            ButtonChange.BackColor = Color.FromArgb(45, 48, 71);
            ButtonChange.FlatAppearance.BorderSize = 0;
            ButtonChange.FlatStyle = FlatStyle.Flat;
            ButtonChange.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonChange.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonChange.Location = new Point(325, 393);
            ButtonChange.Name = "ButtonChange";
            ButtonChange.Size = new Size(63, 36);
            ButtonChange.TabIndex = 11;
            ButtonChange.Text = "Change";
            ButtonChange.UseVisualStyleBackColor = true;
            ButtonChange.Click += ButtonChange_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.FromArgb(45, 48, 71);
            ButtonCancel.FlatAppearance.BorderSize = 0;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonCancel.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonCancel.Location = new Point(256, 393);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(63, 36);
            ButtonCancel.TabIndex = 10;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // comboBoxstatus
            // 
            comboBoxstatus.FormattingEnabled = true;
            comboBoxstatus.Location = new Point(28, 212);
            comboBoxstatus.Name = "comboBoxstatus";
            comboBoxstatus.Size = new Size(121, 23);
            comboBoxstatus.TabIndex = 17;
            // 
            // UbahStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(400, 450);
            Controls.Add(comboBoxstatus);
            Controls.Add(LabelFasilitasBaik);
            Controls.Add(TextBoxtJenis);
            Controls.Add(LabelJumlahFasilitas);
            Controls.Add(TextBoxtNama);
            Controls.Add(LabelNamaFasilitas);
            Controls.Add(ButtonChange);
            Controls.Add(ButtonCancel);
            Name = "UbahStatus";
            Text = "UbahStatus";
            Load += UbahStatus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelFasilitasBaik;
        private TextBox TextBoxtJenis;
        private Label LabelJumlahFasilitas;
        private TextBox TextBoxtNama;
        private Label LabelNamaFasilitas;
        private Button ButtonChange;
        private Button ButtonCancel;
        private ComboBox comboBoxstatus;
    }
}