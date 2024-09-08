using System.Globalization;
using System.Reflection.Emit;
using System.Security;

namespace Question14_Arrays;

class Program
{
    static void Main(string[] args)
    {
        // int[] numbers;
        // numbers = new int[5];

        // numbers[0] = 45;
        // numbers[1] = 25;
        // numbers[2] = 15;
        // numbers[3] = 35;
        // numbers[4] = 105;

        // for (int i= 0 ; i<5; i++)
        //  {
        //     System.Console.WriteLine($"Dizinin{i+1}.elemanı: {numbers[i]}");

        //  }

        // int[] numbers = {312,3123,312312,31121};
        //     for (int i= 0 ; i<4; i++)
        //      {
        //         System.Console.WriteLine($"Dizinin{i+1}.elemanı: {numbers[i]}");

        //      }

        //  string [] studentNames= {
        //     "ali",
        //     "mehmet",
        //     "ayşe",
        //     "faruk",
        //     "kerem"
        //  };

        //  for (int i = 0; i < studentNames.Length; i++)
        //  {
        //     studentNames[i]+= " Canoğlu";

        //  }
        //  System.Console.WriteLine();
        //     System.Console.WriteLine("Değişmiş Hali: ");
        // for (int i = 0; i < studentNames.Length; i++)
        // {
        //     System.Console.WriteLine(studentNames[i]);;

        // }
        // string[] studentNames = {
        //     "ali",
        //     "mehmet",
        //     "ayşe",
        //     "faruk",
        //     "kerem"
        //  };

        //  foreach (string student in studentNames)
        //  {
        //     System.Console.WriteLine(student + " Canoğlu");
        //      } //performans düşüklüğü yapar 

        //      int[] price={40,50,60,70,80};

        //      // prices dizisinin içindeki fiyatlara %10 zam yap

        //      foreach (int p in price)
        //      {
        //         System.Console.WriteLine(p);
        //      }
        //      System.Console.WriteLine("zamsız ürün fiyatı: ");
        //      System.Console.WriteLine("-------------------");


        //      for (int i = 0; i < price.Length; i++)
        //      {
        //        price[i]=(int)(price[i]*1.1);

        //      }
        // foreach (int p in price)
        // {
        //     System.Console.WriteLine(p);
        // }
        // System.Console.WriteLine("zamlı ürün fiyatı: ");
        // System.Console.WriteLine("-------------------");

        // int a = 500;
        // int b = 50;
        // int c = 450;

        // int max = int.MinValue;
        // if (a > max)
        // {
        //     max = a;
        // }

        // if (b > max)
        // {
        //     max = b;
        // }
        // if (c>max)
        // {
        //     max=c;
        // }
        // System.Console.Write(max);

        // 20 ELEMANLI İNT DİZİSİNE 1-100 arasında RASTGELE DEĞERLER ATAYALIM BU DİZİDEKİ EN BÜYÜK VE EN KÜÇÜK DEĞERLERİ YAZDIRALIM.

        //dizimizi oluşturup içine rastgele değerler atıyoruz.

        // Random rnd = new Random();
        // int[] numbers = new int[20];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 101);
        //     System.Console.WriteLine(numbers[i]);

        // }
        // // en büyük ve en küçük değeri buluyoruz.
        // int max = int.MinValue;
        // int min = int.MaxValue;

        // foreach (int number in numbers)
        // {
        //     if (number > max) max = number;
        //     if (number < min) min = number;
        // }
        // // en büyük ve en küçük değerleri yazıyoruz.
        // System.Console.WriteLine($"en küçük: {min}  En büyük: {max}" );
        // Random rnd = new Random();
        // int[] numbers = new int[20];


        // Random rnd = new Random();
        // int[] numbers = new int[20];
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 101);


        // }
        // Array.Sort(numbers);
        // System.Console.Write("Dizinin sıralanmış hali:" );
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     System.Console.Write("  " + numbers[i]);


        // }


        // Array.Reverse(numbers);
        // System.Console.WriteLine("\n Dizinin  büyükten küçüğe sıralanmış hali: ");
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     System.Console.Write("  " + numbers[i]);

        // }



        // Random rnd = new Random();
        // int[] numbers = new int[20];
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 10);
        //     System.Console.WriteLine($"Index: {i} - numbers {numbers[i]}");

        // }
        // numbers[5] = 99;
        // System.Console.WriteLine(Array.IndexOf(numbers, 5));

        // string firstName = "Alex-i de ";
        // System.Console.WriteLine(firstName[4]);


        // string text = "macbook ile Yazılım gelistirme ortamının hazırlanması";
        // string[] result = text.Split("a");
        // System.Console.WriteLine(result[0]);

        // string text = "çok hava çok  güzel çok çok çok aaa aaa aaa çok ";
        // string[] result = text.Split("çok");
        // System.Console.WriteLine(result[0]);

        // string[] names = { "Ayşen", "Umay", "Ceyda", "Begüm" };// bunlara calıs
        // string[] newNames = new string[names.Length];
        // Array.Copy(names, newNames, names.Length);
        // newNames[0] = "heda";

        // foreach (var name in newNames)

        // {
        //     System.Console.WriteLine(name);
        // }

        // dizide var yok kontrolü
        // int[] numbers={3,6,7,12};
        // bool exists=Array.Exists(numbers,n => n==6); // listenin içine n => bunula girdik sonra istediğimiz aralıkta kosul aranır
        // System.Console.WriteLine(exists? "var" : "yok");
        // // Dizide Belirtilen Koşula Uygun ilk Elemanı Getirmek 
        // int [] numbers = {3,6,7,12};
        // int result = Array.Find(numbers, n => n == 6);
        // System.Console.WriteLine(result);

        // Dizide Belirtilen Koşula Uygun ilk Elemanı Getirmek 
        // int[] numbers = { 3, 6, 7, 12, };
        // int[] result = Array.FindAll(numbers, x => x == 6);
        // foreach (var n in result)
        // {
        //    System.Console.WriteLine(n); 
        // }

        // int [] numbers ={3,6,9};
        // System.Console.WriteLine(numbers.Length);
        // Array.Resize(ref numbers,4);
        // numbers[3]=55;
        // System.Console.WriteLine(numbers.Length);

        // Dizinin Belirli Bir Bölümünü Temizlemek

        // int[] numbers = { 4, 5, 6, 7, 8, 9, 12, 2, 4, 5, 12 };
        // System.Console.WriteLine("Dizinin Örjinal Hali");
        // foreach (var number in numbers)

        // {
        //     System.Console.WriteLine(number);

        // }
       
     
        


    }
}
