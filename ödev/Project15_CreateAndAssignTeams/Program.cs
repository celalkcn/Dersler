namespace Project15_CreateAndAssignTeams;

class Program
{

    static void Greet()
    {
        Console.WriteLine("Merhaba Drogba");


    }

    static string Greet2(string name, bool gender)
    {
        if (gender)
        {
            return $"Merhaba {name} hanım:";
        }
        return $"Merhaba {name} beyfendi:) <3<3 yaşasın maskülen tayfa";

    }

    static double SumSqrt(double number1, double number2)
    {
        double toplam = number1;
        double result = Math.Sqrt(toplam);
        return result;

    }

    static int Sum1()

    {
        int a = 40;
        int b = 50;
        int c = a + b;

        return c;

    }

    static void SampleNumberValue(ref int originalNumber)
    {
        originalNumber += 3;
        System.Console.WriteLine($"metot içinde yazdırma sayısı : {originalNumber}");
    }

    static int Sum2(int number1, int number2)

    {
        int result = number1 + number2;
        return result;
    }

    static void Main(string[] args) // void görüyorsan geriye değer göndermediğini anla
    {

        // Greet();

        // Sum1();
        // int x =Sum1();
        // int y = Sum2(50,70);
        // int z = Sum2(90,250);
        //SumSqrt(40,50);
        //System.Console.WriteLine(Greet2("burak", false));
        int originalNumber = 15;
        System.Console.WriteLine($"Metot çağırılmadan önceki orijinalNumber değeri  {originalNumber}:");
        SampleNumberValue(ref originalNumber);

        System.Console.WriteLine("metot cagırıldıktan sonra  " + originalNumber);

        #region örnek


        // *************//**1.** Kullanıcıdan alınan bir cümledeki kelime sayısını bulan bir program yazın. (`Split` metodunu araştırınız.)
        //  System.Console.Write("Bir cümle giriniz");
        //  string bosluk =Console.ReadLine();
        //  string[] kelimeler=bosluk.Split(' ');
        //  int boslukSayısı=kelimeler.Length;
        //  System.Console.WriteLine($"girdiğiniz cümledeği kelime sayısı :{boslukSayısı}");

        //**2.** Kullanıcıdan alınan bir metni tüm harfleri büyük olacak şekilde ve tüm harfleri küçük olacak şekilde alt alta tek bir Console.Write ile ekrana yazdıran bir program yazın.
        // System.Console.WriteLine("Bir Metin Giriniz");
        // string metin = Console.ReadLine();
        // System.Console.WriteLine(metin.ToLower() + "  " + metin.ToUpper());


        //************3.* *Kullanıcıdan alınan bir cümlede belirli bir kelimenin kaç kez geçtiğini bulan bir program yazın. (`Split` metodunu araştırınız.)
        // System.Console.WriteLine("Bir cümle girinizi");
        // string alınanveri =Console.ReadLine();

        // string[] sonuc=alınanveri.Split("çok");
        // int tekrarSayisi = sonuc.Length-1;
        // System.Console.WriteLine(tekrarSayisi);


        //**4.** Kullanıcıdan alınan bir cümlenin başındaki ve sonundaki boşlukları kaldıran bir program yazın. (`Trim` metotlarını araştırınız.)

        // System.Console.WriteLine("notunuzu giriniz");
        // int not = int.Parse(Console.ReadLine());

        // string sonuc = "";
        // if (not >= 54)


        // {
        //     if (not <= 100)
        //     {
        //         sonuc = "AA";

        //     }
        //     else if (not >= 89)
        //     {
        //         sonuc = "BA";

        //     }
        //     else if (not >= 84)
        //     {
        //         sonuc = "BB";
        //     }

        //     else if (not >= 79)
        //     {
        //         sonuc = "CB";
        //     }
        //     else if (not >= 69)
        //     {
        //         sonuc = "CC";
        //     }
        //     else if (not >= 59)
        //     {
        //         sonuc = "CD";

        //     }
        //     else
        //     {
        //         sonuc = "DD";
        //     }


        //     System.Console.WriteLine("geçerli" + "  " + sonuc);



        // }
        // else
        // {
        //     if (not >= 49)
        //     {
        //         sonuc = "fd";
        //     }
        //     else if (not >= 39 || not >= 1)
        //     {
        //         sonuc = "ff";
        //     }
        //     else if (not == 0)
        //     {
        //         sonuc = "devamsız";

        //     }

        //     else
        //     {
        //         System.Console.WriteLine("Geçerli Bir SAyı Giriniz");
        //     }
        #endregion

    }
}
