using System;
namespace Template
{
    abstract class Crypt
    {
        public void MainFunction()
        {
            string FileContent = GetContent();
            string Content = DoCrypt(FileContent);
            SaveContent(Content);
        }
        static string DoCrypt(string Filecontent)
        {
            static char Crypter(char character, ushort secretKey)
            {
                character = (char)(character ^ secretKey);
                return character;
            }
            string NewStr = "";
            foreach (var c in Filecontent)
                NewStr += Crypter(c, 0x0088);
            return NewStr;
        }
        public abstract string GetContent();
        public abstract void SaveContent(string Content);

    }
}

