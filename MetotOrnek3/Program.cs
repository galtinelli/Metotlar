using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOrnek3
{
    class Program
    {
        //1 den başlayan ve dışarıdan gönderilen değere kadar saydıran program
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            metodCgir(sayi);
            Console.ReadLine();
        }

        private static void metodCgir(int kacaKadar)
        {
            for (int i = 1; i <= kacaKadar; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
