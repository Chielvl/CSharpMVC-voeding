using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoedingClassLibrary
{
    public class Agenda
    {
        int Id { get; set; }

        public float[] ScoresVanAfgelopenWeek { get; } = new float[7];      //Telt de afgelopen dagen vanaf de dag van vandaag. Scores van de afgelopen dagen, waarbij ScoresVanAfgelopenWeek[6] vandaag is. 
        public Weekdagen[] AfgelopenDagenNamen { get; set; } = new Weekdagen[7]; //Telt de afgelopen dagen vanaf de dag van vandaag. AfgelopenDagen[0] is dus 6 dagen geleden(dinsdag als het vandaag maandag is)
    }


    public enum Weekdagen
    {
        Maandag,
        Dinsdag,
        Woensdag,
        Donderdag,
        Vrijdag,
        Zaterdag,
        Zondag
    }
}
