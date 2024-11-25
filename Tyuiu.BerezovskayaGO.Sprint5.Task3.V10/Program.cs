using Tyuiu.BerezovskayaGO.Sprint5.Task3.V10.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint5.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Беерзовская Г. О. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                        *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                                              *");
            Console.WriteLine("* Задание #3                                                                                       *");
            Console.WriteLine("* Вариант #10                                                                                      *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                           *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дано выражение вычислить его значение при х = 4, результат сохранить в бинарный файл и вывести   *");
            Console.WriteLine("* его на консоль. Округлить до трех знаков после запятой                                           *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
