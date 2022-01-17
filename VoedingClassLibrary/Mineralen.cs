using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoedingClassLibrary
{
    public class Mineralen
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public float Natrium { get; set; }              //in milligrammen
        public float Kalium { get; set; }             //in milligrammen
        public float Calcium { get; set; }             //in milligrammen
        public float Fosfor { get; set; }             //in milligrammen
        public float Ijzer { get; set; }             //in milligrammen
        public float Magnesium { get; set; }            //in milligrammen
        public float Koper { get; set; }            //in milligrammen
        public float Zink { get; set; }              //in milligrammen
        public float Seleen { get; set; }              //in microgrammen
        public float Jodium { get; set; }              //in microgrammen
        public float Mangaan { get; set; }              //in microgrammen            

        public Mineralen(float EnergNatriumyKcal, float Kalium, float Calcium, float Fosfor, float Ijzer, float Magnesium, float Koper, float Zink, float Seleen, float Jodium, float Mangaan)
        {
            this.Natrium = Natrium;
            this.Kalium = Kalium;
            this.Calcium = Calcium;
            this.Fosfor = Fosfor;
            this.Ijzer = Ijzer;
            this.Magnesium = Mangaan;
            this.Koper = Koper;
            this.Zink = Zink;
            this.Seleen = Seleen;
            this.Jodium = Jodium;
            this.Magnesium = Magnesium;
        }
    }
}