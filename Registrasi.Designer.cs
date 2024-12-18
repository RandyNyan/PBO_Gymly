namespace PBO_Gymly
{
    partial class Registrasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrasi));
            TextBoxUsername = new TextBox();
            textBox_Password = new TextBox();
            Label_Username = new Label();
            Password = new Label();
            Button_Daftar = new Button();
            button_exit = new Button();
            button_login = new Button();
            SuspendLayout();
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.BackColor = Color.White;
            TextBoxUsername.BorderStyle = BorderStyle.None;
            TextBoxUsername.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxUsername.ForeColor = Color.Black;
            TextBoxUsername.Location = new Point(518, 207);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(250, 24);
            TextBoxUsername.TabIndex = 2;
            // 
            // textBox_Password
            // 
            textBox_Password.BackColor = Color.White;
            textBox_Password.BorderStyle = BorderStyle.None;
            textBox_Password.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            textBox_Password.ForeColor = Color.Black;
            textBox_Password.Location = new Point(518, 288);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(250, 24);
            textBox_Password.TabIndex = 3;
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.BackColor = Color.Transparent;
            Label_Username.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Label_Username.ForeColor = Color.Black;
            Label_Username.Location = new Point(511, 174);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(104, 28);
            Label_Username.TabIndex = 0;
            Label_Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Password.ForeColor = Color.Black;
            Password.Location = new Point(511, 257);
            Password.Name = "Password";
            Password.Size = new Size(97, 28);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // Button_Daftar
            // 
            Button_Daftar.BackColor = Color.FromArgb(45, 48, 71);
            Button_Daftar.FlatAppearance.BorderSize = 0;
            Button_Daftar.FlatStyle = FlatStyle.Flat;
            Button_Daftar.Font = new Font("Anton", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Daftar.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Daftar.Location = new Point(606, 359);
            Button_Daftar.Name = "Button_Daftar";
            Button_Daftar.Size = new Size(77, 40);
            Button_Daftar.TabIndex = 4;
            Button_Daftar.Text = "Daftar";
            Button_Daftar.UseVisualStyleBackColor = true;
            Button_Daftar.Click += Button_Daftar_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.FromArgb(45, 48, 71);
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Anton", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_exit.ForeColor = Color.FromArgb(249, 249, 249);
            button_exit.Location = new Point(518, 359);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(77, 40);
            button_exit.TabIndex = 6;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_login
            // 
            button_login.BackColor = Color.FromArgb(45, 48, 71);
            button_login.FlatAppearance.BorderSize = 0;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.Font = new Font("Anton", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_login.ForeColor = Color.FromArgb(249, 249, 249);
            button_login.Location = new Point(692, 359);
            button_login.Name = "button_login";
            button_login.Size = new Size(77, 40);
            button_login.TabIndex = 7;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // Registrasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button_login);
            Controls.Add(button_exit);
            Controls.Add(Button_Daftar);
            Controls.Add(Password);
            Controls.Add(Label_Username);
            Controls.Add(textBox_Password);
            Controls.Add(TextBoxUsername);
            Name = "Registrasi";
            Text = "Registrasi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxUsername;
        private TextBox textBox_Password;
        private Label Label_Username;
        private Label Password;
        private Button Button_Daftar;
        private Button button_exit;
        private Button button_login;
    }
}