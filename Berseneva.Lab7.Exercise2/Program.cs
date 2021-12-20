using System;

namespace Berseneva.Lab7.Exercise2
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
                string str = Console.ReadLine();

              
                string s = str.Replace('0', 'X').Replace('1', 'X').Replace('2', 'X').Replace('3', 'X').Replace('4', 'X').Replace('5', 'X').Replace('6', 'X').Replace('7', 'X').Replace('8', 'X').Replace('9', 'X');
                Console.WriteLine("Изменённая строка:" + s);
                   
                
            }


            static void Char()
            {
                Console.Write("Введите строку: ");
                string str = Console.ReadLine();

                string newstr = null;
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                    {
                        newstr += 'X';
                    }
                    else

                        newstr += str[i];
                }
                Console.WriteLine("Измененная строка: " + newstr);
                Console.ReadKey();
            }


        }

    }
}

