namespace odev1;
// 2. Kullanıcıdan bir pozitif tam sayı isteyin.Bu sayı ile 1'den bu sayıya kadar olan sayıların küplerini hesaplayın. Her bir sayının küpünü ayrı satırlarda ekrana yazdırın. Örneğin, kullanıcı 3 girdiğinde, 1^3, 2^3 ve 3^3 sonuçlarını görmelidir. Not: `Pow` kullanmayın.
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("bir sayı giriniz");
        int sayi1 = int.Parse(Console.ReadLine());


        for (int i = 1; i <= sayi1; i++)
        {
            System.Console.WriteLine(i + ". sayının küpü" + (i * i * i));



        }


    }
}
