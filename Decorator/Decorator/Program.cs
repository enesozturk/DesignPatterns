using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car theCar = new CompactCar();
            theCar = new LeatherSeats(theCar);

            Console.WriteLine(theCar.GetDescription());
            Console.WriteLine($"${theCar.GetCarPrice()}");
            Console.ReadKey();
        }
    }
}
