using System.Xml.XPath;

namespace odev1;
// 7. Kullanıcıdan bir pozitif tam sayı alın.Bu sayıya kadar olan çift sayıların toplamını hesaplayın ve sonucu ekrana yazdırın.Örneğin, kullanıcı 10 girerse, program 2+4+6+8+10 toplamını hesaplayıp sonucu göstermelidir.
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir Pozitfi sayı giriniz");
        int sayı = int.Parse(System.Console.ReadLine());

        int toplam = 0;
        for (int i = 1; i < sayı; i++)
        {
            if (i % 2 == 0)
            {
                toplam += i;
                System.Console.WriteLine($"Sayıların toplamı: {toplam}");
            }
        }

    }
}
