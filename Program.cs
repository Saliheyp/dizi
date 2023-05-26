using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dizi tanımlama
            string [] renkler = new string[5];
            
            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};
 
            int[] dizi ;
            dizi = new int[5];

            //Dizilere değer atama ve Erişim
            renkler[0] ="mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3]=10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerde Dizi kullanımı
            // klavyeden girilen n tane sayının ortalaması
            Console.WriteLine("lütfen dizinin uzunluğunu giriniz");
            int diziuzunlugu=int.Parse(Console.ReadLine());
            int[] sayilar = new int[diziuzunlugu];
            int toplam = 0;
            for (int i = 0; i < diziuzunlugu; i++)
            {
               Console.Write("lütfen {0}. sayısını giriniz :", i+1);
               sayilar[i] = int.Parse(Console.ReadLine());
            }
            foreach (var sayı in sayilar)
            {
                toplam+=sayı;
            }
            Console.WriteLine(toplam/diziuzunlugu);
        }
    }
}