using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace labhafta14
{
    internal class Program
    {
        public class Ogrenci {
            private int ogrNo {get; set;}
            private string ad {get; set;}
            private string soyAd {get; set;}
            private int vize1 {get; set;}
            private int vize2 {get; set;}
            private int final {get; set;}
            private string schAd {get; set;}

            public double orta;

            public Ogrenci(int No, string name, string surname, int mid1, int mid2, int fin, string oksim)
            {
                ogrNo = No;
                ad = name;
                soyAd = surname;
                vize1 = mid1;
                vize2 = mid2;
                final = fin;
                schAd = oksim;
            }

            public void ogrenciBilgeGoster()
            {
                Console.WriteLine(" StudentNumber : " + ogrNo +  " Name: " + ad + " Surname: " + soyAd + " Mideterm1 :" + vize1 + " Midterm2 :" + vize2 + " Final : " + final + " OkulIsim:"  + schAd);

            }

            public void ogrenciOrtalama() {

                orta = (vize1 + vize2) * 0.4 + final * 0.6;
                Console.WriteLine("ortalama = " + orta);
            }

            public void okulgetir()
            {
                Console.WriteLine("okulAdi: " + schAd);
            }

            public override String ToString()
            {
                return ad + soyAd + vize1 + vize2 + final + schAd + orta;
            }
        }
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci(2010205503, "Fatime", "Abdoua", 40, 50, 60, "Karabuk university");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("secim gir");
                i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        ogr1.ogrenciBilgeGoster();
                        break;

                    case 2:
                        ogr1.ogrenciOrtalama();
                        break;

                    case 3:
                        ogr1.okulgetir();
                        break;

                    default:

                        Console.WriteLine("cikis yap");
                        break;

                }
            }
            Console.ReadLine();
            }
        }
    }
