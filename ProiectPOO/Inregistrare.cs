using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectPOO;

namespace ProiectPOO2
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {

        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Raluca Cosulenu\nEmail: cosuleanuraluca@yahoo.com");
        }

        private void butonInreg_Click(object sender, EventArgs e)
        {
            string nume = numeClient.Text;
            string parola = parolaClient.Text;
            if (nume.Length > 10 || nume.Contains(" ") || nume.Length  < 3)
            {
                InfoLabel.Text = "Nume incorect formatat (3-10 caractere) sau contine spatii!";
                return;
            }
            if (parola.Length > 10 || parola.Contains(" ") || parola.Length < 3)
            {
                InfoLabel.Text = "Parola incorect formatata (3-10 caractere) sau contine spatii!";
                return;
            }
            if (BazaClienti.GetInstance().este_inregistrat(nume, parola) != null)
            {
                InfoLabel.Text = "Clientul este deja inregistrat!";
                return;
            }

            // adauga clientul inregistrat
            int id = BazaClienti.GetInstance().get_id();

            Client client_nou = new Client(id, nume, parola);

            BazaClienti.GetInstance().AdaugaClient(client_nou);

            InfoLabel.Text = "Client inregistrat cu succes!";
            butonInreg.Enabled = false;
        }

    }
}
