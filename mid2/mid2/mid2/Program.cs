using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mid2
{
    class Program
    {
        public class Point
        {
            int x0;
            int x1;
            int x2;
            int x3;
            int y0;
            int y1;
            int y2;
            int y3;

        }

        public class Polygon
        {
            List<Point> points;
            public Polygon() { }
            public Polygon(string name, string surname, int age)
            {
                /*this.name = name;
                this.surname = surname;
                this.age = age;
                subjects = new List<Subject>();
                subjects.Add(new Subject("Programming languages"));
                subjects.Add(new Subject("Programming tecnologies"));*/

            }
        }

       /* public override string ToString()
        {
            return 
        }

        public static void getPeriemeter()
        {
            //int a =  
        }*/

        public static void F1()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Айжан\Documents\polygon");

            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

            Console.WriteLine("Files:");
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Directories:");

            foreach (DirectoryInfo dInfo in directories)
            {
                Console.WriteLine(dInfo.Name);
            }
            Console.ReadKey();

        }

        public static void F2()
        {
            string s = Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(s);
            FileSystemInfo[] f = dir.GetFileSystemInfos();

            foreach (FileSystemInfo file in f)
            {
                    Console.WriteLine(file.Name);
            }

            

        }

        static void Main(string[] args)
        {
            //getPeriemeter();
            F1();
            F2();
        }
    }
}
