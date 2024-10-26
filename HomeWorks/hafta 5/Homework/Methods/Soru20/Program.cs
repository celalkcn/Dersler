using System.Globalization;

namespace Soru20;
/* Bir dizideki string'leri birleştirip tek bir string döndüren bir metot yazın. */


class Program
{

    static string ConcatString(){

        string[] array =  {"Fundamental", "Of", "Academic", "Academic"};
        string newSentence ="";

        for (int i = 0; i < array.Length; i++)
        {
            newSentence += array[i]+ " ";
          
        }

        return newSentence;
    }

    static void Main(string[] args)
    {
       string result = ConcatString();
       System.Console.WriteLine($"Revize cümle : {result}");

    }
}
