namespace Inheritance;


class Bird
{
    public void Fly()
    {
        System.Console.WriteLine("Kuş ucuyor");

    }





}
class Penguin : Bird     // kalıtım kullandık  
{
    public void Swim()
    {


        System.Console.WriteLine("Penguen Yüzüyor.....");


    }


}


class Otomobil
{
    public string Marka { get; set; }

    public string Model { get; set; }

    public string Renk { get; set; }

    public int ModelYıl { get; set; }

}

class IctenYanmalıOtomobil : Otomobil
{
    public string YakitTipi { get; set; }

    public string MotorGücü { get; set; }

}

class ElektirkliOtomobil : Otomobil
{
    public string Menzil { get; set; }
    public bool KendiniSarjEtme { get; set; }


}







class Program
{
    static void Main(string[] args)
    {

        // Penguin penguin1 = new Penguin();
        // penguin1.Swim();
        // penguin1.Fly();
        ElektirkliOtomobil elektirkliOtomobil1 = new ElektirkliOtomobil();
        elektirkliOtomobil1.Marka = "sasadasd";




    }




}
