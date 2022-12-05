using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiSala
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sala = Convert.ToInt32(DropDownList1.SelectedValue);
            if (sala == 1)
            {
                ArchiviaPrenotazione("SALA NORD");
            }
            else if (sala == 2)
            {
                ArchiviaPrenotazione("SALA EST");
            }
            else if (sala == 3)
            {
                ArchiviaPrenotazione("SALA SUD");
            }
        }

        private void ArchiviaPrenotazione(string NomeSala)
        {
            Prenotazione p = new Prenotazione();
            p.Nome = TextBox1.Text;
            p.Cognome = TextBox1.Text;
            p.BigliettoRidotto = CheckBox1.Checked;
            p.SalaCinema = NomeSala;
            
            Prenotazione.ListaPrenotazioni.Add(p);
           
            ContaBigliettiVenduti();
        }

        private void ContaBigliettiVenduti()
        {
            int VendutiA = 0;
            int RidottiA = 0;
            int VendutiB = 0;
            int RidottiB = 0;
            int VendutiC = 0;
            int RidottiC = 0;
            foreach (Prenotazione p in Prenotazione.ListaPrenotazioni)
            {
                if (p.SalaCinema == "SALA NORD")
                {
                    VendutiA += 1;
                    if (p.BigliettoRidotto == true)
                    {
                        RidottiA += 1;
                    }
                }
                else if (p.SalaCinema == "SALA EST")
                {
                    VendutiB += 1;
                    if (p.BigliettoRidotto == true)
                    {
                        RidottiB += 1;
                    }
                }
                else if (p.SalaCinema == "SALA SUD")
                {
                    VendutiC += 1;
                    if (p.BigliettoRidotto == true)
                    {
                        RidottiC += 1;
                    }
                }
            }
            LabelBigliettiVendutiA.Text = Convert.ToString(VendutiA);
            LabelBigliettiVendutiB.Text = Convert.ToString(VendutiB);
            LabelBigliettiVendutiC.Text = Convert.ToString(VendutiC);
            LabelBigliettiRidottiVendutiA.Text = Convert.ToString(RidottiA);
            LabelBigliettiRidottiVendutiB.Text = Convert.ToString(RidottiB);
            LabelBigliettiRidottiVendutiC.Text = Convert.ToString(RidottiC);
        }
    }

    public class Prenotazione
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _cognome;

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        private bool _bigliettoRidotto;

        public bool BigliettoRidotto
        {
            get { return _bigliettoRidotto; }
            set { _bigliettoRidotto = value; }
        }

        private string _salaCinema;
        public string SalaCinema
        {
            get
            {
                return _salaCinema;
            }
            set
            {
                _salaCinema = value;
            }
        }

        private static List<Prenotazione> _listaPrenotazioni = new List<Prenotazione>();
        public static List<Prenotazione> ListaPrenotazioni
        {
            get
            {
                return _listaPrenotazioni;
            }
            set
            {
                _listaPrenotazioni = value;
            }
        }
    }
}
