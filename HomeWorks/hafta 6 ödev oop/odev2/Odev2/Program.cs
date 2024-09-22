namespace Odev2;

class Program
{

    // ## 2. Taşıt Yönetim Sistemi (Vehicle Management System)

    //     Bir `Vehicle` (Taşıt) sınıfı oluşturun.Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
    // - `Make` (marka): Taşıtın markası
    // - `Model` (model): Taşıtın modeli
    // - `Year` (yıl): Taşıtın üretim yılı

    // Bu temel sınıftan `Car` (Araba), `Bicycle` (Bisiklet) ve `Motorcycle` (Motosiklet) sınıflarını türetin.Her taşıt türüne özel bir özellik ekleyin(örneğin, `Car` için `NumberOfDoors` (Kapı Sayısı), `Motorcycle` için `HasSidecar` (Yan Sepet Var mı)).
    static void Main(string[] args)
    {
        Car car = new Car("şahin", "çakarkasa", 1992, 90);
        Motorcycle motorcycle = new Motorcycle("honda", "r25", 2013, "yok");
        Bicyle bicyle = new Bicyle("BMX", "yetişkin", 1999, "en kalitelisede bende var");


        car.BilgileriEkranaYaz();
        motorcycle.BilgileriEkranaYaz();
        bicyle.BilgileriEkranaYaz();


    }
}
