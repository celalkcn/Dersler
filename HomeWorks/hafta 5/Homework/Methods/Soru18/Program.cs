namespace Soru18;
/* Bir kişinin adını ve soyadını alıp, tam ismini döndüren bir metot yazın.*/

class Program
{
    static string FullName(){

        System.Console.WriteLine("İsminizi giriniz: ");
        string name = Console.ReadLine();

        System.Console.WriteLine("Soyisminizi giriniz: ");
        string surName = Console.ReadLine();

        string fullName= $"Tam isim: {name} {surName}";
        return fullName;



    }
    static void Main(string[] args)
    {
        string result = FullName();
        System.Console.WriteLine(result);
    }
}
