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
using ProiectPOO2;

namespace ProiectPOO3
{
    public partial class Login : Form
    {
        private Pornire pornireForm;

        public Login(Pornire form)
        {
            InitializeComponent();
            pornireForm = form;
        }

        private void butonLogin_Click(object sender, EventArgs e)
        {
            string nume = numeClient.Text;
            string parola = parolaClient.Text;

            Client client = BazaClienti.GetInstance().este_inregistrat(nume, parola);
            if (client == null)
            {
                // Clientul nu este inregistrat.
                InfoLabel.Text = "Clientul nu este inregistrat!";
                return;
            }

            Sesiune.client = client;

            this.Close();

            pornireForm.schimba_aspect();
        }

    }
}
