using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class VeryLongUInt
    {
        public static byte[] VeryLongUIntInput(string promptMessage = "")
        {
            byte[] userInput;
            bool conversionSuccessful = true;
            
            do
            {
                Console.Write(promptMessage);
                char[] charArray = Console.ReadLine().ToCharArray();
                userInput = new byte[charArray.Length];
                for (int i = 0; i < charArray.Length; i++)
                {
                    conversionSuccessful = byte.TryParse(charArray[i].ToString(), out userInput[i]);
                    if (!conversionSuccessful)
                    {
                        Console.WriteLine("Not a positive integer");
                        break;
                    }
                }
            }
            while (!conversionSuccessful);

            return userInput;
        }

        public static byte[] VeryLongUIntSum(byte[] a, byte[] b)
        {
            Array.Reverse(a);
            Array.Reverse(b);
            byte[] result = new byte[10000];
            Array.Resize(ref a, 10000);
            Array.Resize(ref b, 10000);

            result[0] = (byte)((a[0] + b[0]) % 10);

            int carry = 0;
            for (int i = 1; i < 10000; i++)
            {
                result[i] = (byte)((a[i] + b[i]) % 10 + (a[i - 1] + b[i - 1]) / 10 + carry);
                carry = 0;
                if (result[i] >= 10)
                {
                    carry = result[i] / 10;
                    result[i] -= 10;
                }
            }

            int zeroCount = 0;
            for (int i = 9999; i >= 0; i--)
            {
                if (result[i] != 0)
                {
                    break;
                }
                zeroCount++;
            }
            
            if (zeroCount < result.Length)
            {
                Array.Resize(ref result, result.Length - zeroCount);
            }
            else
            {
                Array.Resize(ref result, 1);
            }
            
            Array.Reverse(result);
            return result;
        }

        public static void VeryLongUIntPrint(byte[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i]);
            }
        }

        static void Main(string[] args)
        {
            byte[] number1 = VeryLongUIntInput("Enter a positive integer: ");
            byte[] number2 = VeryLongUIntInput("Enter a positive integer: ");

            Console.Write("The sum is: ");
            VeryLongUIntPrint(VeryLongUIntSum(number1, number2));
            Console.WriteLine();
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Exercise02
//{
//    public class VeryLongUInt
//    {
//        public static byte[] VeryLongUIntInput(string promptMessage = "")
//        {
//            byte[] userInput = new byte[10000];
//            bool conversionSuccessful = true;

//            do
//            {
//                Console.Write(promptMessage);
//                char[] charArray = Console.ReadLine().ToCharArray();
//                for (int i = 0; i < charArray.LongLength; i++)
//                {
//                    conversionSuccessful = byte.TryParse(charArray[i].ToString(), out userInput[charArray.LongLength - i - 1]);
//                    if (!conversionSuccessful)
//                    {
//                        Console.WriteLine("Not a positive integer");
//                        break;
//                    }
//                }
//            }
//            while (!conversionSuccessful);

//            return userInput;
//        }

//        public static byte[] VeryLongUIntSum(byte[] a, byte[] b)
//        {
//            byte[] result = new byte[10000];

//            result[0] = (byte)((a[0] + b[0]) % 10);
//            for (int i = 1; i < 10000; i++)
//            {
//                result[i] = (byte)((a[i] + b[i]) % 10 + (a[i - 1] + b[i - 1]) / 10);
//            }

//            return result;
//        }

//        public static void VeryLongUIntPrint(byte[] number)
//        {
//            bool numberStarted = false;

//            for (int i = 9999; i >= 0; i--)
//            {
//                if (!numberStarted)
//                {
//                    if (number[i] != 0)
//                    {
//                        numberStarted = true;
//                    }
//                }
//                else
//                {
//                    Console.Write(number[i]);
//                }
//            }
//        }

//        static void Main(string[] args)
//        {
//            byte[] number1 = VeryLongUIntInput("Enter a positive integer: ");
//            byte[] number2 = VeryLongUIntInput("Enter a positive integer: ");

//            Console.Write("The sum is: ");
//            VeryLongUIntPrint(VeryLongUIntSum(number1, number2));
//            Console.WriteLine();
//        }
//    }
//}
