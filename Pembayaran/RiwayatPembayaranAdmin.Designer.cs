namespace PBO_Gymly.Pembayaran
{
    partial class RiwayatPembayaranAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiwayatPembayaranAdmin));
            label1 = new Label();
            ButtonUbah = new Button();
            ButtonBack = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Anton", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(185, 15);
            label1.Name = "label1";
            label1.Size = new Size(435, 83);
            label1.TabIndex = 12;
            label1.Text = "Riwayat Pembayaran";
            // 
            // ButtonUbah
            // 
            ButtonUbah.BackColor = Color.FromArgb(127, 200, 248);
            ButtonUbah.FlatAppearance.BorderSize = 0;
            ButtonUbah.FlatStyle = FlatStyle.Flat;
            ButtonUbah.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonUbah.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonUbah.Location = new Point(712, 405);
            ButtonUbah.Name = "ButtonUbah";
            ButtonUbah.Size = new Size(65, 30);
            ButtonUbah.TabIndex = 11;
            ButtonUbah.Text = "Ubah";
            ButtonUbah.UseVisualStyleBackColor = true;
            ButtonUbah.Click += ButtonUbah_Click;
            // 
            // ButtonBack
            // 
            ButtonBack.BackColor = Color.FromArgb(127, 200, 248);
            ButtonBack.FlatAppearance.BorderSize = 0;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonBack.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonBack.Location = new Point(23, 405);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(60, 30);
            ButtonBack.TabIndex = 10;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(66, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(651, 246);
            dataGridView1.TabIndex = 9;
            // 
            // RiwayatPembayaranAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ButtonUbah);
            Controls.Add(ButtonBack);
            Controls.Add(dataGridView1);
            Name = "RiwayatPembayaranAdmin";
            Text = "RiwayatPembayaranAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ButtonUbah;
        private Button ButtonBack;
        private DataGridView dataGridView1;
    }
}