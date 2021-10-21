using System;

namespace TestingApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int x = 36;
            int y = 43;
            int z = 26;
            int xy = x * y;
            int xyz = x * y * z;
            //Console.WriteLine(xy);

            Console.WriteLine("If " + x + " and " + y + " were multiplied together, it would be " + xy);
            Console.WriteLine(" The product of x, y, and z is " + xyz);
            /*while (x == 36)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Red");
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Orange");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("yellow");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Green");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blue");
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Magenta");
                Console.BackgroundColor = ConsoleColor.Black;
                //Console.ReadLine();
            }*/
        }
    }
}