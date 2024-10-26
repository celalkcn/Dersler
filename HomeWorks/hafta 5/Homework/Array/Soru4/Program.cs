namespace Soru4;
//100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde tekrar eden elemanları bulan bir program yazın. Diziyi tararken, elemanların hangi pozisyonlarda(kaçıncı indexte) tekrarlandığını ekrana yazdırın. Bu işlemi hem for hem de foreach döngüleri ile gerçekleştirin.
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[20];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(-200, 100);
           

            for (int j = i-1; j < numbers.Length; j++)
            {

                if (numbers[i] == numbers[j])
                {
                    Console.WriteLine($"Sayı {numbers[i]} index {i} ve index {j} tekrar ediyor.");
                }
              
            }
            
        }

      


       




        }

            }

