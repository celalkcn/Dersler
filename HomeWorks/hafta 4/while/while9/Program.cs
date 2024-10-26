namespace While_Soru9;

class Program
{
    static void Main(string[] args)
    {

        bool isPrime=false;
        int number=0;
      
        //int i =number;
    
        while (true)
        {
            Console.Write("Bir sayı giriniz: ");
          number = int.Parse(Console.ReadLine());

            for (int j = 2; j < number; j++)
            {
                if (number %j ==0)
                {
                    isPrime =false;
                    System.Console.WriteLine($"{j} {(isPrime ? "asal sayıdır" : "asal değildir")}");
                }
              
            }
        }
       
    }
}
