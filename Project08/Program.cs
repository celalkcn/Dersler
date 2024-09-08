namespace Project08;

class Program
{
    static void Main(string[] args)
    {
        // c#2 ta tarih ve saat tipindeki verilerle çalışmak için DateTime adında bir sınıf vardır.
         DateTime now = DateTime.Now;
         System.Console.WriteLine("su anki tarih saat "+now);
         System.Console.WriteLine($"3 ay sonraki tarih: {now.AddMonths(3)}");

        System.Console.WriteLine(now.ToString());


    }
}
