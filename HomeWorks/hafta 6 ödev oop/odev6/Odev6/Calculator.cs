using System;

class Calculator
{
    public void Topla(double a, double b)
    {
        double result = a + b;
        Console.WriteLine($"Toplama Sonucu: {result}");
    }

    public void Cikarma(double a, double b)
    {
        double result = a - b;
        Console.WriteLine($"Çıkarma Sonucu: {result}");
    }

    public void Carpma(double a, double b)
    {
        double result = a * b;
        Console.WriteLine($"Çarpma Sonucu: {result}");
    }

    public void Bolme(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Hata: Bölme işlemi sıfır ile yapılamaz.");
            return;
        }
        double result = a / b;
        Console.WriteLine($"Bölme Sonucu: {result}");
    }
}
