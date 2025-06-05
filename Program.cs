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
            string fitxer = "estudiants.json";

            List<Estudiant> estudiants = new List<Estudiant>
            {
                new Estudiant(1, "Joan", "Pérez", 20, 8.6),
                new Estudiant(2, "Maria", "García", 22, 3.0),
                new Estudiant(3, "Jordi", "López", 21, 1.5),
                new Estudiant(4, "Anna", "Martínez", 19, 9.2)
            };

            //Desi la llista en format JSON
            var json = JsonSerializer.Serialize(estudiants, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fitxer, json);

            Console.WriteLine("Llista d'estudiants en format JSON guardada correctament");

            //Llegeixi el fitxer "estudiants.json"
            if (File.Exists(fitxer))
            {
                string jsonFromFile = File.ReadAllText(fitxer);
                List<Estudiant> estudiantsFromFile = JsonSerializer.Deserialize<List<Estudiant>>(jsonFromFile);
                
                //Mostra la llista d'estudiants ordenades per nota mitjana (de major a menor)
                List<Estudiant> estudiantsOrdenats = estudiantsFromFile.OrderByDescending(e => e.NotaMitjana).ToList();
                
                Console.WriteLine("Llista d'estudiants ordenada per nota mitjana (de major a menor):");
                foreach (var estudiant in estudiantsOrdenats)
                {
                    Console.WriteLine(estudiant);
                }
            }
            else
            {
                Console.WriteLine("El fitxer no existeix.");
            }
        }
    }    
}