
namespace ProiectPOO
{
    partial class Pornire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pornire));
            this.Bara = new System.Windows.Forms.MenuStrip();
            this.aplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InregistrareButon = new System.Windows.Forms.Button();
            this.LoginButon = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idClient = new System.Windows.Forms.Label();
            this.numeClient = new System.Windows.Forms.Label();
            this.produseSelectie = new System.Windows.Forms.ComboBox();
            this.adaugaProdusButon = new System.Windows.Forms.Button();
            this.cantitateSelectata = new System.Windows.Forms.NumericUpDown();
            this.pretLabel = new System.Windows.Forms.Label();
            this.stocLabel = new System.Windows.Forms.Label();
            this.cantitateLabel = new System.Windows.Forms.Label();
            this.stocProdus = new System.Windows.Forms.Label();
            this.pretProdus = new System.Windows.Forms.Label();
            this.finalizareButon = new System.Windows.Forms.Button();
            this.printeazaButon = new System.Windows.Forms.Button();
            this.pozaButon = new System.Windows.Forms.Button();
            this.pozaClient = new System.Windows.Forms.PictureBox();
            this.floricica = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Bara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantitateSelectata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozaClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floricica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Bara
            // 
            this.Bara.BackColor = System.Drawing.Color.MistyRose;
            this.Bara.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Bara.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicatieToolStripMenuItem,
            this.produseToolStripMenuItem,
            this.despreToolStripMenuItem});
            this.Bara.Location = new System.Drawing.Point(0, 0);
            this.Bara.Name = "Bara";
            this.Bara.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.Bara.Size = new System.Drawing.Size(739, 30);
            this.Bara.TabIndex = 0;
            this.Bara.Text = "Bara de instrumente";
            // 
            // aplicatieToolStripMenuItem
            // 
            this.aplicatieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
            this.aplicatieToolStripMenuItem.Name = "aplicatieToolStripMenuItem";
            this.aplicatieToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.aplicatieToolStripMenuItem.Text = "Aplicatie";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.produseToolStripMenuItem.Text = "Produse";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // InregistrareButon
            // 
            this.InregistrareButon.BackColor = System.Drawing.Color.MistyRose;
            this.InregistrareButon.Font = new System.Drawing.Font("Sitka Display", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InregistrareButon.Location = new System.Drawing.Point(250, 197);
            this.InregistrareButon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InregistrareButon.Name = "InregistrareButon";
            this.InregistrareButon.Size = new System.Drawing.Size(221, 75);
            this.InregistrareButon.TabIndex = 1;
            this.InregistrareButon.Text = "Inregistrare";
            this.InregistrareButon.UseVisualStyleBackColor = false;
            this.InregistrareButon.Click += new System.EventHandler(this.Inregistrare_Click);
            // 
            // LoginButon
            // 
            this.LoginButon.BackColor = System.Drawing.Color.MistyRose;
            this.LoginButon.Font = new System.Drawing.Font("Sitka Display", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButon.Location = new System.Drawing.Point(250, 309);
            this.LoginButon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginButon.Name = "LoginButon";
            this.LoginButon.Size = new System.Drawing.Size(221, 74);
            this.LoginButon.TabIndex = 2;
            this.LoginButon.Text = "Login";
            this.LoginButon.UseVisualStyleBackColor = false;
            this.LoginButon.Click += new System.EventHandler(this.Login_Click);
            // 
            // idClient
            // 
            this.idClient.AutoSize = true;
            this.idClient.Font = new System.Drawing.Font("Sitka Display", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClient.ForeColor = System.Drawing.Color.Black;
            this.idClient.Location = new System.Drawing.Point(55, 69);
            this.idClient.Name = "idClient";
            this.idClient.Size = new System.Drawing.Size(94, 35);
            this.idClient.TabIndex = 3;
            this.idClient.Text = "idClient";
            this.idClient.Visible = false;
            // 
            // numeClient
            // 
            this.numeClient.AutoSize = true;
            this.numeClient.Font = new System.Drawing.Font("Sitka Display", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeClient.ForeColor = System.Drawing.Color.Black;
            this.numeClient.Location = new System.Drawing.Point(55, 98);
            this.numeClient.Name = "numeClient";
            this.numeClient.Size = new System.Drawing.Size(129, 35);
            this.numeClient.TabIndex = 4;
            this.numeClient.Text = "numeClient";
            this.numeClient.Visible = false;
            // 
            // produseSelectie
            // 
            this.produseSelectie.BackColor = System.Drawing.Color.MistyRose;
            this.produseSelectie.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produseSelectie.FormattingEnabled = true;
            this.produseSelectie.Location = new System.Drawing.Point(250, 116);
            this.produseSelectie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.produseSelectie.Name = "produseSelectie";
            this.produseSelectie.Size = new System.Drawing.Size(358, 37);
            this.produseSelectie.TabIndex = 5;
            this.produseSelectie.Text = "selecteaza produs";
            this.produseSelectie.Visible = false;
            this.produseSelectie.SelectedIndexChanged += new System.EventHandler(this.produseSelectie_SelectedIndexChanged);
            // 
            // adaugaProdusButon
            // 
            this.adaugaProdusButon.BackColor = System.Drawing.Color.MistyRose;
            this.adaugaProdusButon.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaProdusButon.Location = new System.Drawing.Point(264, 350);
            this.adaugaProdusButon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adaugaProdusButon.Name = "adaugaProdusButon";
            this.adaugaProdusButon.Size = new System.Drawing.Size(174, 57);
            this.adaugaProdusButon.TabIndex = 7;
            this.adaugaProdusButon.Text = "Adauga produs";
            this.adaugaProdusButon.UseVisualStyleBackColor = false;
            this.adaugaProdusButon.Visible = false;
            this.adaugaProdusButon.Click += new System.EventHandler(this.adaugaProdusButon_Click);
            // 
            // cantitateSelectata
            // 
            this.cantitateSelectata.BackColor = System.Drawing.Color.MistyRose;
            this.cantitateSelectata.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantitateSelectata.ForeColor = System.Drawing.Color.Black;
            this.cantitateSelectata.Location = new System.Drawing.Point(502, 274);
            this.cantitateSelectata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cantitateSelectata.Name = "cantitateSelectata";
            this.cantitateSelectata.Size = new System.Drawing.Size(73, 33);
            this.cantitateSelectata.TabIndex = 8;
            this.cantitateSelectata.Visible = false;
            // 
            // pretLabel
            // 
            this.pretLabel.AutoSize = true;
            this.pretLabel.BackColor = System.Drawing.Color.LightPink;
            this.pretLabel.Font = new System.Drawing.Font("Sitka Display", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.pretLabel.Location = new System.Drawing.Point(203, 180);
            this.pretLabel.Name = "pretLabel";
            this.pretLabel.Size = new System.Drawing.Size(109, 29);
            this.pretLabel.TabIndex = 9;
            this.pretLabel.Text = "Pret bucata";
            this.pretLabel.Visible = false;
            // 
            // stocLabel
            // 
            this.stocLabel.AutoSize = true;
            this.stocLabel.Font = new System.Drawing.Font("Sitka Display", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocLabel.Location = new System.Drawing.Point(203, 228);
            this.stocLabel.Name = "stocLabel";
            this.stocLabel.Size = new System.Drawing.Size(114, 29);
            this.stocLabel.TabIndex = 10;
            this.stocLabel.Text = "Stoc produs";
            this.stocLabel.Visible = false;
            // 
            // cantitateLabel
            // 
            this.cantitateLabel.AutoSize = true;
            this.cantitateLabel.Font = new System.Drawing.Font("Sitka Display", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantitateLabel.Location = new System.Drawing.Point(203, 276);
            this.cantitateLabel.Name = "cantitateLabel";
            this.cantitateLabel.Size = new System.Drawing.Size(181, 29);
            this.cantitateLabel.TabIndex = 11;
            this.cantitateLabel.Text = "Selecteaza cantitate";
            this.cantitateLabel.Visible = false;
            // 
            // stocProdus
            // 
            this.stocProdus.AutoSize = true;
            this.stocProdus.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocProdus.ForeColor = System.Drawing.Color.Black;
            this.stocProdus.Location = new System.Drawing.Point(497, 228);
            this.stocProdus.Name = "stocProdus";
            this.stocProdus.Size = new System.Drawing.Size(46, 29);
            this.stocProdus.TabIndex = 13;
            this.stocProdus.Text = "stoc";
            this.stocProdus.Visible = false;
            this.stocProdus.Click += new System.EventHandler(this.stocProdus_Click);
            // 
            // pretProdus
            // 
            this.pretProdus.AutoSize = true;
            this.pretProdus.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretProdus.ForeColor = System.Drawing.Color.Black;
            this.pretProdus.Location = new System.Drawing.Point(499, 180);
            this.pretProdus.Name = "pretProdus";
            this.pretProdus.Size = new System.Drawing.Size(48, 29);
            this.pretProdus.TabIndex = 14;
            this.pretProdus.Text = "pret";
            this.pretProdus.Visible = false;
            // 
            // finalizareButon
            // 
            this.finalizareButon.BackColor = System.Drawing.Color.MistyRose;
            this.finalizareButon.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizareButon.Location = new System.Drawing.Point(459, 456);
            this.finalizareButon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.finalizareButon.Name = "finalizareButon";
            this.finalizareButon.Size = new System.Drawing.Size(246, 95);
            this.finalizareButon.TabIndex = 15;
            this.finalizareButon.Text = "Finalizeaza comanda";
            this.finalizareButon.UseVisualStyleBackColor = false;
            this.finalizareButon.Visible = false;
            this.finalizareButon.Click += new System.EventHandler(this.finalizareButon_Click);
            // 
            // printeazaButon
            // 
            this.printeazaButon.BackColor = System.Drawing.Color.MistyRose;
            this.printeazaButon.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printeazaButon.Location = new System.Drawing.Point(250, 456);
            this.printeazaButon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printeazaButon.Name = "printeazaButon";
            this.printeazaButon.Size = new System.Drawing.Size(141, 95);
            this.printeazaButon.TabIndex = 16;
            this.printeazaButon.Text = "Printeaza factura";
            this.printeazaButon.UseVisualStyleBackColor = false;
            this.printeazaButon.Visible = false;
            this.printeazaButon.Click += new System.EventHandler(this.printeazaButon_Click);
            // 
            // pozaButon
            // 
            this.pozaButon.BackColor = System.Drawing.Color.MistyRose;
            this.pozaButon.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pozaButon.Location = new System.Drawing.Point(37, 456);
            this.pozaButon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pozaButon.Name = "pozaButon";
            this.pozaButon.Size = new System.Drawing.Size(141, 95);
            this.pozaButon.TabIndex = 17;
            this.pozaButon.Text = "Salveaza";
            this.pozaButon.UseVisualStyleBackColor = false;
            this.pozaButon.Visible = false;
            this.pozaButon.Click += new System.EventHandler(this.pozaButon_Click);
            // 
            // pozaClient
            // 
            this.pozaClient.Image = ((System.Drawing.Image)(resources.GetObject("pozaClient.Image")));
            this.pozaClient.Location = new System.Drawing.Point(74, 134);
            this.pozaClient.Name = "pozaClient";
            this.pozaClient.Size = new System.Drawing.Size(64, 64);
            this.pozaClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pozaClient.TabIndex = 18;
            this.pozaClient.TabStop = false;
            this.pozaClient.Visible = false;
            // 
            // floricica
            // 
            this.floricica.Image = ((System.Drawing.Image)(resources.GetObject("floricica.Image")));
            this.floricica.Location = new System.Drawing.Point(637, 50);
            this.floricica.Name = "floricica";
            this.floricica.Size = new System.Drawing.Size(96, 96);
            this.floricica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.floricica.TabIndex = 19;
            this.floricica.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(21, 50);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(194, 95);
            this.logo.TabIndex = 20;
            this.logo.TabStop = false;
            // 
            // Pornire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(739, 614);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.floricica);
            this.Controls.Add(this.pozaClient);
            this.Controls.Add(this.pozaButon);
            this.Controls.Add(this.printeazaButon);
            this.Controls.Add(this.finalizareButon);
            this.Controls.Add(this.pretProdus);
            this.Controls.Add(this.stocProdus);
            this.Controls.Add(this.cantitateLabel);
            this.Controls.Add(this.stocLabel);
            this.Controls.Add(this.pretLabel);
            this.Controls.Add(this.cantitateSelectata);
            this.Controls.Add(this.adaugaProdusButon);
            this.Controls.Add(this.produseSelectie);
            this.Controls.Add(this.numeClient);
            this.Controls.Add(this.idClient);
            this.Controls.Add(this.LoginButon);
            this.Controls.Add(this.InregistrareButon);
            this.Controls.Add(this.Bara);
            this.Font = new System.Drawing.Font("Sitka Display", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Bara;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Pornire";
            this.Text = "Pagina de pornire";
            this.Bara.ResumeLayout(false);
            this.Bara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantitateSelectata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozaClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floricica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Bara;
        private System.Windows.Forms.ToolStripMenuItem aplicatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.Button InregistrareButon;
        private System.Windows.Forms.Button LoginButon;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label idClient;
        private System.Windows.Forms.Label numeClient;
        private System.Windows.Forms.ComboBox produseSelectie;
        private System.Windows.Forms.Button adaugaProdusButon;
        private System.Windows.Forms.NumericUpDown cantitateSelectata;
        private System.Windows.Forms.Label pretLabel;
        private System.Windows.Forms.Label stocLabel;
        private System.Windows.Forms.Label cantitateLabel;
        private System.Windows.Forms.Label stocProdus;
        private System.Windows.Forms.Label pretProdus;
        private System.Windows.Forms.Button finalizareButon;
        private System.Windows.Forms.Button printeazaButon;
        private System.Windows.Forms.Button pozaButon;
        private System.Windows.Forms.PictureBox pozaClient;
        private System.Windows.Forms.PictureBox floricica;
        private System.Windows.Forms.PictureBox logo;
    }
}

