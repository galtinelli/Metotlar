using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Program
    {
        //Eleman saysını kullanıcının belirlediği, elemanlarının 1 ile 50 arasında rastgele oluşturulan bir dizinin her elemanınınkaçar tane olduğunu, 3 ve 5 ile tam bölünenlerin ayrı dizide tutulduğu ve eğer 3'e ve 5'e tam bölünen varsa bunların da ekrana yazdırıldığı program

        //500 elemanlı diyelim 1-50 arasında sayılardan aynı olanlar olabilir 1 sayısında 3 tane gibi yazacak.Bu elmanların içerisinde 3 ve 5 e bölünenleri diziye aktar ve yazdır.
        static void Main(string[] args)
        {
            Console.WriteLine("Eleman sayısını belirleyeniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

           int[] dizi = new int[sayi];

            Random rnd = new Random();
            int veri = rnd.Next(1, 51);
            for (int i = 0; i < sayi-1; i++)
            {
                
                dizi[i] = veri;

            }
            //int j = 0,es=0;
            //while (j <= sayi)
            //{
            //    if (dizi.Contains(veri))
            //        es++;
            //    j++;
            //}
            foreach (var item in dizi)
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }
    }
}
