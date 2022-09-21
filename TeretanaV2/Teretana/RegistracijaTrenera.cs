using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeretanaBusiness;
using Shared.Interfaces;
using System.Text.RegularExpressions;

namespace Teretana
{
    public partial class RegistracijaTrenera : Form
    {
        private readonly ITrenerBusiness itrenerBusiness;
        private readonly IKorisnikBusiness ikorisnikBusiness;
        public RegistracijaTrenera(ITrenerBusiness _itrenerBusiness, IKorisnikBusiness _korisnikBusiness)
        {
            itrenerBusiness = _itrenerBusiness;
            ikorisnikBusiness = _korisnikBusiness;
            InitializeComponent();
        }

        private void btNazadT_Click(object sender, EventArgs e)
        {
            Prijavljivanje prijavljivanje = new Prijavljivanje(itrenerBusiness,ikorisnikBusiness);
            prijavljivanje.Show();
            this.Hide();
        }

        private void btSacuvajT_Click(object sender, EventArgs e)
        {
            bool duplikat = false;
            List<Trener> lista = new List<Trener>();
            lista = this.itrenerBusiness.VratiTrenere();
            foreach (Trener t in lista)
            {
                if (tbKorisnickoImeT.Text == t.korisnicko_ime)
                    duplikat = true;
            }
            if (tbImeT.Text == "" || tbPrezimeT.Text == "" || tbBrojTelefonaT.Text == "" ||
                tbKorisnickoImeT.Text == "" || tbLozinkaT.Text == "" || cbStrucnaOblast.SelectedIndex==-1)
            {
                MessageBox.Show("Morate uneti vrednost u obavezna polja.", "Nepravilan unos!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //Provera unosa imena
            else if (!Regex.Match(tbImeT.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("Ime mora počinjati velikim slovom i mora se sastojati od slova!", "Nepravilan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbImeT.Focus();
                return;
            }
            //Provera unosa prezimena
            else if (!Regex.Match(tbPrezimeT.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("Prezime mora počinjati velikim slovom i mora se sastojati od slova!", "Nepravilan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPrezimeT.Focus();
                return;
            }
            //Provera unosa broja telefona
            else if (!Regex.Match(tbBrojTelefonaT.Text, @"^\d{1,3}/[1-9]\d{2,3}-\d{3,4}$").Success)
            {
                MessageBox.Show("Broj telefona mora biti u formatu xxx/xxx-xxxx", "Nepravilan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbBrojTelefonaT.Focus();
                return;
            }
            //isto korisnicko ime
            else if (duplikat)
            {
                MessageBox.Show("Već postoji korisnik sa identičnim korisničkim imenom", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //Provera unosa sifre
            else if (!Regex.Match(tbLozinkaT.Text, @"^\w{5,}$").Success)
            {
                MessageBox.Show("Šifra se mora sastojati od najmanje 5 karaktera!", "Nepravilan unos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbLozinkaT.Focus();
                return;
            }
            
            else
            {
                Trener t = new Trener();
                t.ime = tbImeT.Text.Trim();
                t.prezime = tbPrezimeT.Text.Trim();
                t.datum_rodjenja = dtpDatumRodjenja.Value;
                t.strucna_oblast = cbStrucnaOblast.SelectedItem.ToString();
                t.br_telefona = tbBrojTelefonaT.Text;
                t.biografija = tbBiografijaT.Text;
                t.korisnicko_ime = tbKorisnickoImeT.Text.Trim();
                t.sifra = tbLozinkaT.Text.Trim();
                itrenerBusiness.InsertTrener(t);

                tbImeT.Clear();
                tbPrezimeT.Clear();
                dtpDatumRodjenja.Value = DateTime.Today;
                cbStrucnaOblast.SelectedIndex = -1;
                tbBrojTelefonaT.Clear();
                tbBiografijaT.Clear();
                tbKorisnickoImeT.Clear();
                tbLozinkaT.Clear();
                MessageBox.Show("Registracija uspešno izvršena!", "Ispravan unos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
