namespace Soru13;
/* Belirli bir metin içinde geçen kelimeleri sayan bir metot yazın.*/

class Program
{

    static int FindWordCount(){

        string text = "Macbook ile Yazılım Geliştirme Ortamının Hazırlanması";
        int spaceCount = 0;

        foreach (var space in text)
        {
            if (space == ' ')
            {
                spaceCount++;
            }
        }

        int wordCount = spaceCount + 1;
        return wordCount;
       
     

    }
    static void Main(string[] args)
    {
       int result = FindWordCount();
       System.Console.WriteLine($"Metindeki kelime sayısı: {result}");
    }
}
