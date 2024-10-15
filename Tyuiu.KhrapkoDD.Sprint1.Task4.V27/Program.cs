using Tyuiu.KhrapkoDD.Sprint1.Task4.V27.Lib;

namespace Tyuiu.KhrapkoDD.Sprint1.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService calculator = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Храпко Д. Д. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил Храпко Данил Дмитриевич | ИСТНб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Вычисление результата
            double result = calculator.Calculate(x, y);

            // Округление результата до 3 знаков после запятой
            result = Math.Round(result, 3);

            // Печать результата на экране
            Console.WriteLine($"Результат: {result}");
            Console.ReadLine();
        }
    }
}