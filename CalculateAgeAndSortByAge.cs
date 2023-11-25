using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOOOO
{
    internal class Program
    {
        public class People: IComparable<People> {

            public string username;
            public string surname;
            public DateTime birthdate = new DateTime();
            public int age = 0;

            public People(string username, string surname, DateTime birthdate) {
                this.username = username;
                this.surname = surname;
                this.birthdate = birthdate;
                this.age = DateTime.Now.Year - this.birthdate.Year;
            }

            public override string ToString()
            {
                return "username: " + username + " surname: " + surname + " age: " + age;
            }



            public int CompareTo(People p) {
               if(p == null)
                {
                    return 1;
                }
                 
               else {
                    return this.birthdate.CompareTo(p.birthdate);
                }
                
            }

    }
        static void Main()
        {
            List<People> person = new List<People>
            {
                new People("fatima", "abdoua",new DateTime(2020,08,02)),
                new People("aicha","ali",new DateTime(2022,08,02)),
                new People("mariam", "sona",new DateTime(2001,08,02)),
                new People("zara", "ecru",new DateTime(2008,08,02)),
                new People("tationa", "sari",new DateTime(2005,08,02)),
                new People("aliana", "toru",new DateTime(2003,08,02)),
                new People("sara", "final",new DateTime(2002,08,02)),
                new People("yayoune", "asil",new DateTime(2005,08,02)),
                new People("irene", "teru",new DateTime(2009,08,02)),
                new People("siata", "arnil",new DateTime(2010,08,02)),

            };

            person.Sort();

            foreach (People pe in person)
            {
               // pe.age = DateTime.Now.Year - pe.birthdate.Year;
                Console.WriteLine(pe);
               
            }

            Console.ReadLine();

        }


    }
}




