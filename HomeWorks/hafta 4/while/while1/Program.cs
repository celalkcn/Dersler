namespace ödev;

class Program
{
    static void Main(string[] args)
    {
        //     1.Kullanıcıdan pozitif tam sayılar girmesini isteyin.Kullanıcı sıfır girdiğinde, program sona erer ve girilen tüm sayıların toplamını ekrana yazdırır. Her sayının toplanmasından sonra kullanıcıya yeni bir sayı girmesi istenir. Program sadece sıfır girildiğinde sona ermelidir.

        System.Console.WriteLine("pozitif tam sayırınız, girdiğinz her sayı bir önceki ile toplama yapmaya devam eder");

        System.Console.WriteLine("\n çıkmak için 0 a basınız");

        int toplam = 0;

        while (true)
        {
            System.Console.WriteLine("sayı giriniz");
            int sayı = int.Parse(Console.ReadLine());
            toplam += sayı;

            System.Console.WriteLine(" girilen sayıların toplamı " + toplam);
            if (sayı == 0)
            {
                break;
            }

        }


    }
}
