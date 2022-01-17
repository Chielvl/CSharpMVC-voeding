using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoedingClassLibrary
{
    public class Product
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public Voedingswaarden Voedingswaarden { get; set; }
    }
}
