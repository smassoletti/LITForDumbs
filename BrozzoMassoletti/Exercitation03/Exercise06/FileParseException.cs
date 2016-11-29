using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    public class FileParseException : ApplicationException
    {
        public string message;
        public string fileName;
        public int line;
        public string found;

        public FileParseException(string message, string fileName, int line, string found)
        {
            this.message = message;
            this.fileName = fileName;
            this.line = line;
            this.found = found;
        }
    }
}
