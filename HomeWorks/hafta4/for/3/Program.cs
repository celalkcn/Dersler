namespace odev1;

// 3. Kullanıcıdan bir pozitif tam sayı alın.Bu sayının tüm tam bölenlerini bulan ve ekrana yazdıran bir program yazın.Bir tam bölen, bir sayıyı tam bölen herhangi bir tam sayıdır. Örneğin, 12 sayısı için tam bölenler 1, 2, 3, 4, 6 ve 12'dir.

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("bir sayı giriniz");

        int sayi = int.Parse(Console.ReadLine());


        for (int i = 1; i <= sayi; i++)
        {


            if (sayi % i == 0)
            {
                System.Console.WriteLine("sayının tam bölen sayılarının içerisinde " + i + " var");
            }
        }

    }
}
