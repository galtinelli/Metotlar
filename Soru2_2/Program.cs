using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Eleman saysını kullanıcının belirlediği, elemanlarının 1 ile 50 arasında rastgele oluşturulan bir dizinin her elemanının kaçar tane olduğunu, 3 ve 5 ile tam bölünenlerin ayrı dizide tutulduğu ve eğer 3'e ve 5'e tam bölünen varsa bunların da ekrana yazdırıldığı program

            //500 elemanlı diyelim 1-50 arasında sayılardan aynı olanlar olabilir 1 sayısında 3 tane gibi yazacak.Bu elmanların içerisinde 3 ve 5 e bölünenleri diziye aktar ve yazdır.
            Console.WriteLine("Kaç tane sayı üzerinde çalışalım?");

            int elemanSayisi = Convert.ToInt32(Console.ReadLine());

            byte[] sayilar = new byte[elemanSayisi];
            byte[] tamBolunenler = new byte[0]; //henüz sayısı bilinmiyor

            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = Convert.ToByte(rnd.Next(1, 51));
            }

            foreach (byte item in sayilar)
            {
                int sayac = 0;

                foreach (byte sayi in sayilar)
                {
                    if (item == sayi)
                        sayac++;
                }
                Console.WriteLine("Dizide {0} sayısından {1} adet vardır...", item, sayac);

                //TODO: Sayılardan kaçar adet olduğunu tekrar tekrar yazdırılmamalı Contains yada IndexOf kullanılabilir
            }

            foreach (byte item in sayilar)
            {
                if (item % 3 == 0 && item % 5 == 0)
                {
                    Array.Resize(ref tamBolunenler, tamBolunenler.Length + 1);
                    tamBolunenler[tamBolunenler.Length - 1] = item;
                }
            }

            if (tamBolunenler.Length>0)
            {
                Console.WriteLine("3'e ve 5'e tam bölünenler aşağıda listelenmiştir.");
                foreach (byte bolunebilenSayi in tamBolunenler)
                {
                    Console.WriteLine(bolunebilenSayi+" ");
                }
            }
            else
            {
                Console.WriteLine("Bu dizide 3'e ve 'e bölünebilen herhangi bir sayı yoktur.");
            }

            Console.ReadLine();
        }

    }
}
