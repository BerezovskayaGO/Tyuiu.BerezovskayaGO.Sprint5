using Tyuiu.BerezovskayaGO.Sprint5.Task6.V23.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint5.Task6.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Березовская Г. О. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                        *");
            Console.WriteLine("* Тема: Обработка текстовых файлов.                                                                *");
            Console.WriteLine("* Задание #6                                                                                       *");
            Console.WriteLine("* Вариант #23                                                                                      *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                           *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан файл, в котором в котором есть набор символьных данных.                                      *");
            Console.WriteLine("* Найти количество знаков тире в заданной строке.                                                  *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            string path = @"C:\Users\Admin\source\repos\Tyuiu.BerezovskayaGO.Sprint5\DataSprint5\InPutDataFileTask6V23.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
