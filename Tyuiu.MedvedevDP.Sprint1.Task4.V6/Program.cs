using Tyuiu.MedvedevDP.Sprint1.Task4.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        double x; double y;
        x = Convert.ToDouble(Console.ReadLine());
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(dataService.Calculate(x,y));
    }
}