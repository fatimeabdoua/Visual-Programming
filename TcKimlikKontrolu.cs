using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tckimlikkontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tc kimlik numarasini giriniz");
            string tc = Console.ReadLine();

            if (SetSartlariGecerliMi(tc))
            {
                Console.WriteLine("tc setsarlar uygun");

                string ilkbes = getsarlar(tc);
                Console.WriteLine("ilk bes (get satlar uygun):" + ilkbes);
            }

            else
            {
                Console.WriteLine("tc set sarlar uygun degil");
            }
            
            bool SetSartlarGecerliMi(string tc)
            {
                if(tc.Length != 11)
                {
                    return false;
                }

                foreach(char c in tc)
                {
                    if(!char.IsDigit(c))
                    {
                        return false;
                    }
                    return true;

                }


            }
            string getsartlar(string tc)
            {
                return tc.Substring(0,5);
            }
       
            }

 
        }

    }


