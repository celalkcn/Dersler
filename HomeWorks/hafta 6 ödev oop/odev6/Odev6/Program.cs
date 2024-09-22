class Program
{
    static void Main()
    {
        Console.WriteLine("Hesap Makinesi");
        Console.WriteLine("1. Temel Hesap Makinesi");
        Console.WriteLine("2. Bilimsel Hesap Makinesi");
        Console.Write("Seçiminizi yapın (1 veya 2): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Calculator calc = new Calculator();

            Console.Write("Birinci sayıyı girin: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Yapmak istediğiniz işlemi girin (topla, çıkar, çarp, böl): ");
            string operation = Console.ReadLine().ToLower();

            switch (operation)
            {
                case "topla":
                    calc.Topla(a, b);
                    break;
                case "çıkar":
                    calc.Cikarma(a, b);
                    break;
                case "çarp":
                    calc.Carpma(a, b);
                    break;
                case "böl":
                    calc.Bolme(a, b);
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem türü.");
                    break;
            }
        }
        else if (choice == 2)
        {
            ScientificCalculator sciCalc = new ScientificCalculator();

            Console.Write("Bir açı değeri girin (derece cinsinden): ");
            double angle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz bilimsel işlemi girin (sin, cos, tan): ");
            string operation = Console.ReadLine().ToLower();

            switch (operation)
            {
                case "sin":
                    sciCalc.Sin(angle);
                    break;
                case "cos":
                    sciCalc.Cos(angle);
                    break;
                case "tan":
                    sciCalc.Tan(angle);
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem türü.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz seçim.");
        }
    }
}
