using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mid3
{
    class Program
    {


        public static void Draw()
        {
            ConsoleColor color = ConsoleColor.White;
        }

    }

    static void Main(string[] args)
    {
        Thread t = new Thread(Draw);
        t.Start();

    }
}
