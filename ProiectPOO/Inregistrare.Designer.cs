
namespace ProiectPOO2
{
    partial class Inregistrare
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inregistrare));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Nume = new System.Windows.Forms.Label();
            this.Parola = new System.Windows.Forms.Label();
            this.butonInreg = new System.Windows.Forms.Button();
            this.numeClient = new System.Windows.Forms.TextBox();
            this.parolaClient = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume.Location = new System.Drawing.Point(311, 96);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(82, 29);
            this.Nume.TabIndex = 2;
            this.Nume.Text = "Nume";
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parola.Location = new System.Drawing.Point(311, 165);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(89, 29);
            this.Parola.TabIndex = 3;
            this.Parola.Text = "Parola";
            // 
            // butonInreg
            // 
            this.butonInreg.BackColor = System.Drawing.Color.MistyRose;
            this.butonInreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonInreg.Location = new System.Drawing.Point(316, 279);
            this.butonInreg.Name = "butonInreg";
            this.butonInreg.Size = new System.Drawing.Size(191, 72);
            this.butonInreg.TabIndex = 4;
            this.butonInreg.Text = "Inregistrare";
            this.butonInreg.UseVisualStyleBackColor = false;
            this.butonInreg.Click += new System.EventHandler(this.butonInreg_Click);
            // 
            // numeClient
            // 
            this.numeClient.BackColor = System.Drawing.Color.MistyRose;
            this.numeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeClient.Location = new System.Drawing.Point(476, 95);
            this.numeClient.Name = "numeClient";
            this.numeClient.Size = new System.Drawing.Size(228, 30);
            this.numeClient.TabIndex = 5;
            // 
            // parolaClient
            // 
            this.parolaClient.BackColor = System.Drawing.Color.MistyRose;
            this.parolaClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaClient.Location = new System.Drawing.Point(479, 165);
            this.parolaClient.Name = "parolaClient";
            this.parolaClient.Size = new System.Drawing.Size(225, 30);
            this.parolaClient.TabIndex = 6;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(104, 365);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 17);
            this.InfoLabel.TabIndex = 7;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(47, 100);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(191, 96);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 21;
            this.logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Inregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.parolaClient);
            this.Controls.Add(this.numeClient);
            this.Controls.Add(this.butonInreg);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.Nume);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inregistrare";
            this.Text = "Inregistrare";
            this.Load += new System.EventHandler(this.Inregistrare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label Parola;
        private System.Windows.Forms.Button butonInreg;
        private System.Windows.Forms.TextBox numeClient;
        private System.Windows.Forms.TextBox parolaClient;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}