using OpenQA.Selenium;
using System;
using System.IO;

namespace CourseWork
{
   public  class InputCoordinates
    {
        private IWebDriver webDriver;
        public string coordinate;
        
        public string openFile()
        {
            using (FileStream fs = File.OpenRead("test.txt"))
            {
                if (File.Exists("test.txt") == true)
                {
                    byte[] array = new byte[fs.Length];
                    fs.Read(array, 0, array.Length);
                    string coordinate = System.Text.Encoding.Default.GetString(array);
                    Console.WriteLine($"Text is {coordinate}");
                }
               else 
                Console.WriteLine("File is not found");
                return coordinate;

            }

        }
        public void useCoordinates()
        {

        }
    }

}