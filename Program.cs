using System;

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            var userEntry = Console.ReadLine();
            Console.WriteLine("Hello " + userEntry);
        }
    }
}
