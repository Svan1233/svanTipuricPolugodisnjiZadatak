using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace svanTipuricPolugodisnjiProjektniZad
{
    public class Ispit
    {
        public bool onComputer { get; set; }
        public string Gradivo { get; set; }
        public string Profesor { get; set; }
        public string Predmet { get; set; }
        public string Datum { get; set; }
        //konstruktor
        public Ispit(string Gradivo,string Profesor,string Datum,string Predmet)
            {
            this.Datum = Datum;
            this.Gradivo = Gradivo;
            this.Profesor = Profesor;
            this.Predmet = Predmet;
            this.onComputer = onComputer;
            }
        //metoda za format zeljenog ispisa
        public string Ispis()
            {
                string Output = string.Format("Gradivo: {0}, Profesor: {1}, Datum: {2},Predmet: {3}",Gradivo, Profesor, Datum, Predmet);                                   
                return Output;
            }
        //metoda za format zeljenog ispisa sa dodatnom vrijednosti
        public string Ispis2()
        {
            string Output = string.Format("Gradivo: {0}, Profesor: {1}, Datum: {2}, Predmet: {3}, Na kompjuteru: {4}", Gradivo, Profesor, Datum, Predmet, onComputer);
            return Output;
        }



    }
}
