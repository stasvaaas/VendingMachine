using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Contracts;

namespace VendingMachine.Entities
{
    internal class Cup : CupBase, ICoffee, IMilk, ISugar, IWater
    {
        public override void Stir()
        {
            Console.WriteLine("Stirring the coffee.");
        }
        public void AddSugar()
        {
            Console.WriteLine("Adding sugar");
        }

        public void AddMilk()
        {
            Console.WriteLine("Adding milk");
        }

        public void AddWater()
        {
            Console.WriteLine("Adding water");
        }

        public void AddCoffee()
        {
            Console.WriteLine("Adding coffee");
        }
    }
}
