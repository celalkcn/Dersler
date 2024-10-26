namespace While_Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı giriniz: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: ");
        int num2 = int.Parse(Console.ReadLine());

        int i= num;
        int result=1;
        
        while (num < num2-1)
        {
            
            result *=num;
            num++;


        }

System.Console.WriteLine(result);
    }
}
