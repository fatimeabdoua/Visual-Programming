using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callAliens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            meetAlien();

            Console.WriteLine("-------------------------------");
            meetAlien();
            Console.ReadLine();
        }

        static void meetAlien()
        {
            Random getNum = new Random();

            string name = "X-" + getNum.Next(100, 9999);
            int age = getNum.Next(500, 1000);

            Console.WriteLine("hi I'm " + name);
            Console.WriteLine("I'm " + age + " years old");
            Console.WriteLine("oh and I am an alien");
        }
    }
}
