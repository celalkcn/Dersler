namespace odev1;

class Program
{
    static void Main(string[] args)
    {
        // 10.Kullanıcıdan iki pozitif tam sayı alın.İlk sayıdan başlayarak ikinci sayıya kadar olan sayıların çarpımını hesaplayan bir program yazın.Sonucu ekrana yazdırın.Örneğin, 3 ve 6 girildiğinde, 3 * 4 * 5 * 6 çarpımı hesaplanmalı ve ekranda gösterilmelidir.

        System.Console.WriteLine(" 2 adet sayı giriniz 1. sayı 2. sayıdan küçük olsun ");

        System.Console.WriteLine("1. sayı");

        int sayı1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("2.sayı");
        int sayı2 = int.Parse(Console.ReadLine());
        int toplam = 1;


        for (int i = sayı1; i <= sayı2; i++)
        {
            toplam *= i;
        }

        System.Console.WriteLine(toplam);
    }
}
