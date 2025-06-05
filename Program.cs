using System.Collections;

namespace EjsTema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable dades = new Hashtable();
            dades["nom"] = "Joan";
            dades["edat"] = 30;
            dades["ciutat"] = "Barcelona";
            dades["programador"] = true;

            // Mostrar les dades
            Console.WriteLine("Dades de la persona:");
            foreach (DictionaryEntry entry in dades)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            // Comprovar si la clau "professio" existeix i l'afegeix si no existeix
            if (!dades.ContainsKey("professio"))
            {
                dades["professio"] = "Desenvolupador";
                Console.WriteLine("\nS'ha afegit la clau 'professio'.");
            }
            else
            {
                Console.WriteLine("\nLa clau 'professio' ja existeix.");
            }

            //Elimina la clau "programador"
            if (dades.ContainsKey("programador"))
            {
                dades.Remove("programador");
                Console.WriteLine("\nS'ha eliminat la clau 'programador'.");
            }
            else
            {
                Console.WriteLine("\nLa clau 'programador' no existeix.");
            }

            // Mostrar les dades actualitzades
            Console.WriteLine("\nDades actualitzades de la persona:");
            foreach (DictionaryEntry entry in dades)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}