using System.IO;
using Tyuiu.BerezovskayaGO.Sprint5.Task4.V14.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint5.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.BerezovskayaGO.Sprint5\DataSprint5\InPutDataFileTask4V14.txt"; 

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}