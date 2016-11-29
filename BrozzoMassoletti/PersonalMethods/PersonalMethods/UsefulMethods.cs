using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalMethods
{
    public class UsefulMethods
    {
        public static int InputInt(Predicate<int> Condition, string promptMessage = "")
        {
            int userInput;
            Console.Write(promptMessage);
            while (!int.TryParse(Console.ReadLine(), out userInput) || !Condition(userInput))
            {
                Console.WriteLine("Not an integer");
                Console.Write(promptMessage);
            }
            return userInput;
        }

        public static int InputInt(string promptMessage = "")
        {
            int userInput;
            Console.Write(promptMessage);
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Not an integer");
                Console.Write(promptMessage);
            }
            return userInput;
        }

        public static int[] MakeArray(int lenght)
        {

            int[] array = new int[lenght];
            for (int i = lenght; i > 0; i--)
            {
                Console.Write("Insert {0} number: ", AddOrdinal(lenght - i + 1));
                array[lenght - i] = InputInt();
            }
            return array;

        }

        //funzione che converte i numeri in ordinali
        public static string AddOrdinal(int num)
        {
            if (num <= 0) return num.ToString();

            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }

            switch (num % 10)
            {
                case 1:
                    return num + "st";
                case 2:
                    return num + "nd";
                case 3:
                    return num + "rd";
                default:
                    return num + "th";
            }

        }

        static void Main()
        {

        }
    }
}
