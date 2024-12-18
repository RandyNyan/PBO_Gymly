namespace PBO_Gymly
{
    partial class HomepageCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageCustomer));
            Button_Jadwal = new Button();
            ButtonLogout = new Button();
            Button_Profil = new Button();
            Button_Pembayaran = new Button();
            SuspendLayout();
            // 
            // Button_Jadwal
            // 
            Button_Jadwal.BackColor = Color.FromArgb(127, 200, 248);
            Button_Jadwal.FlatAppearance.BorderSize = 0;
            Button_Jadwal.FlatStyle = FlatStyle.Flat;
            Button_Jadwal.Font = new Font("Anton", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Jadwal.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Jadwal.Location = new Point(524, 153);
            Button_Jadwal.Name = "Button_Jadwal";
            Button_Jadwal.Size = new Size(201, 40);
            Button_Jadwal.TabIndex = 0;
            Button_Jadwal.Text = "Jadwal";
            Button_Jadwal.UseVisualStyleBackColor = true;
            Button_Jadwal.Click += Button_Jadwal_Click;
            // 
            // ButtonLogout
            // 
            ButtonLogout.BackColor = Color.FromArgb(127, 200, 248);
            ButtonLogout.FlatAppearance.BorderSize = 0;
            ButtonLogout.FlatStyle = FlatStyle.Flat;
            ButtonLogout.Font = new Font("Anton", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonLogout.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonLogout.Location = new Point(524, 375);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(201, 40);
            ButtonLogout.TabIndex = 2;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = true;
            ButtonLogout.Click += ButtonLogout_Click;
            // 
            // Button_Profil
            // 
            Button_Profil.BackColor = Color.FromArgb(127, 200, 248);
            Button_Profil.FlatAppearance.BorderSize = 0;
            Button_Profil.FlatStyle = FlatStyle.Flat;
            Button_Profil.Font = new Font("Anton", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Profil.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Profil.Location = new Point(524, 82);
            Button_Profil.Name = "Button_Profil";
            Button_Profil.Size = new Size(201, 40);
            Button_Profil.TabIndex = 3;
            Button_Profil.Text = "Profil";
            Button_Profil.UseVisualStyleBackColor = true;
            Button_Profil.Click += Button_Profil_Click;
            // 
            // Button_Pembayaran
            // 
            Button_Pembayaran.BackColor = Color.FromArgb(127, 200, 248);
            Button_Pembayaran.FlatAppearance.BorderSize = 0;
            Button_Pembayaran.FlatStyle = FlatStyle.Flat;
            Button_Pembayaran.Font = new Font("Anton", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Pembayaran.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Pembayaran.Location = new Point(524, 230);
            Button_Pembayaran.Name = "Button_Pembayaran";
            Button_Pembayaran.Size = new Size(201, 40);
            Button_Pembayaran.TabIndex = 4;
            Button_Pembayaran.Text = "Pembayaran";
            Button_Pembayaran.UseVisualStyleBackColor = true;
            Button_Pembayaran.Click += Button_Pembayaran_Click;
            // 
            // HomepageCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(Button_Pembayaran);
            Controls.Add(Button_Profil);
            Controls.Add(ButtonLogout);
            Controls.Add(Button_Jadwal);
            Name = "HomepageCustomer";
            Text = "HomepageCustomer";
            ResumeLayout(false);
        }

        #endregion

        private Button Button_Jadwal;
        private Button ButtonLogout;
        private Button Button_Profil;
        private Button Button_Pembayaran;
    }
}