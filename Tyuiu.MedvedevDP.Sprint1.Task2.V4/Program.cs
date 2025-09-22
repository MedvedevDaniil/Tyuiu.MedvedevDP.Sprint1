using Tyuiu.MedvedevDP.Sprint1.Task2.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();

        int x;

        x=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(dataService.CalculateSquare(x));
    }
}