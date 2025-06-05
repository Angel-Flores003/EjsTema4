using System.Collections;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjsTema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataneix;
            int dia, mes, any;

            Console.WriteLine("Introdueïx una data en fotmat (dd//MM/yyyy)");
            dataneix = Console.ReadLine();


            if (DateTime.TryParseExact(dataneix, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNaixement))
            {
                DateTime avui = DateTime.Today;

                // Calcular edat exacta
                any = avui.Year - dataNaixement.Year;
                mes = avui.Month - dataNaixement.Month;
                dia = avui.Day - dataNaixement.Day;

                if (dia < 0)
                {
                    mes--;
                    dia += DateTime.DaysInMonth(avui.Year, (avui.Month == 1) ? 12 : avui.Month - 1);
                }

                if (mes < 0)
                {
                    any--;
                    mes += 12;
                }

                Console.WriteLine($"\nTens {any} anys, {mes} mesos i {dia} dies.");

                // Dia de la setmana
                Console.WriteLine($"Vas néixer un {dataNaixement.ToString("dddd", new CultureInfo("ca-ES"))}.");

                // Proper aniversari
                DateTime properAniversari = new DateTime(avui.Year, dataNaixement.Month, dataNaixement.Day);
                if (properAniversari < avui)
                {
                    properAniversari = properAniversari.AddYears(1);
                }

                int diesFalten = (properAniversari - avui).Days;
                Console.WriteLine($"Falten {diesFalten} dies pel teu proper aniversari.");
            }
            else
            {
                Console.WriteLine("Data no vàlida.");
            }
        }
    }    
}