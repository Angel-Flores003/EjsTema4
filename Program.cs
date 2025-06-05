using System.Collections;

namespace EjsTema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 42, 15, 8, 23, 97, 16 };

            //Flitrar els números parells amb LINQ
            var numerosParells = numeros.Where(n => n % 2 == 0);

            //Ordenar els números parells de forma ascendent
            var numerosParellsOrdenats = numerosParells.OrderBy(n => n);
            Console.WriteLine("Números parells ordenats:");
            
            foreach (var numero in numerosParellsOrdenats)
            {
                Console.WriteLine(numero);
            }

            //Suma dels números parells
            var sumaNumerosParells = numerosParellsOrdenats.Sum();

            Console.WriteLine($"Suma dels números parells: {sumaNumerosParells}");
        }
    }
}