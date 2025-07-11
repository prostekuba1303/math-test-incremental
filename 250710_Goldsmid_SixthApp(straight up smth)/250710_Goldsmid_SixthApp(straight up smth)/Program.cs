using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace _250710_Goldsmid_SixthApp_straight_up_smth_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int increment1 = 10;//base number 1 and 2
            int increment2 = 5;
            char operator1 = '+';//used operator in problem

            int doubleincrement1 = 10;//amount of added increment to base number 1 amd 2
            int doubleincrement2 = 5;

            int tripleincrement1 = 10;//amount of added increment to double increment 1 and 2
            int tripleincrement2 = 5;

            for (int i = 1; i > -1; i++)
            {
                int number1 = rnd.Next(increment2, increment1);//makes the numbers 1 and 2 random
                int number2 = rnd.Next(increment2, increment1);
                Console.WriteLine($"{i}. Otázka");
                Console.WriteLine($"Kolik je {number1} {operator1} {number2}");
                string odpoved = Console.ReadLine();
                int odpovedInt;
                bool success = int.TryParse(odpoved, out odpovedInt);
                if (success)
                {
                    if (odpovedInt != number1 + number2)
                    {
                        Console.WriteLine("Špatně!");
                        Console.WriteLine("Správná odpověď:" + (number1 + number2));
                        ; break;
                    }
                }
                else
                {
                    Console.WriteLine("Odkdy se 2 cisla rovnaji pismenku?");
                    break;
                }
                
                

                increment1 = increment1 + doubleincrement1;//buffs the increment gain every loop (caps at some point bc of int limit)
                increment2 = increment2 + doubleincrement2;

                doubleincrement1 = doubleincrement1 + tripleincrement1;//buffs the double increment gain
                doubleincrement2 = doubleincrement2 + tripleincrement2;

                tripleincrement1 = tripleincrement1 + 10;//unexpectedly, buffs the triple increment gain
                tripleincrement2 = tripleincrement2 + 5;
            }
        }
    }
}