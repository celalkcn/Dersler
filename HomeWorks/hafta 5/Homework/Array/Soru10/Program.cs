namespace Soru10;
//10 elemanlı bir dizi oluşturun ve bu dizinin elemanlarını bir başka diziye ters sırada kopyalayın. İlk dizideki sıralama değişmeyecek, sadece ikinci dizideki sıralama ters olacak.


class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {2, 4, 6, 7, 9, 36, 78, 5, 96, 41};
       System.Console.WriteLine("İlk sıralama: "); 
        for (int i = 0; i < numbers.Length; i++)
        {

            System.Console.Write(numbers[i]+" ");
        }

System.Console.WriteLine();

        Array.Sort(numbers);
        int[] newNumber = new int[numbers.Length];
        Array.Copy(numbers, newNumber, numbers.Length);

        System.Console.WriteLine("İkinci sıralama: ");

        for (int i = 0; i < newNumber.Length; i++)
        {
            System.Console.Write(newNumber[i]+" ");
        }
    }
}
