using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace _250710_Goldsmid_SixthApp_straight_up_smth_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int increment1 = 5;
            int increment2 = 10;

            int doubleincrement1 = 3;
            int doubleincrement2 = 6;

            while (true)
            {
                int number1 = rnd.Next(increment1, increment2);
                char operator1 = '+';
                int number2 = rnd.Next(increment1, increment2);
                Console.WriteLine($"what is {number1} {operator1} {number2}");
                Console.ReadLine();

                increment1 = increment1 + doubleincrement1;
                increment2 = increment2 + doubleincrement2;

                doubleincrement1 = doubleincrement1 + 5;
                doubleincrement2 = doubleincrement2 + 10;
            }

        }
    }
}