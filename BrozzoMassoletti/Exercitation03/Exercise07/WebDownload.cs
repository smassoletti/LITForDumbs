using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Exercise07
{
    public class DownloadException : System.ApplicationException
    {
        public DownloadException(string exceptionMessage)
            : base()
        {
            this.message = exceptionMessage;
        }

        public DownloadException(string exceptionMessage, Exception typeOfException)
            : base(null, typeOfException)
        {
            this.message = exceptionMessage;
        }

        private string message;
        public override string Message
        {
            get
            {
                return this.message;
            }
        }
    }

    public class WebDownload
    {
        public static string SaveFile(string URL)
        {
            WebClient myWebClient = new WebClient();
            Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n", Path.GetFileName(URL), URL);

            try
            {
                myWebClient.DownloadFile(URL, Path.GetFileName(URL));
            }

            catch (WebException excp)
            {
                throw new DownloadException(excp.Message, excp);
            }

            catch (ArgumentNullException excp)
            {
                throw new DownloadException(excp.Message, excp);
            }

            catch (NotSupportedException excp)
            {
                throw new DownloadException(excp.Message, excp);
            }

            finally
            {
                myWebClient.Dispose();
            }

            Console.WriteLine("Successfully Downloaded!");
            return Path.GetFullPath(Path.GetFileName(URL));
        }

        static void Main()
        {

        }
    }
}
