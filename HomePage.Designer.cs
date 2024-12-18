namespace PBO_Gymly
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            ButtonFasilitasGym = new Button();
            ButtonLogout = new Button();
            Button_JadwalAdmin = new Button();
            Button_Status = new Button();
            ButtonPembayaran = new Button();
            SuspendLayout();
            // 
            // ButtonFasilitasGym
            // 
            ButtonFasilitasGym.BackColor = Color.FromArgb(127, 200, 248);
            ButtonFasilitasGym.FlatAppearance.BorderSize = 0;
            ButtonFasilitasGym.FlatStyle = FlatStyle.Flat;
            ButtonFasilitasGym.Font = new Font("Anton", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonFasilitasGym.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonFasilitasGym.Location = new Point(525, 63);
            ButtonFasilitasGym.Name = "ButtonFasilitasGym";
            ButtonFasilitasGym.Size = new Size(201, 40);
            ButtonFasilitasGym.TabIndex = 0;
            ButtonFasilitasGym.Text = "Fasilitas Gym";
            ButtonFasilitasGym.UseVisualStyleBackColor = true;
            ButtonFasilitasGym.Click += ButtonFasilitasGym_Click;
            // 
            // ButtonLogout
            // 
            ButtonLogout.BackColor = Color.FromArgb(127, 200, 248);
            ButtonLogout.FlatAppearance.BorderSize = 0;
            ButtonLogout.FlatStyle = FlatStyle.Flat;
            ButtonLogout.Font = new Font("Anton", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonLogout.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonLogout.Location = new Point(525, 382);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(201, 40);
            ButtonLogout.TabIndex = 1;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = true;
            ButtonLogout.Click += ButtonLogout_Click;
            // 
            // Button_JadwalAdmin
            // 
            Button_JadwalAdmin.BackColor = Color.FromArgb(127, 200, 248);
            Button_JadwalAdmin.FlatAppearance.BorderSize = 0;
            Button_JadwalAdmin.FlatStyle = FlatStyle.Flat;
            Button_JadwalAdmin.Font = new Font("Anton", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_JadwalAdmin.ForeColor = Color.FromArgb(249, 249, 249);
            Button_JadwalAdmin.Location = new Point(525, 128);
            Button_JadwalAdmin.Name = "Button_JadwalAdmin";
            Button_JadwalAdmin.Size = new Size(201, 40);
            Button_JadwalAdmin.TabIndex = 2;
            Button_JadwalAdmin.Text = "Jadwal Gym";
            Button_JadwalAdmin.UseVisualStyleBackColor = true;
            Button_JadwalAdmin.Click += Button_JadwalAdmin_Click;
            // 
            // Button_Status
            // 
            Button_Status.BackColor = Color.FromArgb(127, 200, 248);
            Button_Status.FlatAppearance.BorderSize = 0;
            Button_Status.FlatStyle = FlatStyle.Flat;
            Button_Status.Font = new Font("Anton", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Status.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Status.Location = new Point(525, 197);
            Button_Status.Name = "Button_Status";
            Button_Status.Size = new Size(201, 40);
            Button_Status.TabIndex = 3;
            Button_Status.Text = "Status Membership";
            Button_Status.UseVisualStyleBackColor = true;
            Button_Status.Click += Button_Status_Click;
            // 
            // ButtonPembayaran
            // 
            ButtonPembayaran.BackColor = Color.FromArgb(127, 200, 248);
            ButtonPembayaran.FlatAppearance.BorderSize = 0;
            ButtonPembayaran.FlatStyle = FlatStyle.Flat;
            ButtonPembayaran.Font = new Font("Anton", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonPembayaran.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonPembayaran.Location = new Point(525, 263);
            ButtonPembayaran.Name = "ButtonPembayaran";
            ButtonPembayaran.Size = new Size(201, 40);
            ButtonPembayaran.TabIndex = 4;
            ButtonPembayaran.Text = "Pembayaran";
            ButtonPembayaran.UseVisualStyleBackColor = true;
            ButtonPembayaran.Click += ButtonPembayaran_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonPembayaran);
            Controls.Add(Button_Status);
            Controls.Add(Button_JadwalAdmin);
            Controls.Add(ButtonLogout);
            Controls.Add(ButtonFasilitasGym);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonFasilitasGym;
        private Button ButtonLogout;
        private Button Button_JadwalAdmin;
        private Button Button_Status;
        private Button ButtonPembayaran;
    }
}