using Tyuiu.SeledkovNP.Sprint1.Task5.V6.Lib;
namespace Tyuiu.SeledkovNP.Sprint1.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Селедков Н. П. | Смартб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | Смартб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            // Пусть k – целое от 1 до 365. Присвоить целой переменной n значение 1,2,...,7 в зависимости от
            // того, на какой день недели (понедельник, вторник,..., воскресенье) приходится k-й день 
            // невисокосного года, в котором 1 января – понедельник.

            int x;
            Console.WriteLine("* Введите день: ");
            x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(x); // Получаем результат от метода Calculate

            // Выводим результат
            Console.WriteLine("Ответ: " + result);

            // Выводим дни недели в соответствии с результатом
            switch (result)
            {
                case 1:
                    Console.WriteLine("1 - понедельник");
                    Console.WriteLine("Следующий день: вторник");
                    break;
                case 2:
                    Console.WriteLine("2 - вторник");
                    Console.WriteLine("Следующий день: среда");
                    break;
                case 3:
                    Console.WriteLine("3 - среда");
                    Console.WriteLine("Следующий день: четверг");
                    break;
                case 4:
                    Console.WriteLine("4 - четверг");
                    Console.WriteLine("Следующий день: пятница");
                    break;
                case 5:
                    Console.WriteLine("5 - пятница");
                    Console.WriteLine("Следующий день: суббота");
                    break;
                case 6:
                    Console.WriteLine("6 - суббота");
                    Console.WriteLine("Следующий день: воскресенье");
                    break;
                case 7:
                    Console.WriteLine("7 - воскресенье");
                    Console.WriteLine("Следующий день: понедельник");
                    break;
                default:
                    Console.WriteLine("Неизвестный день недели");
                    break;
            }
            Console.ReadKey();


        }
    }
}
