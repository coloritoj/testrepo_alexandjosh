using System;

namespace AbstractClassPractice
{
    
    public abstract class Car
    {
        public string Make;
        public string Model;
        public string Color;

        public void Accelerate()
        {
            Console.WriteLine("The car is accelerating!");
        }

        public void Brake()
        {
            Console.WriteLine("The car is slowing down!");
        }
    }

    public class ElectricCar : Car
    {
        public int BatteryRemaining;

        public void RechargeBattery()
        {
            Console.WriteLine("The battery is recharging!");
        }
    }

    public class InternalCombustionEngineCar : Car
    {
        public int FuelRemaining;

        public void RefuelGasTank()
        {
            Console.WriteLine("The gas tank is being refuled!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ElectricCar myElectricCar = new ElectricCar();
            myElectricCar.Make = "Tesla";
            myElectricCar.Model = "Model 3";
            myElectricCar.Color = "Red";
            myElectricCar.BatteryRemaining = 50;

            Console.WriteLine(myElectricCar.Make);
            Console.WriteLine(myElectricCar.Model);
            Console.WriteLine(myElectricCar.Color);
            Console.WriteLine(myElectricCar.BatteryRemaining);
            myElectricCar.Accelerate();
            myElectricCar.Brake();
            myElectricCar.RechargeBattery();



            InternalCombustionEngineCar iceCar = new InternalCombustionEngineCar();
            iceCar.Make = "Ford";
            iceCar.Model = "Focus";
            iceCar.Color = "Blue";
            iceCar.FuelRemaining = 10;

            Console.WriteLine(iceCar.Make);
            Console.WriteLine(iceCar.Model);
            Console.WriteLine(iceCar.Color);
            Console.WriteLine(iceCar.FuelRemaining);
            iceCar.Accelerate();
            iceCar.Brake();
            iceCar.RefuelGasTank();
        }
    }
}
