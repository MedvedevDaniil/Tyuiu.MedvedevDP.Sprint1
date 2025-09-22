using System.Text.RegularExpressions;
using Tyuiu.MedvedevDP.Sprint1.Task3.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(ds.NumberToMoney(x));
    }
}