using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercise10
{
    public class WordsTable
    {
        public static SortedDictionary<string, int> WordTableConstructor(string input)
        {
            SortedDictionary<string, int> table = new SortedDictionary<string, int>();
            string[] inputWords = input.ToLower().Split(new char[] { '(', ')', '[', ']', '{', '}', '<', '>', ' ', ',', ';', '.', ':', '!', '?', '-', '"', '\''}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in inputWords)
            {
                if (table.ContainsKey(word))
                {
                    table[word]++;
                }
                else
                {
                    table.Add(word, 1);
                }
            }
            table.OrderBy(key => key.Key);

            return table;
        }
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            foreach (var word in WordTableConstructor(userInput))
            {
                Console.WriteLine(word.Key + "\t\t" + word.Value);
            }
        }
    }
}
