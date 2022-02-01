using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOrnegi1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    ToplamYap1();
            //    int toplam = ToplamYap2();

            //    Console.WriteLine("Toplam: "+toplam);
            //    Console.WriteLine("Toplam: "+ToplamYap2());

            //Kullanıcıdan alınan 3 sayının toplamını hesaplayıp geriye sonucunu döndüren metod

            //Console.WriteLine("Lütfen 1. sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine()); 

            //Console.WriteLine("Lütfen 2. sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine()); 

            //Console.WriteLine("Lütfen 3. sayıyı giriniz");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());


            //ToplamYap3(sayi1,sayi2,sayi3);
            //ToplamYap3(33, 45, 67);
            //ToplamYap3(-100, 425, 267);

            //string cevap = ToplamYap4(7.5F, 6.5F);
            //Console.WriteLine(cevap);
            ////YADA
            //Console.WriteLine(ToplamYap4(7.5F, 6.5F));

            //string[] metinler = new string[5];
            //Console.WriteLine(metinler.Length);

            //Array.Resize(ref metinler, 15);//Metinler dizisinin boyutu 15 olarak değiştirilir.
            //Console.WriteLine(metinler.Length);

            //int a = 10, b = 20;
            //Console.WriteLine("Metodu çağırmadan önceki değerler: a={0} b={1}",a,b);//a=10,b=20

            //DegerleriDegistir(ref a, ref b);
            //Console.WriteLine("Metodu çağırdıktan sonraki değerler: a={0} b={1}", a, b);//a=20 b=10

            //RefsizDegerleriDegistir(a, b);
            //Console.WriteLine("Refsiz Metodu çağırdıktan sonraki değerler: a={0} b={1}", a, b);//a=20 b=10

            //int sonuc, kalan;

            //BolmeIslemiYap(17, 5,out sonuc,out kalan);

            //Console.WriteLine("17 / 5 işleminin sonucu: {0} ve kalan:{1}",sonuc,kalan);

            //int bolum=BolmeYap(23, 4, out int kalanSayi);
            //Console.WriteLine("23 / 4 işleminin sonucu: {0} ve kalan:{1}", bolum, kalanSayi);

            double toplam = FiyatlariTopla(9, 10, 11.90);
            Console.WriteLine("Fiyatların Toplamı: " + toplam);


            Console.ReadLine();
        }

        private static double FiyatlariTopla(int sayi1,int sayi2,params double[] fiyatlar)
        {
            double toplam = 0;
            foreach (double item in fiyatlar) //sadece double olarak fiyatlar dizisinin içerisindeki değerleri toplar
            {
                toplam += item;
            }

            //toplam += sayi1 + sayi2;

            return toplam;
        }

        private static int BolmeYap(int v1, int v2, out int kalanSayi) //Sadece bir değer dönebilir
        {
            kalanSayi = v1 % v2;
            return v1 / v2;
        }

        private static void BolmeIslemiYap(int bolunen, int bolen, out int bolum, out int kalan)// void geriye değer döndürmemesine rağmen out ile değer döndürülebilir
        {
            bolum = bolunen / bolen;
            kalan = bolunen % bolen;
        }

        private static void DegerleriDegistir(ref int x, ref int y)
        {
            int tasiyici = x;
            x = y;
            y = tasiyici;
        }
        private static void RefsizDegerleriDegistir(int x, ref int y)
        {
            int tasiyici = x;
            x = y;
            y = tasiyici;
        }

        private static string ToplamYap4(float v1, float v2)
        {
            float toplam = v1 + v2;
            return "Toplam " + toplam;
        }

        private static void ToplamYap3(int a, int b, int c)
        {
            int toplam = a + b + c;
            Console.WriteLine("Girilen sayıların toplamı: " + toplam);
        }

        private static int ToplamYap2()
        {
            int toplam = 3 + 8;
            return toplam;
            // Console.WriteLine("DEMO"); return scpedan çıkarttığı için bu satıra uğramaz.
        }

        private static void ToplamYap1()
        {
            int toplam = 4 + 5;
            Console.WriteLine("Toplam= " + toplam);
        }

    }
}
