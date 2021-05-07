using System;

namespace NlogImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding problem\n Enter a, b Values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            AddNumbers add = new AddNumbers();
            Console.WriteLine("Result is" + " " + add.Sum(a,b));
        }
    }
}
