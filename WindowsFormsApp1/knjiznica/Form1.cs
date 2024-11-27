using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knjiznica
{
    public partial class Form1 : Form
    {
        private Knjiznica mojaKnjiznica = new Knjiznica(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string naslov = txtNaslov.Text;
                string autor = txtAutor.Text;
                int godina = int.Parse(txtGodina.Text);

                Knjiga novaKnjiga = new Knjiga
                {
                    ID = id,
                    Naslov = naslov,
                    Autor = autor,
                    GodinaIzdavanja = godina
                };

                mojaKnjiznica.DodajKnjigu(novaKnjiga);
                MessageBox.Show("Knjiga je uspješno dodana!");
                OsvjeziPrikaz();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void btnPrikaziKnjige_Click(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
        }

        private void btnSpremiUDatoteku_Click(object sender, EventArgs e)
        {
            mojaKnjiznica.SpremiUDatoteku("knjige.txt");
            MessageBox.Show("Podaci su spremljeni u datoteku.");
        }

        private void btnUcitajIzDatoteke_Click(object sender, EventArgs e)
        {
            mojaKnjiznica.UcitajIzDatoteke("knjige.txt");
            MessageBox.Show("Podaci su učitani iz datoteke.");
            OsvjeziPrikaz();
        }

        private void OsvjeziPrikaz()
        {
            lstKnjige.Items.Clear();
            foreach (var knjiga in mojaKnjiznica.DohvatiSveKnjige())
            {
                lstKnjige.Items.Add($"ID: {knjiga.ID}, Naslov: {knjiga.Naslov}, Autor: {knjiga.Autor}, Godina: {knjiga.GodinaIzdavanja}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
