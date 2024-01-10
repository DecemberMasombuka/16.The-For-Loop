using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.The_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The While Loop");
            int i = 0;  
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("The For Loop");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
