using System;

namespace p195_ex1
{
    class Program
    {

        public static void Swap(int a, int b, int c)
        {

            int temp = b;

            a = c;
            b = a;
            a = temp;

        }

        static void Main(string[] args)
        {

            int x = 3;
            int y = 4;
            int z = 5;

            Console.WriteLine($"x:{x}, y:{y}, z:{z}");

            Swap(x, y, z);

            Console.WriteLine($"x:{x}, y:{y}, z:{z}");
        }
    }
}
