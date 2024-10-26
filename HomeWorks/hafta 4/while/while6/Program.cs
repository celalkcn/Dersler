using System.Net.WebSockets;

namespace While_Soru6;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Bir metin giriniz: ");
        string text = Console.ReadLine();

        char[] charArray = text.ToCharArray();
        
        Array.Reverse(charArray);

        string reveredText = new string(charArray);

        System.Console.WriteLine(reveredText); 





    }
}
