namespace Soru11;
//Klavyeden girilen bir cümlenin kelimelerini bir diziye aktarın. while döngüsü ile bu kelimeleri tersten ekrana yazdırın.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir cümle giriniz: ");
        string text = Console.ReadLine();

        char[] newText = text.ToCharArray();
        Array.Reverse(newText);


        while (true)
        {
            System.Console.WriteLine(newText);
            break;
        }



    }
}
