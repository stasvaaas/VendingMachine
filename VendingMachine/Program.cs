using VendingMachine.Contracts;
using VendingMachine.Entities;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cup coffeeCup = new Cup();

            AddCoffee(coffeeCup);
            coffeeCup.Stir();
            AddWater(coffeeCup);
            coffeeCup.Stir();
            AddMilk(coffeeCup);
            coffeeCup.Stir();
            AddSugar(coffeeCup);
            coffeeCup.Stir();

            Console.WriteLine("Your favorite coffee is ready!");
        }

        static void AddCoffee(ICoffee container)
        {
            container.AddCoffee();
        }

        static void AddWater(IWater container)
        {
            container.AddWater();
        }

        static void AddMilk(IMilk container)
        {
            container.AddMilk();
        }

        static void AddSugar(ISugar container)
        {
            container.AddSugar();
        }
    }
}