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
                    break;
            }

            static void String()
            {

            }
        }
    }
}
