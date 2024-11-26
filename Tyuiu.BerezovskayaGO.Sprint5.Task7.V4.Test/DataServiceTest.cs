using System.IO;
using Tyuiu.BerezovskayaGO.Sprint5.Task7.V4.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint5.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.BerezovskayaGO.Sprint5\DataSprint5\OutPutDataFileTask7V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}