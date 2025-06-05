using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema4
{
    public class Producte
    {
        public string Nom { get; set; }
        public decimal Preu { get; set; }
        public string Categoria { get; set; }
        public Producte(string nom, decimal preu, string categoria)
        {
            Nom = nom;
            Preu = preu;
            Categoria = categoria;
        }
    }
}