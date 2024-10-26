namespace Soru8;

/*Klavyeden girilen bir sayıyı, 10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde aratın. Eğer sayı dizide yoksa, diziyi sıralayın ve sayıyı dizinin doğru(olması gereken sıra) yerine ekleyin. Ekledikten sonra yeni diziyi ekrana yazdırın.*/


class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 500);
            System.Console.Write(numbers[i] + " ");
        }

        System.Console.WriteLine();

        if (!numbers.Contains(sayi))
        {
            Array.Sort(numbers);

            foreach (var number in numbers)
            {
                System.Console.Write(number+" ");

            }
System.Console.WriteLine();
            

            int[] newNumbers = new int[numbers.Length + 1];
            Array.Copy(numbers, newNumbers, numbers.Length);
            newNumbers[newNumbers.Length-1] = sayi;

            Array.Sort(newNumbers);


            foreach (var item in newNumbers)
            {
                System.Console.Write(item + " ");
            }

        }

    }
}
