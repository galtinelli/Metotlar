using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOrnek5
{
    class Program
    {
        //Kullanıcıdan öğrenilen sayının tek mi çift mi olduğunu söyleyen metod
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.Write(tekMi(sayi)) ;

            string cevap2 = "";
            TekMiCiftMi(sayi, ref cevap2);
            Console.WriteLine(cevap2);
            TekMiCiftMi(sayi, out cevap);
            TekMiCiftMi();
            if (TekMi(sayi))
            {

                Console.WriteLine("Sayı Tektir.");
            }
            else
            {
                Console.WriteLine("Sayı Çifttir.");
            }
           
            Console.ReadLine();
        }

        private static void TekMiCiftMi(int sayi, ref object cevap2)
        {
            throw new NotImplementedException();
        }

        private static bool TekMi(int sayi)
        {
            if (x % 2 == 0)
            {
                return "Bu sayı çifttir";
            }
            else
            {
                return "Bu sayı tektir";
            }
        }

        private static void TekMiCiftMi(int sayi)
        {
            throw new NotImplementedException();
        }

        private static string tekMi(int x)
        {
            if (x%2==0)
            {
                return "Bu sayı çifttir";
            }
            else
            {
                return "Bu sayı tektir";
            }

        }
    }
}
