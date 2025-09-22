using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MedvedevDP.Sprint1.Task7.V29.Lib
{
    public class DataService : ISprint1Task7V29
    {
        public double Calculate(double x, double y)
        {
            double x3 = Math.Pow(x, 3);
            double x5 = Math.Pow(x, 5);

            double cosX3 = Math.Cos(x3);
            double sinX5 = Math.Sin(x5);

            double znam1 = x * y - 3;
            double znam2 = x * y + 5;

            double z = x - (cosX3 / znam1) + (sinX5 / znam2);
            return Math.Round(z, 3);
        }
    }
}
