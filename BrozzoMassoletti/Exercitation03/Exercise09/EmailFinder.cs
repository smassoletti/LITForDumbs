using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;


namespace Exercise09
{
    public class EmailFinder
    {
        public static string [] ExtractEmail(string input)

        {
            Regex emailRegex = new Regex(@"([A-Z0-9._%+-]+)@([A-Z0-9.-]+)\.([A-Z]{2,4})", RegexOptions.IgnoreCase);
            //find items that matches with our pattern
            MatchCollection emailMatches = emailRegex.Matches(input);
            
            int i = 0;
            string [] extracted = new String [emailMatches.Count];
            foreach (Match emailMatch in emailMatches)
            {
                extracted [i] = emailMatch.Value;
                i++;
            }

            return extracted;
        }

        static void Main(string[] args)
        {
            string input = "Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";
            Console.WriteLine(ExtractEmail(input)[0]);
            Console.WriteLine(ExtractEmail(input)[1]);
        }
    }
}
