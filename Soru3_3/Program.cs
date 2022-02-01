using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adSoyadArray = new string[0];
            string[] sinifArray = new string[0];
            string[] tcnoArray = new string[0];
            string[] cinsiyetArray = new string[0];
            string[] dtArray = new string[0];
            string[] dyArray = new string[0];

        anamenu: Console.WriteLine("Öğrenci Bilgi Sistemine Hoşgeldiniz");

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: \n1- Öğrenci Kayıt \n2- Öğrencileri Listele \n3- Çıkış Yap");
            string secim = Console.ReadLine();
            Console.Clear();

            switch (secim)
            {
                case "1":
                    Console.Write("Öğrenci Adı Soyadı: ");
                    Array.Resize(ref adSoyadArray, adSoyadArray.Length + 1);
                    adSoyadArray[adSoyadArray.Length - 1] = Console.ReadLine();

                    Console.Write("Sınıf Bilgisi Giriniz: ");
                    Array.Resize(ref sinifArray, adSoyadArray.Length + 1);
                    sinifArray[sinifArray.Length - 1] = Console.ReadLine();

                    Console.Write("Öğrencinin TC kimlik numarasını giriniz: ");
                    Array.Resize(ref tcnoArray, tcnoArray.Length + 1);
                    tcnoArray[tcnoArray.Length - 1] = Console.ReadLine();

                    Console.Write("Öğrencinin Cinsiyet Bilgisini Giriniz (K/E) : ");
                    Array.Resize(ref cinsiyetArray, cinsiyetArray.Length + 1);
                    cinsiyetArray[cinsiyetArray.Length - 1] = Console.ReadLine();

                    Console.Write("Öğrencinin Doğum Tarihinin Giriniz: ");
                    Array.Resize(ref dtArray, dtArray.Length + 1);
                    dtArray[dtArray.Length - 1] = Console.ReadLine();

                    Console.Write("Öğrencinin Doğum Yerini Giriniz: ");
                    Array.Resize(ref dtArray, dtArray.Length + 1);
                    dtArray[dtArray.Length - 1] = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Kayıt İşlemi Başarıyla Gerçekleştirilmiştir." +
                        "\n Anamenüye dönmek için lüften M tuşuna basın ve Enter'layın");

                    string yanit = Console.ReadLine();

                    if (yanit == "M" || yanit == "m")
                        goto anamenu;
                    else
                        Environment.Exit(0);

                    break;

                case "2":
                    Console.WriteLine("Kayıtlı Öğrencilerin Bilgileri.......\n");
                    for (int i = 0; i < adSoyadArray.Length; i++)
                    {
                        Console.Write("Adi Soyadı: " + adSoyadArray[i]);
                        Console.Write("\nSınıfı: " + sinifArray[i]);
                        Console.Write("\nTC: " + tcnoArray[i]);
                        Console.Write("\nCinsiyet " + cinsiyetArray[i]);
                        Console.Write("\nDoğum Tarihi " + dtArray[i]);
                        Console.Write("\nDoğum Yeri: " + dyArray[i]);
                        Console.WriteLine("\n\n\n-------------------------\n\n\n");
                    }
                    break;
                case "3":
                    Environment.Exit(0); break;
                default:
                    goto anamenu;
            }


            Console.ReadLine();

        }
    }
}
