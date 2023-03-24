using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p207_ex1
{
    class MainApp
    {

        static int Sum(params int[] args)
        {

            Console.WriteLine("Suming....");
            int sum = 0;

            for (int i = 0; i < args.Length; i++)

            {
                if (i > 0)
                        Console.WriteLine(",");

                Console.WriteLine(args[i]);

                sum += args[i];
            }

            Console.WriteLine();

            return sum;

        }

        static void Main(string[] args)
        {



        }
    }
}
