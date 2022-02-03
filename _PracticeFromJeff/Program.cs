using System;
using System.Collections.Generic;

namespace _PracticeFromJeff
{
    public class Car
    {
        public string testString = "Hello this is a test";
        public int speed = 100;
    }

    public class ElectricCar : Car
    {
        public string electricTestString = "Hello this is a test string for electric car";
    }

    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal is speaking!");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat says meow!");
        }
    }

    class Program
    {
        public static void AccelerateCar(Car vehicle)
        {
            Console.WriteLine(vehicle.speed);
            Console.WriteLine("The vehicle is accelerating!");
        }

        static void Main(string[] args)
        {
            List<Car> mycars = new List<Car>();

            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();
            ElectricCar car4 = new ElectricCar();

            mycars.Add(car1);
            mycars.Add(car2);
            mycars.Add(car3);
            mycars.Add(car4);

            foreach (Car vehicle in mycars)
            {
                Console.WriteLine(vehicle.testString);
            }

            AccelerateCar(car4);

            Cat dfv = new Cat();
            dfv.Speak();

        }
    }
}
