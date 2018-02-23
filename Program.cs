/*
Marshall Frink
02/22/2018
Exercise 2
 */

using System;

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a number between 5 and 20");
            string numberEntry = Console.ReadLine();
            int convertedEntry = int.Parse(numberEntry);

            int x = 0;
            while ( x <= convertedEntry) {
                Console.WriteLine(x.ToString());
                x++;
            

            // for (int i = 0; i < convertedEntry; i++) {
            //     Console.WriteLine(i.ToString() + " is " + (i % 2 == 0 ? "Even" : "Odd"));
            //     }
            }
        }
    }
}
