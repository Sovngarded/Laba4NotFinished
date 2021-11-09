using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent enginev6 = new Leaf("Engine V6", 1, 200);
            IComponent wheel = new Leaf("Wheel", 4, 50);
            IComponent transmission = new Leaf("Transmission", 1, 60);
            IComponent differential = new Leaf("Differential", 2, 100);
            IComponent door = new Leaf("Door", 4, 150);
            IComponent gastank = new Leaf("Gastank", 1, 170);

            
            Composite car = new Composite("Car");
            
            car.AddComponent(enginev6);
            car.AddComponent(wheel);
            car.AddComponent(transmission);
            car.AddComponent(differential);
            car.AddComponent(door);
            car.AddComponent(gastank);

            car.DisplayQuantityAndWeight();
            
        }
    }
}
