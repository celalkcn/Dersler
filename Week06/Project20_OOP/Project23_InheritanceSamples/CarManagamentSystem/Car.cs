using System;

namespace Project23_InheritanceSamples.CarManagamentSystem;

public class Car : Vehicle
{
    
    public Car(string brand, string model, DateTime yılı, int countOfDoors) : base(brand, model, yılı)
    {
        CountOfDoors = countOfDoors;
    }
    public int CountOfDoors { get; set; }

    public override void GetSignal()
    {
        throw new NotImplementedException();
    }

    public void OpenTrunk(){
        System.Console.WriteLine("Üstü acık");

    }
    

}
