using System.Xml.XPath;

namespace Soru8;
/*Santigrat cinsinden verilen sıcaklığı Fahrenheit'e çeviren bir metot yazın.  °C × 1.8 + 32*/

class Program
{

    static string Convert(){

        System.Console.WriteLine("Bir derece giriniz:");
        double santigrat = double.Parse(Console.ReadLine());
      
        double fahrenheit = ((double)santigrat *1.8) +32;
        
        return  $"{santigrat} C = {fahrenheit} F";


    }
    static void Main(string[] args)
    {
        string result= Convert();
        System.Console.WriteLine(result);
        
    }
}
//System.Console.WriteLine($"{santigrat} C = {result} F");