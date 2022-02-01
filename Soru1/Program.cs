using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class Program
    {
        //-100 ile 100 arasında rastgele üretilen 50 birbirinden farklı sayıdan negatif olanları ve poziif olanları büyükten küçüğe, kaçar tane oldukları bilgisi ile ekrana yazdıran program kaç pozitif sayı kaç negatif sayı olduğunu yazacak


        static void Main(string[] args)
        {
            int ps = 0, ns = 0;
            int[] sayilar = new int[50];
            int[] pozitifsayilar = new int[0];
            int[] negatisayilar = new int[0];
            int sayi;
            Random rnd = new Random();
            int i = 0;
            while (i <= 49)
            {
                sayi = rnd.Next(-100, 101);
                if (sayilar.Contains(sayi))
                    continue;
                sayilar[i] = sayi;
                i++;

                if (Array.IndexOf(sayilar, sayi)==-1)//eğer sayı dizide yoksa -1 döndürür
                {
                    sayilar[i] = sayi;
                    Console.WriteLine(sayilar[i]);
                    i++;
                }
            }

            foreach (int sayi in sayilar)
            {
                if (sayi <= 0)
                {
                    Array.Resize(ref negatisayilar, negatisayilar.Length + 1);
                    negatisayilar[i] = sayi;
                    ps++;
                }
                else if (sayi > 0)
                {
                    Array.Resize(ref pozitifsayilar, pozitifsayilar.Length + 1);
                    pozitifsayilar[i] = sayi;
                    ns++;
                }
                Console.WriteLine(sayi);
            }

            Array.Sort(negatisayilar);
            Array.Reverse(negatisayilar);
            int t;
            for (int k = 0; k < 50; k++)
            {
                for (int l = 0; l < 50; l++)
                {
                    if (negatisayilar[l] <= negatisayilar[k])

                    {
                        t = negatisayilar[k];
                        negatisayilar[k] = negatisayilar[l];
                        negatisayilar[l] = t;
                    }
                }

            }
            for (int k = 0; k < 50; k++)
            {
                for (int l = 0; l < 50; l++)
                {
                    if (pozitifsayilar[l] <= pozitifsayilar[k])

                    {
                        t = pozitifsayilar[k];
                        pozitifsayilar[k] = pozitifsayilar[l];
                        pozitifsayilar[l] = t;

                    }
                }

            }

            Console.WriteLine("Pozitif sayı adedi:  " + ps);
            Console.WriteLine("Negatif sayı adedi:  " + ns);

            Console.ReadLine();
        }
    }
}
