using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoedingClassLibrary
{
    public class Activiteit
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Duur { get; set; }      //in minuten
        public int KcalVerbrand { get; set; }
        public int ActiviteitMoment { get; set; }

        public Activiteit(string Naam, int Duur, int KcalVerbrand, int ActiviteitMoment)
        {
            this.Naam = Naam;
            this.Duur = Duur;
            this.KcalVerbrand = KcalVerbrand;
            this.ActiviteitMoment = ActiviteitMoment;
        }
    }
}
