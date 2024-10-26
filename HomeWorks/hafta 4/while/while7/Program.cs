namespace While_Soru7;

class Program
{
    static void Main(string[] args)
    {

        int number=0;
        int numberLast=0;
    

        while (true )
        {
            Console.Write("Bir sayı giriniz: ");
             number = int.Parse(Console.ReadLine());

            Console.Write("Üst limit sayı giriniz: ");

            numberLast = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine(number *= 2);

        if (number > numberLast)
        {
            break;
        }
        }
       System.Console.WriteLine(number);
    }
}
