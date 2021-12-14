using System;
using System.Linq;

namespace Berseneva.Lab7.Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип данных 1: string; 2: char");
            var choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Console.WriteLine("Вами был выбран 1 тип данных");
                    String();
                    break;
                case "2":
                    Console.WriteLine("Вами был выбран 2 тип данных");
                    Char();
                    break;    
            }

            static void String()
            {
                Console.Write("Введите строку: ");

                string choice = Console.ReadLine();

                string big = choice.Split(new Char[] { ' ', ',', '.', ':', '!', '?' }).OrderByDescending(x => x.Length).FirstOrDefault();

                Console.WriteLine("Самое длинное слово в строке:" + big);
                Console.WriteLine("Изменённая слово:" + Reverse(big));

                static string Reverse(string choice)
                {
                    char[] big = choice.ToCharArray();
                    string reverse = string.Empty;
                    for (int i = big.Length - 1; i > -1; i--)
                    {
                        reverse += big[i];
                    }
                    return reverse;
                }

            }
            Console.WriteLine();
            Console.ReadKey();

            static void Char()
            {
                Console.Write("Введите строку: ");
                string str = Console.ReadLine();
                string[] arr = str.Split(' ');

                string maxW = string.Empty;

                foreach (string s in arr)
                    if (maxW.Length < s.Length)
                        maxW = s;

                Console.WriteLine("Самое длинное слово: {0}", maxW);
                Console.WriteLine("Изменённая слово:" + Reverse(maxW));



                static string Reverse(string choice)
                {
                    char[] maxW = choice.ToCharArray();
                    string reverse = string.Empty;
                    for (int i = maxW.Length - 1; i > -1; i--)
                    {
                        reverse += maxW[i];
                    }
                    return reverse;
                }
            }
        }
    }
}
