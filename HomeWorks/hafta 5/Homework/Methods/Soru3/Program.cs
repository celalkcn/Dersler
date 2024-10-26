namespace Soru3;
/* Parametre olarak bir kelime alıp, bu kelimeyi tersine çevirerek geri döndüren bir metot yazın.**/

class Program
{

    static string Reversed(){
        System.Console.Write("Bir kelime giriniz: ");
        string word = Console.ReadLine();
      
        char[] array = word.ToCharArray();
        Array.Reverse(array);

        return  new string(array);
    }



    static void Main(string[] args)
    {
       

        string newWord = Reversed();
        System.Console.WriteLine(newWord);

        

    }
}
