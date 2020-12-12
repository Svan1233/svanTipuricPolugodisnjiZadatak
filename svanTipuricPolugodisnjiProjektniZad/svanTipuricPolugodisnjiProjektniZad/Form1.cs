using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace svanTipuricPolugodisnjiProjektniZad
{
    public partial class Form1 : Form
    {
        //kreirnje liste instanca(ispita)

        List<Ispit> LIspita = new List<Ispit>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            string Gradivo = textBoxGradivo.Text;
            string Predmet = comboBoxPredmet.Text;
            string Datum = textBoxDatum.Text;
            string Profesor = textBoxProfesor.Text;
            //provjera dali su podatci ispunjeni
            if (string.IsNullOrWhiteSpace(Gradivo) ||
                string.IsNullOrWhiteSpace(Predmet) ||
                string.IsNullOrWhiteSpace(Datum) ||
                string.IsNullOrWhiteSpace(Profesor))
                {
                    MessageBox.Show("Krivi unos! Molim vas da popunite sve podatke.");
                    return;
                };
            //dodavanje instanca(ispita) u listu(LIspita)
            LIspita.Add(new Ispit(Gradivo,Profesor,Datum,Predmet));
            //provjera dali se ispit pise na kompjuteru
            for (int i = 0; i < LIspita.Count; i++)
            {
                if (LIspita[i].Predmet == "Programiranje" ||
                    LIspita[i].Predmet == "Programiranej mobilnih uredaja" ||
                    LIspita[i].Predmet == "Skriptni jezici i web programiranje")
                {
                    LIspita[i].onComputer = true;
                }
                else if (LIspita[i].Predmet == "Matematika" ||
                         LIspita[i].Predmet == "Hrvatski jezik" ||
                         LIspita[i].Predmet == "Engleski jezik")
                {
                    LIspita[i].onComputer = false;
                }
            }           
        }
       
        private void comboBoxPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            //upis u rich text box bez nadodane vrijednosti
            rtb1.Clear();
            foreach (Ispit ispit in LIspita)
            {
                rtb1.Text += ispit.Ispis()+Environment.NewLine;
            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            //upis u rich text box sa nadodanom vrijednosti
            rtb1.Clear();
            foreach (Ispit ispit in LIspita)
            {
                rtb1.Text += ispit.Ispis2()+Environment.NewLine;
            }
        }
        
    }
}
