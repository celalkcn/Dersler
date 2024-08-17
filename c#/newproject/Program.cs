using System;

class Program
{
    static void Main()
    {
        int n = 10; // Fibonacci dizisinin eleman sayısı
        Console.WriteLine("Fibonacci Dizisi:");

        int[] fib = new int[n];
        
        // İlk iki sayıyı belirle
        if (n > 0) fib[0] = 0;
        if (n > 1) fib[1] = 1;
        
        // Fibonacci dizisini oluştur
        for (int i = 2; i < n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        
        // Diziyi ekrana yazdır
        foreach (int num in fib)
        {
            Console.Write(num + " ");
        }
    }
}