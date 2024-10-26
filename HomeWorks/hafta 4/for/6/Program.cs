namespace odev1;
// 6. Kullanıcıdan 10'dan büyük bir pozitif tam sayı girmesini isteyin. 1’den bu sayıya kadar olan tüm sayıların karelerini hesaplayın ve her sayının karesini ekrana yazdırın. Örneğin, kullanıcı 12 girdiğinde, 1^2, 2^2, …, 12^2 sonuçlarını ekranda görmelidir.

class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("10 dan büyük bir sayı giriniz");
        int sayı = int.Parse(Console.ReadLine());

        for (int i = 0; i <= sayı; i++)
        {
            System.Console.WriteLine($"{i}^2 : {Math.Pow(i, 2)}");
        }

    }
}
