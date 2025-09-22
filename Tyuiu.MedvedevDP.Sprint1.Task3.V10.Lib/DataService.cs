using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MedvedevDP.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            number = Math.Round(number,3);

            int rub = (int)number;
            double kopeek = (int)((number - rub) * 10);

            return $"{rub} рублей {kopeek} копеек";
        }
    }
}
