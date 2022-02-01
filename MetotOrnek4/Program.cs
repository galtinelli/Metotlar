using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOrnek4
{
    class Program
    {
        //Kullanıcının girdiği 2 sayıyı toplayan ve bu toplamın küpünü geriye döndüren metotu çağıran program
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayı: ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("İkinci sayı: ");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            decimal kup=metot(sayi1,sayi2);
            Console.WriteLine(kup);

            Console.ReadLine();
        }
        private static decimal metot(decimal x,decimal y)
        {
            decimal toplam = x + y;
            decimal kup = (decimal)Math.Pow(Convert.ToDouble(toplam), 3);
            return kup;
        }
    }
}
