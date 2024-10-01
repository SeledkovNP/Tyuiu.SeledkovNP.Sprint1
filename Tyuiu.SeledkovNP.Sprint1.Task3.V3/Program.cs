using Tyuiu.SeledkovNP.Sprint1.Task3.V3.Lib;

namespace Tyuiu.SeledkovNP.Sprint1.Task3.V3;

class Program
{
    static void Main(string[] args)
    { 
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Селедков Н. П. | Смартб-24-1";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнил: Селедков Никита Павлович | Смартб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int length;
        int width;
        int height;

        Console.WriteLine("Введите значение длины: ");
        length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение ширины: ");
        width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение высоты: ");
        height = Convert.ToInt32(Console.ReadLine());




        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Объем: " + ds.ParallelepipedVolume(length, width, height) + " см.куб. ");

        Console.ReadKey();
    }
}
