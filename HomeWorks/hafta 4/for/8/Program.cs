namespace odev1;

// 8. Kullanıcıdan bir pozitif tam sayı alın.Bu sayıdan başlayarak geriye doğru sayarak 1’e kadar olan tüm sayıların karesini hesaplayın ve her sayının karesini ayrı satırlarda ekrana yazdırın.
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("bir pozitif tam sayı giriniz");
        int sayı = int.Parse(Console.ReadLine());

        for (int i = sayı; i > 1; i--)
        {
            System.Console.WriteLine($"{i}^2 : {Math.Pow(i, 2)}");
        }


    }
}
