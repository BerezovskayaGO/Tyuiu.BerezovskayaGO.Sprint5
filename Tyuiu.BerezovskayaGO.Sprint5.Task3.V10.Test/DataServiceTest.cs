using System.IO;
using Tyuiu.BerezovskayaGO.Sprint5.Task3.V10.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint5.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.BerezovskayaGO.Sprint5\Tyuiu.BerezovskayaGO.Sprint5.Task3.V10\bin\Debug\net8.0\OutPutFileTask3.bin";

            FileInfo fileUnfo = new FileInfo(path);
            bool fileInfo = fileUnfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileInfo);
        }
    }
}