using ProiectPOO2;
using ProiectPOO3;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;
using System.Drawing.Printing;


namespace ProiectPOO
{
    public partial class Pornire : Form
    {


        public Pornire()
        {
            InitializeComponent();
        }

        public void schimba_aspect()
        {
            // Porneste comanda
            Sesiune.comanda = new Comanda();

            InregistrareButon.Visible = false;
            LoginButon.Visible = false;

            idClient.Text = Sesiune.client.getId().ToString();
            idClient.Visible = true;

            numeClient.Text = Sesiune.client.getNume();
            numeClient.Visible = true;

            produseSelectie.Visible = true;
            pretLabel.Visible = true;
            stocLabel.Visible = true;
            cantitateLabel.Visible = true;
            pretProdus.Visible = true;
            stocProdus.Visible = true;
            cantitateSelectata.Visible = true;
            adaugaProdusButon.Visible = true;
            finalizareButon.Visible = true;

            printeazaButon.Visible = true;
            printeazaButon.Enabled = false;

            pozaButon.Visible = true;
            pozaButon.Enabled = false;

            pozaClient.Visible = true;
            logo.Visible = false;

            // sa vedem cate produse avem
            BazaProduse.GetInstance().AdaugaProduse(produseSelectie);
        }

        private void Inregistrare_Click(object sender, EventArgs e)
        {
            Inregistrare form = new Inregistrare();
            form.Show();
            
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Raluca Cosulenu\nEmail: cosuleanuraluca@yahoo.com");
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login form = new Login(this);
            form.Show();
        }

        private void produseSelectie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int selInd = produseSelectie.SelectedIndex;
            Produs produsSelectat = BazaProduse.GetInstance().getProdus(selInd);
            
            // Setam pretul
            pretProdus.Text = produsSelectat.getPret().ToString() + " lei";


            int stoc = produsSelectat.getStoc();
            if (stoc > 0)
            {
                // Setam stocul
                stocProdus.Text = stoc.ToString() + " buc.";

                // Setam valorile min/max pt cantitate
                cantitateSelectata.Minimum = 1;
                cantitateSelectata.Maximum = stoc;

                adaugaProdusButon.Enabled = true;
            }
            else
            {
                // Caz pentru situatia in care nu mai avem produse disponibile
                stocProdus.Text = "Produs indisponibil.";

                cantitateSelectata.Enabled = false;
                adaugaProdusButon.Enabled = false;
            }
        }

        private void adaugaProdusButon_Click(object sender, EventArgs e)
        {
            int selInd = produseSelectie.SelectedIndex;
            Produs produsSelectat = BazaProduse.GetInstance().getProdus(selInd);

            int cantitate = Convert.ToInt32(cantitateSelectata.Value);

            // Adauga produsul in comanda.
            Sesiune.comanda.AdaugaProdus(produsSelectat, cantitate, selInd);
        }

        private void finalizareButon_Click(object sender, EventArgs e)
        {
            Sesiune.comanda.EmiteFactura();

            // Folosim acceeasi functie ca sa nu o scriem din nou
            // Nu avem nevoie de parametri
            produseSelectie_SelectedIndexChanged(null, null);

            // Activam butoanele de poza si print
            printeazaButon.Enabled = true;
            pozaButon.Enabled = true;
        }

        private void printeazaButon_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog p = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();

            document.PrintPage += (a, b) =>
            {
                string titlu = "FACTURA nr. " + Sesiune.client.getId();
                int titleHeight = (int)b.Graphics.MeasureString(titlu, new Font("Arial", 16, FontStyle.Bold)).Height;
                int titluMargine = 10;

                // deseneaza titlul
                b.Graphics.DrawString(titlu, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, titluMargine, titluMargine);

                // Desenează imaginea
                Image imagine = Image.FromFile("C:\\Users\\Asus\\source\\repos\\ProiectPOO\\logo.png"); 
                int latime = 150;
                int inaltime = 150;
                int margine = 10;
                int latimePagina = b.PageBounds.Width;

                // logo
                b.Graphics.DrawImage(imagine, latimePagina - latime - margine, margine, latime, inaltime);
                b.Graphics.DrawString("Adventure SHOP", new Font("Arial", 12), Brushes.Black, latimePagina - latime - margine, inaltime + margine + 10);

                // client
                string numeClient = Sesiune.client.getNume();
                b.Graphics.DrawString("Nume client: " + numeClient, new Font("Arial", 12), Brushes.Black, margine, margine + (inaltime / 2) - 10);

                
                float spatiereLinii = inaltime + margine + 50;

                // Desenam un header pentru tabel
                string h = "Nume produs\tCantitate comandata\tPret unitar\tTotal";
                b.Graphics.DrawString(h, new Font("Arial", 10), Brushes.Black, margine, spatiereLinii);
                spatiereLinii += 20;

                for (int i = 0; i < Sesiune.comanda.cos.Count; i++)
                {
                    Comanda.ProdusComandat produsComandat = Sesiune.comanda.cos[i];

                    string nume = produsComandat.produs.ToString();
                    int cant = produsComandat.cantitate;
                    int pret = produsComandat.produs.getPret();
                    int total = cant * pret;

                    string linie = nume + "\t" + cant + "\t" + pret + "\t" + total;
                    b.Graphics.DrawString(linie, new Font("Arial", 10), Brushes.Black, margine, spatiereLinii);
                    spatiereLinii += 20;
                }
            };

            p.Document = document;
            p.ShowDialog();
        }

        private void pozaButon_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(850, 1100);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // facem background-ul alb
                g.Clear(Color.White);

                // Titlu
                string titlu = "FACTURA nr. " + Sesiune.client.getId();
                Font titleFont = new Font("Arial", 16, FontStyle.Bold);
                int titleHeight = (int)g.MeasureString(titlu, titleFont).Height;
                int titluMargine = 10;

                g.DrawString(titlu, titleFont, Brushes.Black, titluMargine, titluMargine);

                // logo
                Image imagine = Image.FromFile("C:\\Users\\Asus\\source\\repos\\ProiectPOO\\logo.png");
                int latime = 150;
                int inaltime = 150;
                int margine = 10;
                int latimePagina = bitmap.Width;

                g.DrawImage(imagine, latimePagina - latime - margine, margine, latime, inaltime);
                g.DrawString("Adventure SHOP", new Font("Arial", 12), Brushes.Black, latimePagina - latime - margine, inaltime + margine + 10);

                // client
                string numeClient = Sesiune.client.getNume();
                g.DrawString("Nume client: " + numeClient, new Font("Arial", 12), Brushes.Black, margine, margine + (inaltime / 2) - 10);

                float spatiereLinii = inaltime + margine + 50;

                // header tabel
                string h = "Nume produs\tCantitate comandata\tPret unitar\tTotal";
                g.DrawString(h, new Font("Arial", 10), Brushes.Black, margine, spatiereLinii);
                spatiereLinii += 20;

                // produse
                for (int i = 0; i < Sesiune.comanda.cos.Count; i++)
                {
                    Comanda.ProdusComandat produsComandat = Sesiune.comanda.cos[i];

                    string nume = produsComandat.produs.ToString();
                    int cant = produsComandat.cantitate;
                    int pret = produsComandat.produs.getPret();
                    int total = cant * pret;

                    string linie = nume + "\t" + cant + "\t" + pret + "\t" + total;
                    g.DrawString(linie, new Font("Arial", 10), Brushes.Black, margine, spatiereLinii);
                    spatiereLinii += 20;
                }
            }

            bitmap.Save("C:\\Users\\Asus\\source\\repos\\ProiectPOO\\factura.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void stocProdus_Click(object sender, EventArgs e)
        {

        }
    }



    class Produs
    {
        private int cod;
        private string denumire;
        private string descriere;
        private int pret;
        private int stoc;
        private string categorie;

        /// <summary>
        /// zile pana la expirare
        /// </summary>
        private int valabilitate;
        private int garantie;

        public Produs(int cod, string denumire, string descriere, int pret, int stoc, string categorie, int valabilitate, int garantie)
        {
            this.cod = cod;
            this.denumire = denumire;
            this.descriere = descriere;
            this.pret = pret;
            this.stoc = stoc;
            this.categorie = categorie;
            this.valabilitate = valabilitate;
            this.garantie = garantie;
        }

        public Produs(int cod, string denumire, string descriere, int pret, int stoc)
        {
            this.cod = cod;
            this.denumire = denumire;
            this.descriere = descriere;
            this.pret = pret;
            this.stoc = stoc;

            this.categorie = "<niciuna>";
            this.valabilitate = -1;
            this.garantie = -1;
        }

        public override string ToString()
        {
            return cod + " - " + denumire + " - " + descriere;
        }

        public int getPret()
        {
            return pret;
        }

        public int getStoc()
        {
            return stoc;
        }

        public int getCod()
        {
            return cod;
        }

        public void SetStoc(int stocNou)
        {
            stoc = stocNou;
        }
    }

    class BazaSingleton<T>
    {
        protected static BazaSingleton<T> singleton;
        protected List<T> obiecte = new List<T>();

        static public BazaSingleton<T> GetInstance()
        {
            if (singleton == null)
                singleton = new BazaSingleton<T>();
            return singleton;
        }
    }

    class BazaProduse : BazaSingleton<Produs>
    {
        public BazaProduse()
        {
            obiecte = new List<Produs>();
            string xmlText;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://www.math.uaic.ro/~mapetrii/fisiere/POO/produse.xml").Result;
                response.EnsureSuccessStatusCode();
                xmlText = response.Content.ReadAsStringAsync().Result;
            }

            XDocument xdoc = XDocument.Parse(xmlText);

            obiecte = (from produs in xdoc.Descendants("produs")
                       select new Produs(
                            int.Parse(produs.Element("cod")?.Value),
                            produs.Element("denumire")?.Value,
                            produs.Element("descriere")?.Value,
                            int.Parse(produs.Element("pret")?.Value),
                            int.Parse(produs.Element("stoc")?.Value)
                        )).ToList();
        }

        // "new" ne ajuta sa nu mai facem Casting
        static new public BazaProduse GetInstance()
        {
            if (singleton == null)
                singleton = new BazaProduse();
            return singleton as BazaProduse;
        }

        public void AdaugaProduse(ComboBox selectie)
        {
            for (int i = 0; i < obiecte.Count; i++)
            {
                selectie.Items.Add(obiecte[i].ToString());
            }
        }
        public Produs getProdus(int index)
        {
            return obiecte[index];
        }

        public void ScadeStoc(int index, int cantitate)
        {
            int stocVechi = obiecte[index].getStoc();
            obiecte[index].SetStoc(stocVechi - cantitate);
        }
    }

    class Client
    {
        private int id;
        private string nume;
        private string parola;

        public Client(int id, string nume, string parola)
        {
            this.id = id;
            this.nume = nume;
            this.parola = parola;
        }

        public int getId()
        {
            return id;
        }

        public string getNume()
        {
            return nume;
        }

        public string getParola()
        {
            return parola;
        }
    }

    class BazaClienti : BazaSingleton<Client>
    {
        static new public BazaClienti GetInstance()
        {
            if (singleton == null)
            {
                singleton = new BazaClienti();
            }
            return singleton as BazaClienti;
        }

        public void AdaugaClient(Client client)
        {
            obiecte.Add(client);
        }

        public int get_id()
        {
            return obiecte.Count + 1;
        }
        
        public Client este_inregistrat(string nume, string parola)
        {
            for (int i = 0; i < obiecte.Count; i++)
            {
                if (obiecte[i].getNume() == nume && obiecte[i].getParola() == parola)
                {
                    return obiecte[i];
                }
            }

            return null;
        }

    }

    class Comanda
    {
        public class ProdusComandat
        {
            public Produs produs;
            public int cantitate;
            public int index;

            public ProdusComandat(Produs p, int cant, int index)
            {
                this.produs = p;
                this.cantitate = cant;
                this.index = index;
            }
        }

        public List<ProdusComandat> cos = new List<ProdusComandat>();

        public void AdaugaProdus(Produs p, int cant, int index)
        {
            ProdusComandat produsComandat = new ProdusComandat(p, cant, index);
            cos.Add(produsComandat);
        }

        public void EmiteFactura(string fisier = "factura.txt")
        {
            // Nu folosim "append" pt ca vrem sa suprascriem
            using(StreamWriter fout = new StreamWriter(fisier))
            {
                // Scriem prima data ID-ul clientului
                fout.WriteLine(Sesiune.client.getId().ToString());

                // codProdus1/cantitate
                for (int i = 0; i < cos.Count; i++)
                {
                    ProdusComandat p = cos[i];
                    fout.WriteLine(p.produs.getCod().ToString() + "/" + p.cantitate.ToString());
                }
            }

            // Scadem toate produsele comandate din stoc
            for (int i = 0; i < cos.Count; i++)
            {
                int index = cos[i].index;
                int cantitate = cos[i].cantitate;
                BazaProduse.GetInstance().ScadeStoc(index, cantitate);
            }
        }
    }

    class Sesiune
    {
        public static Client client;
        public static Comanda comanda;
    }


}
