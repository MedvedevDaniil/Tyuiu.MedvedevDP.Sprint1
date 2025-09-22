using Tyuiu.MedvedevDP.Sprint1.Task6.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();

        string input = Console.ReadLine();

        string result = dataService.SymbolCode(input);

        Console.WriteLine(result);
    }
}