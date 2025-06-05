using System.Collections;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjsTema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> persones = new List<Persona>
            {
                new Persona ("Pepe", 25, "Barcelona"),
                new Persona ("Joan", 30, "Madrid"),
                new Persona ("Maria", 22, "Valencia"),
                new Persona ("Ana", 28, "Sevilla"),
                new Persona ("Luis", 35, "Girona"),
                new Persona ("Laura", 27, "Zaragoza"),
            };

            //Obtenir totes les persones majors de 25 anys.
            var personesMajorsDe25 = persones.Where(p => p.Edat > 25).ToList();
            Console.WriteLine("Persones majors de 25 anys:");
            foreach (var persona in personesMajorsDe25)
            {
                Console.WriteLine($"{persona.Nom}, {persona.Edat} anys, {persona.Ciutat}");
            }

            //Obtenir totes les persones que visquin a "Barcelona" o "Girona".
            var personesBCNGirona = persones.Where(p => p.Ciutat == "Barcelona" || p.Ciutat == "Girona").ToList();
            Console.WriteLine("\nPersones que viuen a Barcelona o Girona:");
            foreach (var persona in personesBCNGirona)
            {
                Console.WriteLine($"{persona.Nom}, {persona.Edat} anys, {persona.Ciutat}");
            }

            //Obtenir la persona més jove de cada ciutat
            var personesPerCiutat = persones.GroupBy(p => p.Ciutat)
                .Select(g => g.OrderBy(p => p.Edat).First())
                .ToList();
            Console.WriteLine("\nPersona més jove de cada ciutat:");
            foreach (var persona in personesPerCiutat)
            {
                Console.WriteLine($"{persona.Nom}, {persona.Edat} anys, {persona.Ciutat}");
            }

            //Comptar quantes persones hi ha de cada ciutat
            var comptadorPersonesPerCiutat = persones.GroupBy(p => p.Ciutat)
                .Select(g => new { Ciutat = g.Key, Comptador = g.Count() })
                .ToList();
            Console.WriteLine("\nComptador de persones per ciutat:");
            foreach (var ciutat in comptadorPersonesPerCiutat)
            {
                Console.WriteLine($"{ciutat.Ciutat}: {ciutat.Comptador} persones");
            }
        }
    }    
}