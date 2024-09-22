namespace Odev1;

// ## 1. Hayvanat Bahçesi Uygulaması (Zoological Application)

// Bir `Animal` sınıfı oluşturun.Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
// - `Name` (isim): Hayvanın adı
// - `Age` (yaş): Hayvanın yaşı
// - `Species` (tür): Hayvanın türü

// Bu temel sınıftan `Lion` (Aslan), `Elephant` (Fil) ve `Giraffe` (Zürafa) gibi türemiş sınıflar oluşturun.Her bir türemiş sınıfın içinde `MakeSound` isimli bir metod bulunsun. Bu metod her hayvan için farklı bir ses çıkarmalıdır (örneğin, `Lion` için "Kükreme", `Elephant` için "Boru" sesi).

class Program
{
    static void Main(string[] args)
    {
        Lion lion = new Lion("sezar", 5, "aslan");
        Elephant elephant = new Elephant("minik", 19, "fil");
        Giraffe giraffe = new Giraffe("cüce", 6, "zürafa");

        lion.SesCıkar();
        elephant.SesCıkar();
        giraffe.SesCıkar();

    }
}
