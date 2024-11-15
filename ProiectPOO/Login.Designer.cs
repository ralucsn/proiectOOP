
namespace ProiectPOO3
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Nume = new System.Windows.Forms.Label();
            this.Parola = new System.Windows.Forms.Label();
            this.numeClient = new System.Windows.Forms.TextBox();
            this.parolaClient = new System.Windows.Forms.TextBox();
            this.butonLogin = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume.Location = new System.Drawing.Point(318, 86);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(82, 29);
            this.Nume.TabIndex = 0;
            this.Nume.Text = "Nume";
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parola.Location = new System.Drawing.Point(318, 167);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(89, 29);
            this.Parola.TabIndex = 1;
            this.Parola.Text = "Parola";
            // 
            // numeClient
            // 
            this.numeClient.BackColor = System.Drawing.Color.MistyRose;
            this.numeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeClient.Location = new System.Drawing.Point(450, 85);
            this.numeClient.Name = "numeClient";
            this.numeClient.Size = new System.Drawing.Size(189, 30);
            this.numeClient.TabIndex = 2;
            // 
            // parolaClient
            // 
            this.parolaClient.BackColor = System.Drawing.Color.MistyRose;
            this.parolaClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaClient.Location = new System.Drawing.Point(450, 166);
            this.parolaClient.Name = "parolaClient";
            this.parolaClient.Size = new System.Drawing.Size(189, 30);
            this.parolaClient.TabIndex = 3;
            // 
            // butonLogin
            // 
            this.butonLogin.BackColor = System.Drawing.Color.MistyRose;
            this.butonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonLogin.Location = new System.Drawing.Point(338, 259);
            this.butonLogin.Name = "butonLogin";
            this.butonLogin.Size = new System.Drawing.Size(164, 63);
            this.butonLogin.TabIndex = 4;
            this.butonLogin.Text = "Login";
            this.butonLogin.UseVisualStyleBackColor = false;
            this.butonLogin.Click += new System.EventHandler(this.butonLogin_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(160, 370);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 17);
            this.InfoLabel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(663, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.butonLogin);
            this.Controls.Add(this.parolaClient);
            this.Controls.Add(this.numeClient);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.Nume);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label Parola;
        private System.Windows.Forms.TextBox numeClient;
        private System.Windows.Forms.TextBox parolaClient;
        private System.Windows.Forms.Button butonLogin;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}