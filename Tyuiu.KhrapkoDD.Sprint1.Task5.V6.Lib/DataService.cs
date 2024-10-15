using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhrapkoDD.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public static int GetDayOfWeek(int k)
        {
            if (k < 1 || k > 365)
                throw new ArgumentOutOfRangeException(nameof(k), "k должен быть от 1 до 365.");

            // 1 января - это понедельник, что соответствует 1
            // Для определения дня недели можно использовать цикл
            return (k - 1) % 7 + 1; // Возвращает значение от 1 до 7
        }
    }
}
