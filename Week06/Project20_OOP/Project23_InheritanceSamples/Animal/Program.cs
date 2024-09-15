using Project23_InheritanceSamples.CarManagamentSystem;
using Project23_InheritanceSamples.SchoolSystem;


namespace Project23_InheritanceSamples;

class Program
{
    static void Main(string[] args)
    {
        // Dog dog1 = new Dog("Ares", 3, 4, "3 yavrısı var");
        // dog1.MakeSound();
        // Kisi kisi1 = new Kisi("celal", "kocan", new DateTime(1999, 11, 02));
        // kisi1.BilgileriEkranaYaz();
        // MyOgrenci myOgrenci = new MyOgrenci("celal", "kocan", new DateTime(1999, 11, 02),1180606805);
        // myOgrenci.BilgileriEkranaYaz();

        // Ogretmen ogretmen = new Ogretmen("celal", "kocan", new DateTime(1999, 11, 02), "öğretmen", 500);
        // ogretmen.BilgileriEkranaYaz();

        Car car1 = new Car("Opel", "Astra", new DateTime(1999, 11, 02), 5);
        MotarCycle motarCycle = new MotarCycle("honda", "xysad", new DateTime(1999, 11, 02), "sus sogutmalı");
        car1.DisplayCar();
        car1.Start();

    }

}
