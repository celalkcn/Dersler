namespace Soru03;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Harf Girin: ");
        // char letter = Convert.ToChar(Console.ReadLine().ToLower());

        // if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' ||
        //        letter == 'ı' || letter == 'ö' || letter == 'ü')
        // {
        //         System.Console.WriteLine($"Girilen Harf Sesli Harftir {letter}");
        // }
        // else
        // {
        //     System.Console.WriteLine($"Girilen Harf Sessiz Harftir {letter}");
        // }
        // System.Console.WriteLine("bir sayı giriniz");


        // int sayı = int.Parse(System.Console.ReadLine());

        // bool isPrime = true;
        // for (int i = 2; i < sayı; i++)
        // {
        //    if (sayı % 1 == 0 && sayı % sayı == 0)
        //    {
        //     sayı = sayı+1;
        //    }
        // }

        // System.Console.WriteLine("Lütfen Bir sayı giriniz: ");
        // int input = int.Parse(Console.ReadLine());
        // bool isPrime = true;

        // for (int i = 2; i <= input; i++)
        // {
        //     isPrime = true;

        //     for (int j = 2; j < i; j++)
        //     {
        //         if (i % j == 0)
        //         {
        //             isPrime = false;
        //             break;
        //         }
        //     }
        // }
        // if (isPrime)
        // {
        //     System.Console.WriteLine("ASAL");
        // }
        // else
        // {
        //     System.Console.WriteLine("asaldeğil");


        // int [] sayılar ={3,5,2,8,4,15,20,11,12,9};




        // for (int i = 1; i < sayılar.Length - 1; i++)
        // {
        //     if (sayılar[i] > sayılar[i - 1] && sayılar[i] > sayılar[i + 1])
        //     {
        //         Console.WriteLine($"{sayılar[i]} değeri sağındaki ve solundaki elemanından büyüktür.");
        //     }

        // int[] sayılar = new int[10];
        //     for (int i = 0; i < sayılar.Length; i++)
        //     {   
        //         System.Console.ReadLine();
        //     }
        // int[] dizi = new int[10];
        // int[] ciftDizi = new int[10];
        // int sayaç = 0;
        // System.Console.WriteLine("10 adet sayı giriniz = ");

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     while (!int.TryParse(Console.ReadLine(), out dizi[i]))
        //     {
        //         System.Console.WriteLine("geçerli sayı giriniz");
        //     }
        // }

        // System.Console.WriteLine("------------------------------------------------");


        // foreach (var sayı in dizi)
        // {
        //     System.Console.WriteLine(sayı);
        // }
        // /////////////////////
        // for (int i = 0; i < ciftDizi.Length; i++)
        // {
        //     if (dizi[i] % 2 == 0)
        //     {
        //         ciftDizi[sayaç] = dizi[i];
        //         sayaç++;

        //     }

        // }

        // Array.Sort(ciftDizi);
        // System.Console.WriteLine("Çiftve küçükten büyüğe sıralı dizilerim ");
        // foreach (var item in ciftDizi)
        // {
        //     System.Console.WriteLine(item);
        // 3. soru***************************************************************************************

        // int[] sayılar = new int[10];
        // int[] negatifSayılar = new int[10];
        // int[] pozitifSayılar = new int[10];
        // int sayaç = 0;
        // Random rnd = new Random();

        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     sayılar[i] = rnd.Next(-10, 10);
        //     Console.WriteLine(sayılar[i]);
        // }
        // System.Console.WriteLine("------------------------------------------------");
        // System.Console.WriteLine("-------------------------------------------------");



        // for (int i = 0; i < 10; i++)
        // {
        //     if (sayılar[i] >= 0)
        //     {
        //         pozitifSayılar[sayaç] = sayılar[i];
        //         sayaç++;


        //     }





        // }

        // System.Console.WriteLine("pozitif sayılar");
        // foreach (var poz in pozitifSayılar)
        // {
        //     System.Console.WriteLine(poz);
        // }
        // for (int i = 0; i < 10; i++)
        // {
        //     if (sayılar[i] < 0)
        //     {
        //         negatifSayılar[sayaç] = sayılar[i];
        //         sayaç++;    


        //     }



        // }
        // System.Console.WriteLine("negatif sayılar");
        // foreach (var neg in negatifSayılar)
        // {
        //     System.Console.WriteLine(neg);
        // }
        // *************************************************************


        Random rnd = new Random();
        int[] sayılar = new int[100];
        int[] sayılarSayacı = new int[21]; // 1 ile 20 arasında sayılar için

        // Diziyi rastgele sayılarla doldur
        for (int i = 0; i < sayılar.Length; i++)
        {
            sayılar[i] = rnd.Next(1, 21); // 1 ile 20 arasında rastgele sayılar üret
        }

        // Sayıları say
        for (int i = 0; i < sayılar.Length; i++)
        {
            int sayi = sayılar[i];
            sayılarSayacı[sayi]++;
        }

        // Tekrar eden elemanları yazdır (for döngüsü ile)
        Console.WriteLine("Tekrar eden elemanlar (for döngüsü ile):");
        for (int i = 1; i < sayılarSayacı.Length; i++)
        {
            if (sayılarSayacı[i] > 1) // Eğer eleman birden fazla kez varsa
            {
                Console.WriteLine($"Eleman {i}");
            }
        }

        Console.WriteLine();

        // Tekrar eden elemanları yazdır (foreach döngüsü ile)
        Console.WriteLine("Tekrar eden elemanlar (foreach döngüsü ile):");
        int idx = 1;
        foreach (var sayi in sayılarSayacı)
        {
            if (sayi > 1) // Eğer eleman birden fazla kez varsa
            {
                Console.WriteLine($"Eleman {idx}");
            }
            idx++;
        }
    }
}




