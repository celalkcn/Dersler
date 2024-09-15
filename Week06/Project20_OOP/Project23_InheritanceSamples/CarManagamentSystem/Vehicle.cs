using System;

namespace Project23_InheritanceSamples.CarManagamentSystem;
// car managament  1 Vehicle adında bir class yaratın 
// Brand, Model , year propeteryleri olsun  
// start ve stop metodu olsun araba çalıştı araba durdu
// bir vehicle yaratılırken Brand, Model ve year Bilgileri verilmek zorunda olsun

// 22222 Car adlı bir class olsuturun 
// her car bir vehicle dir
// ek olarak numberOfDoors adlı bir özelliği olsun ve başta verilmek zorunda olsun 
// OpenTrunk adlı bir metodu olsun 

//3333 MotorCycle adlı bir class olusturun 
// her MotorCycle bir vehicledir
// ek olarak CoolingSystem adlı bir propertsi olsun ve yaratılırken verilmek zorunda olsujn 

public abstract class Vehicle
{


    public Vehicle (string brand,string model,DateTime yılı)
    {
        Brand=brand;
        Model=model;
        Yılı=yılı;
    }
    public string Brand { get; set; }
    public string Model { get; set; }

    public DateTime Yılı { get; set; } 
    
    public void Start(){
        System.Console.WriteLine($"{Brand} marka {Model}Araba calısıyor");
    }
    public void Stop(){
        System.Console.WriteLine("araba durdu");

    }
    public virtual void DisplayCar(){
        System.Console.WriteLine("marka"+" "+Brand +"\n model" + Model );

    }

    public abstract void GetSignal(); // gövdesi  olmayan her yerde ayrı olarak kullabilen metod türü i.in abstract gövddesi burda yazılmıyacak diğer her yerde zorunlu bunun kullanıslı olmasını ınterface ile ayarloyabiliriz
   
      
    
}
