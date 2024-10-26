namespace odev1;


// 4. Kullanıcıdan bir pozitif tam sayı alın.Bu sayı kadar satırda, her satırda bir önceki satırdan bir fazla olacak şekilde yıldız (*) karakteri ile bir desen çizin. Örneğin, kullanıcı 5 girdiğinde, desen şu şekilde olmalıdır:
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("pozitif bir tam sayi giriniz");

        int sayi = int.Parse(Console.ReadLine());

        for (int i = 1; i <= sayi; i++)
        {
            for (int j = 0; j < i; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();

        }



    }



}
