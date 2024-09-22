using System;

class ScientificCalculator : Calculator
{
    public void Sin(double angleInDegrees)
    {
        double angleInRadians = DegreesToRadians(angleInDegrees);
        double result = Math.Sin(angleInRadians);
        Console.WriteLine($"Sin({angleInDegrees}°) Sonucu: {result}");
    }

    public void Cos(double angleInDegrees)
    {
        double angleInRadians = DegreesToRadians(angleInDegrees);
        double result = Math.Cos(angleInRadians);
        Console.WriteLine($"Cos({angleInDegrees}°) Sonucu: {result}");
    }

    public void Tan(double angleInDegrees)
    {
        double angleInRadians = DegreesToRadians(angleInDegrees);
        double result = Math.Tan(angleInRadians);
        Console.WriteLine($"Tan({angleInDegrees}°) Sonucu: {result}");
    }

    private double DegreesToRadians(double degrees)
    {
        return degrees * (Math.PI / 180.0);
    }
}
