using System.IO;

namespace CourseWork
{
    public class File
    {
        string _coordinate;

        public string ReadFile()
        {
            using (FileStream fs = System.IO.File.OpenRead("test.txt"))
            {
                if (!System.IO.File.Exists("test.txt"))
                {
                    throw new FileLoadException();
                }
                else
                {
                    byte[] array = new byte[fs.Length];
                    fs.Read(array, 0, array.Length);
                    _coordinate = System.Text.Encoding.Default.GetString(array);
                }
                return _coordinate;

            }

        }
    }

}