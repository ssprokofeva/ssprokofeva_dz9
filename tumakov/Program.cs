using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Console.WriteLine("Введите что-нибудь для выхода");
            Console.ReadKey();
        }
        private static void Task1()
        {
            string testString = "Привет мир!";

            ICipher acipher = new ACipher();
            string encodedAcipher = acipher.Encode(testString);
            string decodedAcipher = acipher.Decode(encodedAcipher);
            Console.WriteLine($"Исходная строка: {testString}");
            Console.WriteLine($"Зашифровано ACipher: {encodedAcipher}");
            Console.WriteLine($"Расшифровано ACipher: {decodedAcipher}");

            ICipher bcipher = new BCipher();
            string encodedBcipher = bcipher.Encode(testString);
            string decodedBcipher = bcipher.Decode(encodedBcipher);
            Console.WriteLine("\nИсходная строка: " + testString);
            Console.WriteLine($"Зашифровано BCipher: {encodedBcipher}");
            Console.WriteLine($"Расшифровано BCipher: {decodedBcipher}");
        }

        private static void Task2()
        {

        }
    }
}
