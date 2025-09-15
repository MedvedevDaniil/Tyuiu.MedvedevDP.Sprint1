using Tyuiu.MedvedevDP.Sprint1.Task1.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        double x,y;

        Console.WriteLine("Vvedi x");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(ds.Calculate(x));
        Console.ReadLine();
    }
}