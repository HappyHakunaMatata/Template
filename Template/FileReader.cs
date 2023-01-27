using System;
using System.IO;

namespace Template
{
    class ReadFile : Crypt
    {
        public override string GetContent()
        {
            string FileContent;
            using (FileStream fstream = File.OpenRead(@"data.cfg"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                FileContent = System.Text.Encoding.Default.GetString(array);
            }
            return FileContent;
        }
        public override void SaveContent(string content)
        {
            Console.WriteLine("File reader result: " + content);
        }
    }
}

