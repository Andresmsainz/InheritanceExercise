using System;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Exercise!");

            FourWheeledVehicles car = new FourWheeledVehicles();

            car.ChangeColor();
            car.StartVehicle();
            car.RunAtFullSpeed();
        }
    }
}
