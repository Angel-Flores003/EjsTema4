using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema4
{
    public class Persona
    {
        public string Nom { get; set; }
        public int Edat { get; set; }
        public string Ciutat { get; set; }
        public Persona(string nom, int edat, string ciutat)
        {
            Nom = nom;
            Edat = edat;
            Ciutat = ciutat;
        }
    }
}