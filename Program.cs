using System.Collections;

namespace EjsTema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producte> productes = new List<Producte>
            {
                new Producte("Pa", 1.2m, "Alimentació"),
                new Producte("Llet", 0.9m, "Alimentació"),
                new Producte("Sabó", 2.5m, "Neteja"),
                new Producte("Portàtil", 799.99m, "Electrònica")
            };

            //Mostrar tots els productes
            Console.WriteLine("Llista de productes:");
            foreach (var producte in productes)
            {
                Console.WriteLine($"Nom: {producte.Nom}, Preu: {producte.Preu}, Categoria: {producte.Categoria}");
            }

            //Agrupar els productes per categoria.
            var productesPerCategoria = productes.GroupBy(p => p.Categoria);            

            //Mostrar el nom i preu de cada producte agrupat per categoria
            Console.WriteLine("\nProductes agrupats per categoria:");
            foreach (var categoria in productesPerCategoria)
            {
                Console.WriteLine($"Categoria: {categoria.Key}");
                foreach (var producte in categoria)
                {
                    Console.WriteLine($"  Nom: {producte.Nom}, Preu: {producte.Preu}");
                }
            }
        }
    }
}