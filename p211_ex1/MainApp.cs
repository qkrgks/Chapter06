using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p211_ex1
{
    class MainApp
    {

        static void PrintProfilr(string name, string phone = "")
        {

            Console.WriteLine($"Name:(name), Phone:(phone)");
        
        }


        static void Main(string[] args)
        {
            PrintProfilr("중근");
            PrintProfilr("관순", "010-123-1234");
            PrintProfilr(name: "봉길");
            PrintProfilr("동주", phone: "010-789-7890");

        }
    }
}
