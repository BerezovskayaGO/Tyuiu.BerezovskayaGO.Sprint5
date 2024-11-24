using System.IO;
using Tyuiu.BerezovskayaGO.Sprint5.Task2.V30.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint5.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.BerezovskayaGO.Sprint5\Tyuiu.BerezovskayaGO.Sprint5.Task2.V30\bin\Debug\net8.0\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}