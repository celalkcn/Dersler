namespace Soru16;

class Program
{
    static void Main(string[] args)
    {
        
        
        //int lastCount= int.MaxValue;
       
        int count=0;
        int[] dizi = new int[30];

        do
        {
            System.Console.WriteLine("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi == 0)
            {
                break;

            }

            if (count < dizi.Length)
            {
                dizi[count] = sayi;
                count++;

            }

          


        } while (true);
      
        int toplam=0;
        System.Console.WriteLine();

        for (int i = 0; i < count; i++)
        {
         

            System.Console.WriteLine(dizi[i]+" ");
          toplam += dizi[i] ;
           
        }

          System.Console.WriteLine();

          double ort = (double)toplam / count;

          System.Console.WriteLine("Ortalama: "+ ort);



    }
}


