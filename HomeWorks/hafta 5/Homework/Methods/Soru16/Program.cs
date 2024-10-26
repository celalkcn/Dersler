namespace Soru16;
/*Verilen bir kelimenin palindrom olup olmadığını kontrol eden bir metot yazın.*/


class Program

{

    static string IsPalindrom( ){
        System.Console.Write("Bir kelime giriniz: ");
        string word = Console.ReadLine();

        char[] wordArray = word.ToCharArray();
        Array.Reverse(wordArray);

        string newWord = new string(wordArray);
        

        if (word.Equals(newWord))
        {
            return $"Kelime palindrom'dur.";
        }

        return $"Kelime palindrom değildir.";

    }
    
    
    
    
    
    static void Main(string[] args)
    {
        string result = IsPalindrom();
        System.Console.WriteLine(result);

    }
}
