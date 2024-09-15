using System;

namespace Project23_InheritanceSamples.CarManagamentSystem;

public class MotarCycle : Vehicle
{
    public MotarCycle(string brand, string model, DateTime yılı, string coolingSystem) : base(brand, model, yılı)
    {
        CoolingSystem = coolingSystem;
    }
    public string CoolingSystem { get; set; }
    public override void DisplayCar()
    {
        base.DisplayCar();
    }

    public override void GetSignal()
    {
        throw new NotImplementedException();
    }
}
