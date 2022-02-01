using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
           basla: Console.WriteLine("Lütfen yapmak istediğiniz işlmi seçiniz: \n1- Öğrenci Kayıt \n2- Öğrencileri Listele \n3- Çıkış Yap");

            Console.WriteLine("*********************************************************");
            byte secim = Convert.ToByte(Console.ReadLine());

            string[] ogrenci = new string[0];
            //ogrenci[]= { string ad, string sinif, double tc, char cinsiyet,DateTime dogumtrh,string dogumYeri };

            Console.WriteLine("Girilecek öğrenci var mı? E/H  ");
            string ogrenciGrs = Console.ReadLine();

            if (ogrenciGrs=="E"||ogrenciGrs=="e")
            {
                Array.Resize(ref ogrenci, ogrenci.Length + 6);

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Öğrenci Adı: ");
                        string ad = Console.ReadLine();
                        
                        Console.WriteLine("Sınıf Bilgisi Giriniz: ");
                        string sinif = Console.ReadLine();
                        
                        Console.WriteLine("Öğrencinin TC kimlik numarasını giriniz: ");
                        double tc = Convert.ToDouble(Console.ReadLine());
                        
                        Console.WriteLine("Öğrencinin Cinsiyet Bilgisini Giriniz (K/E) : ");
                        char cinsiyet = Convert.ToChar(Console.ReadLine());
                        
                        Console.WriteLine("Öğrencinin Doğum Tarihinin Giriniz: ");
                        DateTime dogumtrh = Convert.ToDateTime(Console.ReadLine());
                        
                        Console.WriteLine("Öğrencinin Doğum Yerini Giriniz: ");
                        string dogumYeri = Console.ReadLine();
                        
                        ogrenci[0] = ad;
                        ogrenci[1] = sinif;
                        ogrenci[3] = tc.ToString();
                        ogrenci[4] = cinsiyet.ToString();
                        ogrenci[5] = dogumtrh.ToString();
                        ogrenci[6] = dogumYeri;

                        Console.WriteLine("Kayıt İşlemi Başarıyla Gerçekleştirilmiştir.");

                        goto basla;

                    case 2:
                        foreach (var item in ogrenci)
                        {
                            Console.WriteLine(item);
                        }

                        break;

                    case 3:
                        Console.WriteLine("Programdan Çıkış Yapmak İstediğinize Emin Misiniz? E/H");
                        string cikisSonuc = Console.ReadLine();

                        if (cikisSonuc=="E"||cikisSonuc=="e")
                        {
                            Console.WriteLine("Çıkışınız yapılmaktadır.");
                            break;
                        }
                        else
                        {
                            goto basla;
                        }

                }
            }
            //else
            //{
            //    Console.WriteLine("Öğrenci Kayıt İşlemi İsteğiniz Üzerine Sonlandırılmıştır.");
            //}

            Console.ReadLine();
        }
    }
}
