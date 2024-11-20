using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerezovskayaGO.Sprint5.Task0.V26.Lib
{
    public class DataService : ISprint5Task0V26
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{ Directory.GetCurrentDirectory()}\OutPutFileTassk0.txt";
            double f = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);
            f = Math.Round(f, 3);
            File.WriteAllText(path, Convert.ToString(f));
            return path;

        }
    }
}
