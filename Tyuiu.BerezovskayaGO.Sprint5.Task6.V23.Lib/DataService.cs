using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BerezovskayaGO.Sprint5.Task6.V23.Lib
{
    public class DataService : ISprint5Task6V23
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        if (word == "-")
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
