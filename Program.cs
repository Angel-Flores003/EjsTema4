using System.Collections;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace EjsTema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10, y = 5;

            OperacioMatematica suma = (paramether1, paramether2) => paramether1 + paramether2;
            OperacioMatematica resta = (paramether1, paramether2) => paramether1 - paramether2;
            OperacioMatematica multiplicacio = (paramether1, paramether2) => paramether1 * paramether2;
            OperacioMatematica divisio = (paramether1, paramether2) => paramether2 != 0 ? paramether1 / paramether2 : double.NaN;

            double ExecutarOperacio(double paramether1, double paramether2, OperacioMatematica operacio)
            {
                return operacio(paramether1, paramether2);
            }

            Console.WriteLine($"Suma: {ExecutarOperacio(x, y, suma)}");
            Console.WriteLine($"Resta: {ExecutarOperacio(x, y, resta)}");
            Console.WriteLine($"Multiplicació: {ExecutarOperacio(x, y, multiplicacio)}");
            Console.WriteLine($"Divisió: {ExecutarOperacio(x, y, divisio)}");
        }
    }
    public delegate double OperacioMatematica(double paramether1, double paramether2); 
}