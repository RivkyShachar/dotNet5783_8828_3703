
using System;
namespace Stage0
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Welcome8828();
            Console.ReadKey();
        }
        static partial void Welcome3703();
        private static void Welcome8828()
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("{0}, welcome to my first console application", userName);
        }
    }
}