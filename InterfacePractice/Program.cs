using System;

namespace InterfacePractice
{
    public interface ISell
    {
        public void SellStock();
    }

    public interface IBuy
    {
        public void BuyStock();
    }

    public class Stock : ISell, IBuy
    {
        public void SellStock()
        {
            Console.WriteLine("The stock was sold!");
        }

        public void BuyStock()
        {
            Console.WriteLine("The stock was bought!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stock gamestop = new Stock();
            gamestop.BuyStock();
            gamestop.SellStock();

            Stock microsoft = new Stock();
            microsoft.BuyStock();
            microsoft.BuyStock();
            microsoft.BuyStock();

        }
    }
}
