using System.Net.WebSockets;
using System.Threading.Tasks.Dataflow;

namespace Soru11;
/*Bir kelime alıp, bu kelimenin içinde kaç tane sesli harf bulunduğunu döndüren bir metot yazın.*/

class Program 
{

    static int FindVowel(){
    
    System.Console.Write("Bir kelime giriniz: ");
    string word = Console.ReadLine();
    int vowelCount=0;

    for (int i = 0; i < word.Length; i++)
    {
        char vowel = word[i];
            switch (vowel)
            {
                case 'a':
                case 'e':
                case 'ı':
                case 'i':
                case 'o':
                case 'ö':
                case 'u':
                case 'ü':

                    vowelCount++;
                    break;

                default:
                break;
     
            }
         
        }
    
            return vowelCount;
         
    }


  

    static void Main(string[] args)
    {
        int result = FindVowel();
         System.Console.WriteLine($"Sesli harf sayısı: {result}");
    }



    /* static int FindVowel2()
    {

        System.Console.Write("Bir kelime giriniz: ");
        string word = Console.ReadLine();

        string dizi = "aeıioöuü";
        int sayac = 0;

        foreach (char item in word.ToLower())
        {

            if (dizi.Contains(item))
            {
                sayac++;
            }

        }
        return sayac;

    }

    static void Main(string[] args)
    {
       
        int result = FindVowel2();

        System.Console.WriteLine(result); */


    }

