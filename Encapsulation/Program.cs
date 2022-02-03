using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle myRectangle = new Rectangle(5, 3);

            //Console.WriteLine(myRectangle.GetLength());

            //Console.WriteLine(myRectangle.GetArea());

            //myRectangle.SetLength(9);

            //Console.WriteLine(myRectangle.GetLength());

            //Console.WriteLine(myRectangle.GetArea());

            OtherRectangle otherRect = new OtherRectangle(4, 2);

            Console.WriteLine(otherRect.length);

            Console.WriteLine(otherRect.width);

            Console.WriteLine(otherRect.area);

            otherRect.length = 10;

            Console.WriteLine(otherRect.length);

            Console.WriteLine(otherRect.width);

            Console.WriteLine(otherRect.area);
        }
    }
}
