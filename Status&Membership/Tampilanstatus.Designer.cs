namespace PBO_Gymly.Status_Membership
{
    partial class Tampilanstatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tampilanstatus));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ButtonChange = new Button();
            ButtonAdd = new Button();
            ButtonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(171, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(453, 281);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Anton", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(411, 83);
            label1.TabIndex = 9;
            label1.Text = "Daftar Keanggotaan";
            // 
            // ButtonChange
            // 
            ButtonChange.BackColor = Color.FromArgb(127, 200, 248);
            ButtonChange.FlatAppearance.BorderSize = 0;
            ButtonChange.FlatStyle = FlatStyle.Flat;
            ButtonChange.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonChange.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonChange.Location = new Point(649, 399);
            ButtonChange.Name = "ButtonChange";
            ButtonChange.Size = new Size(50, 30);
            ButtonChange.TabIndex = 8;
            ButtonChange.Text = "Ubah";
            ButtonChange.UseVisualStyleBackColor = true;
            ButtonChange.Click += ButtonChange_Click;
            // 
            // ButtonAdd
            // 
            ButtonAdd.BackColor = Color.FromArgb(127, 200, 248);
            ButtonAdd.FlatAppearance.BorderSize = 0;
            ButtonAdd.FlatStyle = FlatStyle.Flat;
            ButtonAdd.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonAdd.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonAdd.Location = new Point(712, 399);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(65, 30);
            ButtonAdd.TabIndex = 7;
            ButtonAdd.Text = "Tambah";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonBack
            // 
            ButtonBack.BackColor = Color.FromArgb(127, 200, 248);
            ButtonBack.FlatAppearance.BorderSize = 0;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonBack.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonBack.Location = new Point(23, 399);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(68, 30);
            ButtonBack.TabIndex = 6;
            ButtonBack.Text = "Kembali";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // Tampilanstatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ButtonChange);
            Controls.Add(ButtonAdd);
            Controls.Add(ButtonBack);
            Controls.Add(dataGridView1);
            Name = "Tampilanstatus";
            Text = "TampilanStatus";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button ButtonChange;
        private Button ButtonAdd;
        private Button ButtonBack;
    }
}