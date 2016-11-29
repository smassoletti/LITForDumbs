using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalMethods;

namespace Exercise01
{
    public class GTNMethods
    {
        
        public static bool GTN (int [] array, int p)
        {
            if (array.Length - 1 == 0) return false; //caso lunghezza zero

            else if (p == 0) //caso primo elemento
            {
                if (array[p] > array[p + 1]) return true;
            }

            else if (p == array.Length - 1) //caso ultimo elemento
            {
                if (array[p] > array[p - 1])
                    return true;
            }
            else if (array[p] > array[p + 1] && array[p] > array[p - 1]) //caso generale
            {
                return true;
            }

            return false;
        }

        public static int GTNFind (int [] array)
        {
            int i;
            for (i = 0; i < array.Length; i++)
            {
                if (GTN(array, i)) return i;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Console.Write("Insert array lenght: ");
            int[] array = new int[UsefulMethods.InputInt()];
            Console.WriteLine("Insert test elements");
            array = UsefulMethods.MakeArray(array.Length);

            if (GTNFind(array) != -1)
                Console.WriteLine("The position of the first GTN in the array is [{0}]", GTNFind(array));

            else
                Console.WriteLine("No GTN were found in the array!");

        }
    }
}
