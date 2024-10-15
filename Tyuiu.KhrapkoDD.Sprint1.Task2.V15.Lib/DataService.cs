using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhrapkoDD.Sprint1.Task2.V15.Lib
{
    public class DataService : ISprint1Task2V15
    {
        public int ConvertHourToMin(double x)
        {
            return (int)Math.Pow( x,3);
        }
    }

    public interface ISprint1Task2V15
    {
    }
}
