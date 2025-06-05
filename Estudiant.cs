using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema4
{
    public class Estudiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Cognoms { get; set; }
        public int Edat { get; set; }
        public double NotaMitjana { get; set; }
        public Estudiant(int id, string nom, string cognoms, int edat, double notaMitjana)
        {
            Nom = nom;
            Cognoms = cognoms;
            Edat = edat;
            NotaMitjana = notaMitjana;
        }
        public override string ToString()
        {
            return $"{Nom} {Cognoms}, {Edat} anys, {NotaMitjana}";
        }
    }
}