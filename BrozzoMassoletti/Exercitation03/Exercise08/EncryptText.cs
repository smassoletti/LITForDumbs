using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    public class EncryptText
    {
        public static ushort[] Encrypt(string text, string code)
        {
            List<ushort> encryptedList = new List<ushort>();

            for (int i = 0; i < text.Length; i++)
            {
                encryptedList.Add((ushort)(text[i] ^ code[i % code.Length]));
            }
            return encryptedList.ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text to encrypt");
            string toEncrypt = Console.ReadLine();
            Console.WriteLine("Enter the cipher");
            string encrypter = Console.ReadLine();
            foreach (ushort character in Encrypt(toEncrypt, encrypter))
            {
                Console.Write("\\u{0:x4}", character);
            }
            Console.WriteLine();
        }
    }
}
