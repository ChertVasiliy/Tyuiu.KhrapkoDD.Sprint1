using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhrapkoDD.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string Convert(string number)
        {
            if (decimal.TryParse(number, out decimal amount))
            {
                decimal roundedAmount = Math.Round(amount, 3);
                int rubles = (int)roundedAmount;
                int kopecks = (int)((roundedAmount - rubles) * 100);
                var res = $"ответ {rubles} руб. {kopecks:D2} коп.";
                return res;
            }
            else
            {
                return "Неверный ввод!";
            }
        }
    }
}

