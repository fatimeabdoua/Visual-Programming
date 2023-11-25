using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortstudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("how many students are in the class:");
            //int studentcount = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter the name of the students:");

            //string[] students = new string[studentcount];

            //for(int i = 0; i<studentcount; i++)
            //{
            //   students[i] = Console.ReadLine();
            //}

            // Array.Sort(students);

            //Console.WriteLine("-------------------------");
            //Console.WriteLine("the sorted list:");

            //for(int i= 0; i<studentcount; i++)
            // {
            //    Console.WriteLine(students[i]);
            //}

            //Console.ReadLine();

            List<string> students = new List<string>();

            Console.Write("how many students are in the class:");

            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the names of the students:");

            for(int i = 0; i<count; i++)
            {
                students.Add(Console.ReadLine());
            }

            students.Sort();

            Console.WriteLine("the sorted list:");

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(students[i]);
            }


            Console.ReadLine();




        }
    }
}
