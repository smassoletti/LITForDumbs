using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    public class RandomAds
    {
        public static string[] Phrases = new string[]
        {"The product is excellent.", "This is a great product.", "I use this product constantly.",
        "This is the best product from this category."};

        public static string[] Stories = new string[]
        {"Now I feel better.", "I managed to change.", "It made some miracle.",
         "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."};

        public static string[] FirstNames = new string[] { "Dayan", "Stella", "Hellen", "Kate" };
        public static string[] LastNames = new string[] { "Johnson", "Peterson", "Charles" };
        public static string[] Cities = new string[] { "London", "Paris", "New York", "Berlin", "Madrid" };

        private static Random rnd = new Random();

        public static string MessageGenerator()
        {
            int i = rnd.Next();
            StringBuilder msg = new StringBuilder();

            rnd = new Random(i);
            i = rnd.Next();
            msg.Append(Phrases[i % (Phrases.Length)] + " ");

            rnd = new Random(i);
            i = rnd.Next();
            msg.Append(Stories[i % (Stories.Length)] + "\n-- ");

            rnd = new Random(i);
            i = rnd.Next();
            msg.Append(FirstNames[i % (FirstNames.Length)] + " ");

            rnd = new Random(i);
            i = rnd.Next();
            msg.Append(LastNames[i % (LastNames.Length)] + ", ");

            rnd = new Random(i);
            i = rnd.Next();
            msg.Append(Cities[i % (Cities.Length)]);

            return msg.ToString();
        }

        public static void Main()
        {
            Console.WriteLine(MessageGenerator() + "\n");
            Console.WriteLine(MessageGenerator() + "\n");
            Console.WriteLine(MessageGenerator() + "\n");
            Console.WriteLine(MessageGenerator() + "\n");
            Console.WriteLine(MessageGenerator() + "\n");
            Console.WriteLine(MessageGenerator() + "\n");
            Console.WriteLine(MessageGenerator() + "\n");
            Console.WriteLine(MessageGenerator() + "\n");
            Console.WriteLine(MessageGenerator() + "\n");

        }
    }
}
