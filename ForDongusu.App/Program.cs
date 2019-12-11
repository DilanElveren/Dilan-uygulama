using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //1--İstenilen sayı kadar girilen sayıların ortalamasını yazan program.
            //int i, sayi, deger;
            //double toplam = 0;
            //Console.WriteLine("kaç sayi gireceksiniz");
            //deger = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= deger; i++)
            //{
            //    Console.WriteLine(i + ".sayiyi giriniz.");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;

            //}
            //toplam = toplam / deger;

            //Console.WriteLine("ortalama : " + toplam);


            //2--Kullanıcından başlangıç, bitiş ve artış değerleri alınsın.
            //Girilen değerlere göre iki değer arasındaki sayıları artış miktarı kadar arttırarak ekrana yazdıran program.

            //    Console.Write("Başlangıç değerini giriniz: ");
            //int baslangic = int.Parse(Console.ReadLine());
            //Console.Write("Bitiş değerini giriniz: ");
            //int bitis = int.Parse(Console.ReadLine());
            //Console.Write("Artış miktarı giriniz: ");
            //int artis = int.Parse(Console.ReadLine());

            //Console.WriteLine(baslangic + " ve " + bitis + " arasındaki sayılar; ");
            //for (int sayac = baslangic; sayac <= bitis; sayac += artis)
            //{
            //    Console.WriteLine(sayac);
            //}

            //3--Kullanıcıdan istenilen beş adet sayının birler basamağının toplamını yazdıran program.

            //int sayi, toplam = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write(i+".Sayıyı Giriniz : ");
            //    sayi = Int32.Parse(Console.ReadLine());
            //    toplam += sayi % 10;
            //}
            //Console.WriteLine("Birler basamağı toplamı : " + toplam);

            //4-- Basit çarpım tablosu
            //for (int a = 1; a <= 10; a++)
            //{
            //    Console.Write(a + "\t");
            //}
            //Console.WriteLine();
            //for (int b = 1; b <= 10; b++)
            //{
            //    Console.Write(b * 2 + "\t");
            //}
            //Console.WriteLine();
            //for (int c = 1; c <= 10; c++)
            //{
            //    Console.Write(c * 3 + "\t");
            //}
            //Console.WriteLine();
            //for (int d = 1; d <= 10; d++)
            //{
            //    Console.Write(d * 4 + "\t");
            //}
            //Console.WriteLine();
            //for (int e = 1; e <= 10; e++)
            //{
            //    Console.Write(e * 5 + "\t");
            //}

            //----KISA YOL----
            //for (int a = 1; a <= 5; a++)
            //{
            //    for (int b = 1; b <= 10; b++)
            //    {
            //        Console.Write((b * a) + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //5--ÜSSÜNÜ HESAPLAMA
            //Console.WriteLine("Tabanı Giriniz");
            //int taban = int.Parse(Console.ReadLine());
            //Console.WriteLine("Üssünü Giriniz");
            //int us = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 0; i < us; i++)
            //{
            //    sonuc *= taban;
            //}

            //Console.WriteLine("Cıkan Sonuç "+ sonuc);

            //WHİLE DÖNGÜSÜ

            //1--Bir sayının tam bölenlerini ve tam bölenlerinin toplamını bulun.
            //int sayi;
            //Console.WriteLine("Bir sayı giriniz");
            //sayi = int.Parse(Console.ReadLine());
            //int bolen = 1;
            //int tamBolenlerToplami = 0;
            //while (bolen <= sayi)
            //{
            //    if (sayi % bolen == 0)
            //    {
            //        Console.WriteLine(sayi + " sayısı " + bolen + " sayısına tam bölünür.");
            //        tamBolenlerToplami = tamBolenlerToplami + bolen;
            //    }
            //    bolen++;
            //}
            //Console.WriteLine("\n" + sayi+ " sayısının tam bölenlerinin toplamı: " + tamBolenlerToplami);

            //2--KLAVYEDEN GİRİLEN ÇİFT SAYILARI TOPLAYAN,TEK SAYI GİRİLDİĞİNDE DÖNGÜYÜ SONLANDIRAN PROGRAM. 
            //int sayi = 0, toplam = 0; 
            //while (sayi % 2 == 0)  
            //{
            //    toplam = toplam + sayi; 
            //    Console.Write("Bir sayı giriniz : ");
            //    sayi = Convert.ToInt16(Console.ReadLine());  
            //}
            //Console.WriteLine("Girilen Çift Sayıların Toplamı = " + toplam); 
            //Console.ReadKey();


            //3-- Girilen 5 adet yaş içerisinden 18-25 arasını bulan program.
            //int sayac = 0, yas = 0, i = 0;
            //while (i < 5)
            //{
            //    Console.Write("{0}. yaşı giriniz:", i + 1);
            //    yas = Convert.ToInt16(Console.ReadLine());
            //    if (yas >= 18 && yas <= 25)
            //        sayac++;
            //    i++;
            //}

            //Console.WriteLine("18 ile 25 yaş arası {0} öğrenci vardır.", sayac);

            //4-- Faktöriyel hesaplama
            //int faktoriyel = 1;
            //int carpan = 1;
            //while (carpan <= 10)
            //{

            //    faktoriyel = faktoriyel * carpan;
            //    Console.WriteLine(carpan + " faktoriyel: " + faktoriyel);
            //    carpan++;

            //}

            //5--Basamak Hesaplama 
            //Console.WriteLine("Bir Sayı Giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int basamak = 0;

            //while (sayi > 0)
            //{
            //    basamak++;
            //    sayi = sayi / 10;
            //}

            //Console.WriteLine("Girdiğiniz sayı " + basamak.ToString() + " basamaklıdır.");


            // GİRİLEN SAYILARI TOPLAYAN,0 GİRİLİNCE PROGRAMI SONLANDRIAN WHİLE DÖNGÜSÜ
            //int sayi, toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Bir Sayı Giriniz:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi==0)
            //    {
            //        break;
            //    }
            //    toplam += sayi;
            //}
            //Console.WriteLine("Girilen Sayıların Toplamı: " + toplam);

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi, sayac = 0;
            //sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 2; i < sayi; i++)
            //{
            //    if (sayi%i==0)
            //    {
            //        sayac++;
            //        if (sayac==1)

            //        {
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine(sayac==0?"asal" : "asal değil");

            Console.ReadKey();
        }
    }
}