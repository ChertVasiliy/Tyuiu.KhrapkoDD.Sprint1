using Tyuiu.KhrapkoDD.Sprint1.Task6.V1.Lib;

namespace Tyuiu.KhrapkoDD.Sprint1.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Храпко Д. Д. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #1                                                             *");
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
            Console.WriteLine("Введите символ и нажмите <Enter>.");
            Console.WriteLine("Для завершения введите точку.");

            while (true)
            {
                Console.Write("-> ");
                string input = Console.ReadLine();

                if (input == ".")
                {
                    break;
                }

                if (input.Length == 1)
                {
                    char symbol = input[0];
                    int code = DataService.SymbolCode(symbol);
                    Console.WriteLine($"Символ: {symbol} Код: {code}");
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите один символ.");
                }
            }
        }
    }
}
