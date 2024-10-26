using System.Runtime.CompilerServices;

namespace homeWork01;

class Program
{
    static void Main(string[] args)
    {
        //    int number1 = 58;
        //    int number2 = 155;

        //    int result = number1 + number2;

        //    System.Console.WriteLine("Toplam: " + result);


        //1111111111***********************************************************************


        // int[] sayılar = { 3, 5, 2, 8, 4, 15, 20, 11, 12, 9 };
        // for (int i = 1; i < sayılar.Length - 1; i++)
        // {
        //     if (sayılar[i] > sayılar[i - 1] && sayılar[i] > sayılar[i + 1])
        //     {
        //         System.Console.WriteLine($"{sayılar[i]} değeri sağındaki ve solundakinden büyüktür");
        //     }
        //2222222***********************************************************************


        // int[] dizi = new int[10];
        // int[] çiftDizi = new int[10];
        // int sayaç = 0;
        // System.Console.WriteLine("10 tane sayı yazın: ");
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     while (!int.TryParse(Console.ReadLine(), out dizi[i])) ;

        // }
        // System.Console.WriteLine("-------------------------");
        // foreach (var sayı in dizi)
        // {
        //     System.Console.WriteLine(sayı);
        // }
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if (dizi[i] % 2 == 0)
        //     {
        //         çiftDizi[sayaç] = dizi[i];
        //         sayaç++;
        //     }
        // }
        // Array.Sort(çiftDizi);
        // System.Console.WriteLine("çift ve küçükten büyüğe sıralanmış hali");
        // foreach (var item in çiftDizi)
        // {
        //     System.Console.WriteLine(item);
        // }


        //33333333---------------------------------------------------

        //Random random = new Random();
        // int[] pozitif = new int[10];
        // int[] negatif = new int[10];
        // int[] sayılar = new int[10];
        // int sayaç = 0;
        // int sayaç1 = 1;
        // System.Console.WriteLine("10 tane sayı giriniz: ");
        // for (int i = 0; i < 10; i++)
        // {


        //     sayılar[i] = random.Next(-10, 10);

        // }
        // System.Console.WriteLine("Elimizde bulunan rastgele sayılar.");

        // foreach (var item in sayılar)
        // {
        //     System.Console.WriteLine($"{sayaç1}. elemanı= {item}");

        //     sayaç1++;
        // }
        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     if (sayılar[i] > 0)
        //     {
        //         pozitif[sayaç] = sayılar[i];
        //         sayaç++;
        //     }
        //     if (sayılar[i] < 0)
        //     {
        //         negatif[sayaç] = sayılar[i];
        //         sayaç++;
        //     }
        // }
        // System.Console.WriteLine($"Pozitif sayılarımız: ");
        // foreach (var item in pozitif)
        // {
        //     System.Console.WriteLine(item);

        // }
        // System.Console.WriteLine("Negatif sayılarımız: ");
        // foreach (var item2 in negatif)
        // {
        //     System.Console.WriteLine(item2);
        // }
        //444444-----------------------------------------

        // int[] dizi = new int[20];
        // int sayaç = 0;
        // Random rnd = new Random();
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = rnd.Next(1, 21);
        // }
        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine($"sayı {sayaç}. index ={item}");
        //     sayaç++;
        // }
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     for (int j = i + 1; j < dizi.Length; j++)
        //     {
        //         if (dizi[i] == dizi[j])
        //         {
        //             System.Console.WriteLine($"Sayı {dizi[j]} index {i} ve index{j} tekrar ediyor. ");
        //         }
        //     }
        // }

        //5555**************************************
        // System.Console.WriteLine("Bir sayı giriniz: ");
        // int input = int.Parse(Console.ReadLine());
        // int[] dizi = new int[100];
        // Random rnd = new Random();
        // int sayaç = 0;
        // int sayaç1 = 0;

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = rnd.Next(1, 15);
        // }
        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine($"{sayaç + 1}. index={item}");
        //     sayaç++;
        // }

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if (dizi[i] == input)
        //     {
        //         System.Console.WriteLine($"Girilen sayı({input}) {i + 1}. indexte var.");
        //         sayaç1++;
        //     }
        // }
        // System.Console.WriteLine($"girdiğiniz sayı ({input}) dizide {sayaç1} kere bulunuyor");


        //6666666----------------------------------


        // Random rnd = new Random();
        // int[] dizi = new int[100];
        // int sayaç = 1;
        // for (int i = 0; i < dizi.Length; i++)

        // {
        //     dizi[i] = rnd.Next(1, 101);
        // }
        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine($"dizideki {sayaç}. sayı:{item}");
        //     sayaç++;
        // }
        // Array.Sort(dizi);
        // System.Console.WriteLine($"Dizinin en küçük değeri: {dizi[0]}");
        // Array.Reverse(dizi);
        // System.Console.WriteLine($"Dizinin en büyük değeri {dizi[0]}");




        //7777777777-------------------
        // Random rnd = new Random();m
        // int[] dizi = new int[10];

        // int toplam = 0;
        // int sayaç = 1;
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = rnd.Next(1, 10);
        //     if (dizi[i] % 2 == 0)
        //     {
        //         toplam += dizi[i];
        //     }

        // }
        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine($"dizideki {sayaç}. sayı:{item}");
        //     sayaç++;
        // }

        // System.Console.WriteLine($"dizideki çift sayılarım toplamı:{toplam}");


        //9999999**********************************
        // int[] dizi = { -6, 5, 6, -9, -8, 2, 6, 7, 1, -50 };

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if (dizi[i] > 0)
        //     {
        //         dizi[i] = -dizi[i];
        //     }
        // }

        // Array.Sort(dizi);
        // Array.Reverse(dizi);
        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }
        // 1000000000000000000000000000


        // Random rnd = new Random();
        // int[] dizi = new int[5];
        // int[] dizi2 = new int[5];
        // int sayaç = 0;
        // for (int i = 0; i < 5; i++)
        // {
        //     dizi[i] = rnd.Next(1, 79);


        // }

        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }
        // System.Console.WriteLine("--------------------------");
        // Array.Reverse(dizi);
        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }

        // 999999999999999 Verilen bir dizinin yalnızca pozitif sayılarını ters çeviren bir algoritma yazın.Diziyi tararken, sadece pozitif sayıların yerini değiştirmelisiniz, diğer elemanlar aynı kalmalı.

        // int[] dizi = { 1, 5, 6, -5, -8, 7, -9, };
        // System.Console.WriteLine("\n dizinin elemanları");

        // foreach (var diziler in dizi)
        // {

        //     System.Console.Write(" " + diziler);
        // }
        // System.Console.WriteLine("\n \n-------------");
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if (dizi[i] > 0)
        //     {
        //         dizi[i] = -dizi[i];
        //     }

        // }
        // Array.Sort(dizi);

        // foreach (var sayılar in dizi)
        // {
        //     System.Console.WriteLine(sayılar);
        // }

        //  10101010         10 elemanlı bir dizi oluşturun ve bu dizinin elemanlarını bir başka diziye ters sırada kopyalayın. İlk dizideki sıralama değişmeyecek, sadece ikinci dizideki sıralama ters olacak.
        // int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        // int[] dizi2 = new int[10];
        // Array.Copy(dizi, dizi2, 10);
        // Array.Sort(dizi2);

        // System.Console.WriteLine("birinci dizi");


        // foreach (var item in dizi)
        // {
        //     System.Console.Write(" " + item);
        // }

        // System.Console.WriteLine("\n ikinci dizi");

        // foreach (var item in dizi2)
        // {
        //     System.Console.Write(" "+item);
        // }
        // #region 10. Soru
        // int[] dizi = { 1, 4, 7, 21, 33, 5, 667, 43, 66, 22 };
        // int j = 0;
        // int[] result = new int[dizi.Length];
        // for (int i = result.Length - 1; i >= 0; i--)
        // {
        //     result[j] = dizi[i];
        //     j++;
        // }
        // for (int i = 0; i < result.Length; i++)
        // {
        //     Console.Write(result[i] + ",");
        // }
        // Console.WriteLine("Dizinin orijinal hali:");
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     Console.Write(dizi[i] + ",");
        // }
        // Console.Read();
        // #endregion

        // 11 11 11 ----Klavyeden girilen bir cümlenin kelimelerini bir diziye aktarın. `while` döngüsü ile bu kelimeleri tersten ekrana yazdırın.

        // System.Console.WriteLine("Bir cümle giriniz");
        // string cumle = System.Console.ReadLine();


        // System.Console.WriteLine(cumle);
        // string[] kelimeler = cumle.Split(' ');

        // System.Console.WriteLine("\n tersten hali");

        // int i = kelimeler.Length - 1;
        // while (i >= 0)
        // {
        //     System.Console.Write("  " + kelimeler[i]);
        //     i--;
        // }

        // 12 12 12 12    12. 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en sık tekrar eden elemanı bulan ve kaç defa tekrarlandığını ekrana yazdıran bir program yazın. Bu işlemi bir `foreach` döngüsü ile gerçekleştirin.










    }
}
