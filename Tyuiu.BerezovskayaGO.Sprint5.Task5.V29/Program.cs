using Tyuiu.BerezovskayaGO.Sprint5.Task5.V29.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint5.Task5.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Березовская Г. О. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                        *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла.                                                  *");
            Console.WriteLine("* Задание #5                                                                                       *");
            Console.WriteLine("* Вариант #29                                                                                      *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                           *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан файл  в котором есть набор значений. Найти минимальное целое число в файле,  которое         *");
            Console.WriteLine("* является двузначным числом. Полученный результат вывести на консоль. У вещественных              *");
            Console.WriteLine("* значений округлить до трёх знаков после запятой.                                                 *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            string path = @"C:\Users\Admin\source\repos\Tyuiu.BerezovskayaGO.Sprint5\DataSprint5\InPutDataFileTask5V29.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Минимальное целое двузначное число = " + res);
            Console.ReadKey();
        }
    }
}
