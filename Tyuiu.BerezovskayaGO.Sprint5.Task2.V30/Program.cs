﻿using Tyuiu.BerezovskayaGO.Sprint5.Task2.V30.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint5.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3] { { 3, -1, -3 },
                                           { -2, -5, 0 },
                                           { -8, -7, 2 } };

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Березовская Г. О. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                        *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                                          *");
            Console.WriteLine("* Задание #2                                                                                       *");
            Console.WriteLine("* Вариант #30                                                                                      *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                           *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры.        *");
            Console.WriteLine("* Заменить положительные элементы массива на 1, отрицательные на 0.                                *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");
            string res = ds.SaveToFileTextData(matrix);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
