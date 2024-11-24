using System.IO;
using Tyuiu.BerezovskayaGO.Sprint5.Task1.V16.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint5.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.BerezovskayaGO.Sprint5\Tyuiu.BerezovskayaGO.Sprint5.Task1.V16\bin\Debug\net8.0\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}