using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeretanaBusiness;
using Shared.Models;
using Shared.Interfaces;
using TeretanaData;

namespace Teretana
{
    public partial class Prijavljivanje : Form
    {
        private readonly ITrenerBusiness tBusiness;
        private readonly IKorisnikBusiness ikorisnikBusiness;
        public Prijavljivanje(ITrenerBusiness _itrenerBusiness, IKorisnikBusiness _korisnikBusiness)
         {
             tBusiness = _itrenerBusiness;
             ikorisnikBusiness = _korisnikBusiness;
             InitializeComponent();
         }


        private void btPrijaviSe_Click(object sender, EventArgs e)
        {
            string korIme = tbKorisnickoIme.Text.Trim();
            string sifra = tbSifra.Text.Trim();

            List<Trener>lista = this.tBusiness.VratiTrenere();
            bool pom = true;
            foreach (Trener t in lista)
            {
                if ((t.korisnicko_ime == korIme && t.sifra == sifra))
                {
                    EvidencijaKorisnika ek = new EvidencijaKorisnika(tBusiness,ikorisnikBusiness);
                    ek.Show();
                    this.Hide();
                    
                    pom = false;
                }
            }
            if (korIme=="admin" && sifra == "admin")
            {
                EvidencijaKorisnika ek = new EvidencijaKorisnika(tBusiness, ikorisnikBusiness);
                ek.Show();
                this.Hide();
                pom = false;
            }
                if (pom==true)
            {
                tbKorisnickoIme.Clear();
                tbSifra.Clear();
                MessageBox.Show("Ne postoji trener sa unetim korisničkim imenom i šifrom.", "Nepravilan unos!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistracijaTrenera registracijaTrenera = new RegistracijaTrenera(tBusiness,ikorisnikBusiness);
            registracijaTrenera.Show();
            this.Hide();
        }
    }
}
