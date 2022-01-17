using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoedingClassLibrary
{
    public class KlantAccount
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; } //met evt tussenvoegsel
        public int Lengte { get; set; } //in centimeter

        public int Gewicht { get; set; } //in hele kilo's

        public GeslachtEnum Geslacht { get; set; }       //enum voor de verschillende genders? 

        public float vergelijkingsScore { get; set; }

        #region agenda

        public Agenda Agenda { get;}
        //hier komt de agenda

        #endregion

        #region dieetWensen

        //hier komen de dieetwensen
        //Doestelling: heeft invloed op calorie inname
        //producten negeren: vlees, dierlijke producten
        //allergien: product(groepen) negeren  ==> 14 belangrijkste product groepen?
        /*Gluten, Schaaldieren, Eieren, Vis, Pinda, Soja, Melk, Noten, Selderij, Mosterd, Sesamzaad, Zwaveldioxide en sulfiet bij concentraties van meer dan 10 mg SO2 per kilo of liter, Lupine, Weekdieren*/

        #endregion

        public KlantAccount (string Voornaam, string Achternaam, int Lengte, int Gewicht, GeslachtEnum Geslacht)
        {
            this.Voornaam = Voornaam;
            this.Achternaam = Achternaam;
            this.Lengte = Lengte;
            this.Gewicht = Gewicht;
            this.Geslacht = Geslacht;
        }

        public void SetScore()
        {
            //In deze functie wordt de dagelijks aanbevolen hoeveelheid berekend en vergeleken met het landelijk gemiddelde.
            //
        }


        public enum GeslachtEnum
        {
            Man,
            Vrouw,
            Nonbinair,
            Niet_ingevuld
        }
    }

}
