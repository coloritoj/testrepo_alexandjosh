using System;

namespace AbstractClassAndInterfacePractice
{
    public interface IAccelerate
    {
        public void Accelerate();
    }

    public abstract class Car
    {
        public string Make;
        public string Model;
        public string Color;
    }

    public class ElectricCar : Car, IAccelerate
    {
        public int BatteryRemaining;

        public void RechargeBattery()
        {
            Console.WriteLine("The battery is being recharged!");
        }

        public void Accelerate()
        {
            Console.WriteLine("The electric car is accelerating!");
        }
    }


    public interface IBuy
    {
        public void Buy(string item);
    }

    public abstract class FinancialDerivative
    {
        public string Type;
        public int Price;
    }

    class Option : FinancialDerivative, IBuy
    {
        public Option(string _type, int _price)
        {
            this.Type = _type;
            this.Price = _price;
        }

        public void Buy(string optionType)
        {
            Console.WriteLine($"The {optionType} option was bought!");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            //ElectricCar myCar = new ElectricCar();
            //myCar.Accelerate();
            //myCar.RechargeBattery();
            //myCar.Make = "Tesla";
            //Console.WriteLine(myCar.Make);

            Option myOption = new Option("Call", 100);
            myOption.Buy(myOption.Type);
            Console.WriteLine($"The price of the option was ${myOption.Price}");
        }
    }
}
