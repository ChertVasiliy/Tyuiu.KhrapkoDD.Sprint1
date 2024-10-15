using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KhrapkoDD.Sprint1.Task7.V18.Lib
{
    public class DataService : ISprint1Task7V18
    {

        public double Calculate(double x, double y)
        {
                double numerator = 1 + Math.Pow(Math.Sin(x + y), 2);
                double denominator = 2 + Math.Abs(x - ((2 * x) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2))));
                double z = numerator / denominator;
                return Math.Round(z, 3);
        }
      
    }
}
