namespace EjsTema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime i string
            Pair<DateTime, string> pair1 = new Pair<DateTime, string>(DateTime.Now, "Data i hora actual");
            var values1 = pair1.GetValues();
            Console.WriteLine($"Data: {values1.Item1}, Descripció: {values1.Item2}");

            //int y List<string>
            Pair<int, List<string>> pair2 = new Pair<int, List<string>>(3, new List<string> { "Element1", "Element2", "Element3" });
            var values2 = pair2.GetValues();
            Console.WriteLine($"Número: {values2.Item1}, Llista: {string.Join(", ", values2.Item2)}");
        }
    }
}