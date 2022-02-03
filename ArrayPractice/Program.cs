using System;

namespace ArrayPractice
{
    class Program
    {
        public class Animal
        {
            public string name;
        }

        public class Cat : Animal
        {
            public string Meow()
            {
                return "The cat says MEOW";
            }
        }

        public class Dog : Animal
        {
            public string Bark()
            {
                return "The dog says WOOF";
            }
        }


        static void Main(string[] args)
        {
            int[] myArray = new [] { 1, 2, 3, 4, 5};
            
            foreach (int num in myArray)
            {
                Console.WriteLine(num);
            }


            //Cat cat1 = new Cat();
            //Cat cat2 = new Cat();
            //Dog dog1 = new Dog();
            //Dog dog2 = new Dog();

            //Animal[] animals = new [] { cat1, cat2 };
        }
    }
}
