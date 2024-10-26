namespace Soru5;
/*Bir string dizisindeki tüm isimleri büyük harfe çeviren bir metot yazın.*/


class Program
{
    static string UpperCase(){

        System.Console.WriteLine("Bir dizi giriniz: ");
        String word = Console.ReadLine();

        string newWord = word.ToUpper();
        return newWord;

    }

    static void Main(string[] args)
    {
        string result = UpperCase();
        System.Console.WriteLine(result);

    }
}
