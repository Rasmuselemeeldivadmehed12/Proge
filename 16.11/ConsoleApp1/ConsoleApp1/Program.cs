using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            int numberParsed = Int16.Parse(number);

            if (numberParsed < 1)
            {
                Console.WriteLine("See literally ei eksisteeri");
            }
            else if (numberParsed > 99)
            {
                Console.WriteLine("See ei eksisteeri");
            }
            if (numberParsed == 7)
            {
                Console.WriteLine("Ma ei tea jalkast palju aga sen Ronaldo");
            }
            if (numberParsed == 30)
            {
                Console.WriteLine("Sen Messi. ära messi temaga");
            }
        }
    }
}
