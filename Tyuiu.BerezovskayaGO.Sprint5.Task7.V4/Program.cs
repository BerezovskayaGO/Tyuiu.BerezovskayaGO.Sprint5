using Tyuiu.BerezovskayaGO.Sprint5.Task7.V4.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint5.Task7.V4
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
            Console.WriteLine("* Задание #7                                                                                       *");
            Console.WriteLine("* Вариант #4                                                                                       *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                           *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных.                                                *");
            Console.WriteLine("* Заменить все русские буквы на #.                                                                 *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            string path = @"C:\Users\Admin\source\repos\Tyuiu.BerezovskayaGO.Sprint5\DataSprint5\InPutDataFileTask7V4.txt";
            string path2 = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V4.txt" });

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            path2 = ds.LoadDataAndSave(path);
            Console.WriteLine(path2);
            Console.ReadKey();
        }
    }
}
