namespace While_Soru3;

class Program
{
    static void Main(string[] args)
    {
        double num=0;
        double result=1;
        

        while (true)
        {
            Console.Write("Bir sayı giriniz: ");
            num = double.Parse(Console.ReadLine());

            if (num < 0)
            {
                break;
              
            }
            System.Console.WriteLine(Math.Pow(num, 2));

        }
}
}
