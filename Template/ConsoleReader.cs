using System;
namespace Template
{
    class ReadLine : Crypt
    {
        public override string GetContent()
        {
            string FileContent;
            Console.WriteLine("Enter data: ");
            FileContent = Console.ReadLine();
            return FileContent;
        }
        public override void SaveContent(string content)
        {
            Console.WriteLine("Console reader result: " + content);
        }
    }
}

