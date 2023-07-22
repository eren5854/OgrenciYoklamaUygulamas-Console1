using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace OgrenciYoklamaUygulamasiConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> liste = new();
            liste.Add("1- ZEKİYE BEKLER");
            liste.Add("2- HÜMEYRA CEMİYET");
            liste.Add("3- ERSEN BÜYÜKCENGİZ");
            liste.Add("4- BARKIN TEPE");
            liste.Add("5- KAMERCAN ESKİMEN");
            liste.Add("6- DERYA SEMA ÇELİK");
            liste.Add("7- SALİHA ÇAKMAN");
            liste.Add("8- ŞERMİN PALA");
            liste.Add("9- SALMAN AKANSEL");
            liste.Add("10- VELAT ÖZZEYBEK");
            List<string> liste2 = new();
            List<string> liste3 = new();
        menu:;
            Console.Clear();
            Console.WriteLine("Öğrenci Yoklama Programına Hoşgeldiniz.\nHangi İşlemi Yapmak İstersiniz?");
            Console.WriteLine("1- Öğrenci Listesi\n2- Öğrenci Kayıt\n3- Yoklama Al\n4- Gelenler Listesi\n5- Gelmeyenler Listesi\n6- Çıkış");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.Clear();
                Console.WriteLine("---Öğrenci Listesi---");
                foreach (var ogr in liste)
                {
                    Console.WriteLine($"{ogr}");
                }
                //for(int i = 0; i < liste.Count; i++)
                //{
                //    Console.WriteLine(liste.(i));
                //}
                Console.WriteLine("Menüye Dönmek için herhangi bir tuşa basınız");
                Console.ReadKey();
                goto menu;
            }
            else if (secim == "2")
            {
                Console.Clear();
                Console.WriteLine("---Öğrenci Kayıt Bölümü---");
                Console.WriteLine("Kayıt Edilecek Öğrencinin Bilgilerini Numara, Ad, Soyad Şeklinde Giriniz");
                Console.WriteLine("Kayıt Almayı Bitirmek İçin 'q' Tuşuna Basınız");
                //tekrar:;
                while (true)
                {
                    Console.Write("Öğrenci = ");
                    string ogrBilgileri = Console.ReadLine();
                    if (ogrBilgileri == "q")
                    {
                        break;
                    }
                    liste.Add(ogrBilgileri);
                    Console.WriteLine("Kayıt Başarılı");
                }
                Console.WriteLine("Menüye Dönmek için herhangi bir tuşa basınız");
                Console.ReadKey();
                goto menu;
            }
            else if (secim == "3")
            {
                Console.Clear();
                Console.WriteLine("---Yoklama Alma Bölümü---");
                for (int i = 0; i < liste.Count; i++)
                {
                tekrar:;
                    Console.WriteLine($"Öğrenci = {liste[i]}");
                    string durum = Console.ReadLine();
                    //liste2.Add(durum);
                    if (durum == "var")
                    {
                        liste2.Add(liste[i]);
                    }
                    else if (durum == "yok")
                    {
                        liste3.Add(liste[i]);
                    }
                    else
                    {
                        Console.WriteLine("Lütfen sadece var yada yok yazınız");
                        goto tekrar;
                    }
                }
                Console.WriteLine("Menüye Dönmek için herhangi bir tuşa basınız");
                Console.ReadKey();
                goto menu;
            }
            else if (secim == "4")
            {
                Console.Clear();
                Console.WriteLine("---Sınıfta Olan Öğrenciler---");
                for (int i = 0; i < liste2.Count; i++)
                {
                    Console.WriteLine(liste2[i]);
                }
                Console.WriteLine("Menüye Dönmek için herhangi bir tuşa basınız");
                Console.ReadKey();
                goto menu;
            }
            else if (secim == "5")
            {
                Console.Clear();
                Console.WriteLine("---Sınıfta Olmayan Öğrenciler---");
                for (int i = 0; i < liste3.Count; i++)
                {
                    Console.WriteLine(liste3[i]);
                }
                Console.WriteLine("Menüye Dönmek için herhangi bir tuşa basınız");
                Console.ReadKey();
                goto menu;
            }
            else if (secim == "6")
            {
                Console.Clear();
                Console.WriteLine("Çıkış Yapılıyor...");
            }
            else
            {
                Console.WriteLine("Lütfen Listedeki Seçeneklerden Birini Seçiniz!!");
                Console.ReadKey();
                goto menu;

            } 
        }
    }
}