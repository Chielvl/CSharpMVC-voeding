using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoedingClassLibrary
{
    public class DagelijkseAanbevolenHoeveelheid
    {
        public int Id { get; set; }
        public string Name { get; } = "Dagelijkse Aanbevolen Hoeveelheid";

        public Voedingswaarden VoedingswaardenDah { get; set; }
        public Vitaminen VitaminenDah { get; set; }
        public Mineralen MineralenDah { get; set; }

    }
}
