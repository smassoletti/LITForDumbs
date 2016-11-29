using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PersonalMethods;

namespace Exercise06
{
    public class FileParse
    {
        public static void FileParsing(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                int i = 1;
                while (line != null)
                {
                    int number;
                    if (!int.TryParse(line, out number))
                    {
                        throw new FileParseException("File could not be parsed:", path, i, line);
                    }
                    Console.WriteLine(UsefulMethods.AddOrdinal(i) + "integer: " + number);
                    line = reader.ReadLine();
                    i++;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please type the file path:");
            string path = Console.ReadLine();
            try
            {
                FileParsing(path);
            }
            catch (FileParseException ex)
            {
                Console.WriteLine(ex.message);
                Console.WriteLine("Integer expected at line " + ex.line + " of file " + ex.fileName);
                Console.WriteLine("Found: " + ex.found);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The specified file could not be found");
            }
        }
    }
}
