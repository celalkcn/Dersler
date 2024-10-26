using System.Runtime.InteropServices;

namespace Soru4;
/*Bir öğrencinin vize ve final notlarını alıp, ortalamayı hesaplayarak sonucu döndüren bir metot yazın. (Vize %40, Final %60, Geçme notu 50)*/


class Program

{
    static double ExamNote(){

        System.Console.WriteLine("Vize notunuzu giriniz: ");

        double visa = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Final notunuzu giriniz: ");

        double final = double.Parse(Console.ReadLine());


        double passNote = (visa * 0.4) + (final * 0.6);

        if (passNote >50)
        {
            System.Console.WriteLine("Geçtiniz");
        }
        else
        {
            System.Console.WriteLine("Kaldınız ");
        }
        return passNote;
     

    }



    static void Main(string[] args)
    {
        double result = ExamNote();

        System.Console.WriteLine($" Sonuç: {result}");
    }
}
