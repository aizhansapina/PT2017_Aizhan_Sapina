using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);

            int sum = 0;

            while (a > 0)
            {
                sum = sum + a % 10;
                a = a / 10;
            }

            Console.Write(sum);
            Console.ReadKey();
            
        }
    }
}

