namespace Soru6;
/* Parametre olarak bir sayı alıp, tek mi çift mi olduğunu döndüren bir metot yazın.*/


class Program
{

    static void EvenOdd(){

        Console.Write("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        if (number %2==0)
        {
            System.Console.WriteLine(number+ " çift sayıdır");
        }
        else if(number %2==1)
        {
            System.Console.WriteLine(number + " tek sayıdır");
        }
        
    }


    static void Main(string[] args)
    {
      

        EvenOdd();
    }
}
