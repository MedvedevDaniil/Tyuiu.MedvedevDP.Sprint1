using Tyuiu.MedvedevDP.Sprint1.Task7.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();

        double x = Convert.ToDouble(Console.ReadLine());

        double y = Convert.ToDouble(Console.ReadLine());

        double z = dataService.Calculate(x, y);

        Console.WriteLine(z);
    }
}