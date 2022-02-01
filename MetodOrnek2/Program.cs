using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodOrnek2
{
    class Program
    {
        //1'den 100 'e kadar sayıları ekrana yazdıran mett ile çağıran program
        static void Main(string[] args)
        {
            sayiCagir();

            Console.ReadLine();
        }
        private static void sayiCagir()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
