using System;

namespace PropertiesPractice
{
    public class Movie
    {
        public string title;
        public string rating;
        public int duration;

        public Movie(string title, string rating, int duration)
        {
            this.title = title;
            this.rating = rating;
            this.duration = duration;
        }
    }

    public class Book
    {
        private string title;

        public Book(string title)
        {
            this.title = title;
        }

        public string Title
        {
            get
            {
                return title;
            }
        }
    }

    public class Car
    {
        // This is a private member
        private string make;

        // This is the constructor for Car
        public Car(string make)
        {
            // this.make is referring to the PRIVATE STRING MAKE member above -- make is referring to what was passed in the constructor
            this.make = make;
        }

        // This is the property for the PRIVATE STRING MAKE member
        public string Make
        {
            // This returns PRIVATE STRING MAKE;
            get
            {
                return make;
            }

            // This allows PRIVATE STRING MAKE to be set to whatever is passed into the propert Make
            set
            {
                make = value;
            }
        }
    }

    public class GameConsole
    {
        private string name;
        public static int controllercount = 4;

        public GameConsole(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public static void TurnConsoleOn()
        {
            Console.WriteLine("The console is turning on!");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Titanic", "PG-13", 180);
            Console.WriteLine(movie1.rating);

            Book book1 = new Book("Harry Potter");
            Console.WriteLine(book1.Title);

            Car car1 = new Car("Tesla");
            Console.WriteLine(car1.Make);
            car1.Make = "Chevrolet";
            Console.WriteLine(car1.Make);

            GameConsole console = new GameConsole("Nintendo Switch");
            Console.WriteLine(console.Name);
            Console.WriteLine(GameConsole.controllercount);
            GameConsole.TurnConsoleOn();
        }
    }
}
