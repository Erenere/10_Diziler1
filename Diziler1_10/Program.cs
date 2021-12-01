using System;

namespace Diziler1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi", "Kopek", "Kus", "Maymun"};

            int[] dizi;
            dizi = new int[5];

            renkler[0] = "Mavi";
            dizi[3] = 10;
            
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            
            //Dongulerle dizi hesaplama
            //Klavyeden girilen n sayinin ortalamasini hesaplayan program
            Console.Write("Lutfen dizinin eleman sayisini giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lutfen {0}. sayiyi girin",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
                toplam += sayi;
            
            Console.WriteLine("Ortalama: " + toplam/diziUzunlugu);
        }
    }
}