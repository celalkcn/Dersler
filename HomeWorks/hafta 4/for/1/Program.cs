using System.Xml;

namespace odev1;
// 1. Kullanıcıdan pozitif bir tam sayı girmesini isteyin. 1'den bu sayıya kadar olan tüm tam sayıların toplamını bulan ve sonucu ekrana yazdıran bir program yazın. Örneğin, kullanıcı 5 girdiğinde, program 1+2+3+4+5 toplamını hesaplayıp sonucu göstermelidir.
class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("bir pozitif tam sayı giriniz");

        int sayi = int.Parse(System.Console.ReadLine());
        int toplam = 0;

        for (int i = 0; i <= sayi; i++)
        {

            toplam += i;

        }

        System.Console.WriteLine("0 dan yazdıgınız sayıya kadar olan sayıların toplamı " + toplam + " dır");

    }
}
