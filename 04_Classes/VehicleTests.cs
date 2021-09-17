using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Classes
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void Properties()
        {
           //"newing" up a vehicle
            Vehicle firstVehicle = new Vehicle();


            firstVehicle.Make = "Ford";

            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Focus";
            firstVehicle.Mileage = 151236.5;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine($"This is a {firstVehicle.Make} {firstVehicle.Model} it has {firstVehicle.Mileage} miles on it");

        }

        [TestMethod]
        public void Constructors()
        {
            Vehicle car = new Vehicle();
            car.Make = "Honda";
            car.Model = "Accord";
            car.Mileage = 10;
            car.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine($"This is my {car.Make} {car.Model}");

            Vehicle rocket = new Vehicle("Nasa", "Shuttle", 4000000, VehicleType.Spaceship);
            Console.WriteLine($"This is my {rocket.Make} {rocket.Model}");

        }
    }
}
