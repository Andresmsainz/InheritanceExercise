using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercise
{
    class Vehicle
    {
    }

    class WheeledVehicles : Vehicle
    {
        private string color;
        private decimal price;

        public string Color { get; set; }
        public decimal Price { get; set; }

        public void ChangeColor()
        {
            Console.WriteLine("Color has changed");
        }
    }

    class FourWheeledVehicles : WheeledVehicles
    {
        private string brandName;
        private int capacity;

        public string BrandName { get; set; }
        public int Capacity { get; set; }

        public void StartVehicle()
        {
            Console.WriteLine("Four Wheel Vehicle has started");
        }

        public void RunAtFullSpeed()
        {
            Console.WriteLine("Four Wheel Vehicle is running at full speed");
        }

        public FourWheeledVehicles()
        {

        }
    }
}
