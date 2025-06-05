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
            List<string> inputList = new List<string>
            {
                "7,ocho,9,deu,12",
                "1,2,tres,4,cinc,6",
                "un,dos,3,quatre,5,sis"
            };

            foreach (var input in inputList)
            {
                var integerList = input.ToIntegerList();
                Console.WriteLine($"Input: {input}");
                Console.WriteLine("Output: " + string.Join(", ", integerList) + "\n");
            }
        }
    }    
}