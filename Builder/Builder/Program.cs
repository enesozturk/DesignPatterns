using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        // The Client
        static void Main(string[] args)
        {
            var superBuilder = new SuperCar();
            var normalBuilder = new NormalCar();

            var factory = new CarFactory();
            var builder = new List<CarBuilder>
            {
                superBuilder,normalBuilder
            };

            foreach (var b in builder)
            {
                var c = factory.Build(b);
                Console.WriteLine($"The Car requested by " +
                    $"{b.GetType().Name}" +
                    $"\n-----------------------------" +
                    $"\nHorse Power: {c.HorsePower}" +
                    $"\nImpressive Feature: {c.MostImpressiveFeature}" +
                    $"\nTop Speed: {c.TopSpeedMPH}\n");
            }

            Console.ReadKey();
        }


    }

    // Product Class
    public class Car
    {
        public int TopSpeedMPH { get; set; }
        public int HorsePower { get; set; }
        public string MostImpressiveFeature { get; set; }
    }

    // Builder Abstract Class
    public abstract class CarBuilder
    {
        protected readonly Car _car = new Car();
        public abstract void SetHorsePower();
        public abstract void SetTopSpeed();
        public abstract void SetImpressiveFeature();

        public virtual Car GetCar()
        {
            return _car;
        }
    }

    // Director Class
    public class CarFactory
    {
        public Car Build(CarBuilder builder)
        {
            builder.SetHorsePower();
            builder.SetTopSpeed();
            builder.SetImpressiveFeature();
            return builder.GetCar();
        }
    }

    // ConcreteBuilder1 Class
    public class NormalCar : CarBuilder
    {
        public override void SetHorsePower()
        {
            _car.HorsePower = 120;
        }

        public override void SetImpressiveFeature()
        {
            _car.MostImpressiveFeature = "Has Air Conditioning";
        }

        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 90;
        }
    }

    // ConcreteBuilder2 Class
    public class SuperCar : CarBuilder
    {
        public override void SetHorsePower()
        {
            _car.HorsePower = 350;
        }

        public override void SetImpressiveFeature()
        {
            _car.MostImpressiveFeature = "Can Fly";
        }

        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 250;
        }
    }


}
