using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Exercise03
{
    public static class FolderTraverse
    {
        public static List<string> GetFiles(string path)
        {
            List<string> files = new List<string>();

            files.AddRange(Directory.GetFiles(path));
            foreach (var directory in Directory.GetDirectories(path))
                files.AddRange(GetFiles(directory));

            return files;
        }

        public static List<string> GetFilesSAFE(string path)
        {
            var files = new List<string>();
            //Uso un try catch per evitare "UnauthorizedAccessException"
            try
            {
                files.AddRange(Directory.GetFiles(path));
                foreach (var directory in Directory.GetDirectories(path))
                    files.AddRange(GetFilesSAFE(directory));
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("UnauthorizedAccessException found at:\n{0}\n", path);
            }

            return files;
        }

        static void Main()
        {
            string path = @"C:\windows\system32";
            List<string> filesAndFolders = GetFilesSAFE(path);
        }
    }
}
