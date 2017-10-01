using System;

namespace PolymorphismExercises
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var firstVehicule = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var secondVehicule = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var thirdVehicule = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int numberOfCommands = int.Parse(Console.ReadLine());

            Car car = new Car(double.Parse(firstVehicule[1]), double.Parse(firstVehicule[2]), double.Parse(firstVehicule[3]));
            Truck truck = new Truck(double.Parse(secondVehicule[1]), double.Parse(secondVehicule[2]), double.Parse(secondVehicule[3]));
            Bus bus = new Bus(double.Parse(thirdVehicule[1]), double.Parse(thirdVehicule[2]), double.Parse(thirdVehicule[3]));
            ExecuteCommands(numberOfCommands, car, truck, bus);
        }

        public static void ExecuteCommands(int numberOfCommands, Car car, Truck truck, Bus bus)
        {
            for (int i = 0; i < numberOfCommands; i++)
            {
                var commands = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Refuel")
                {
                    if (commands[1] == "Car")
                    {
                        car.Refuel(double.Parse(commands[2]));
                    }
                    else if (commands[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(commands[2]));
                    }
                    else if (commands[1] == "Bus")
                    {
                    }
                }

                if (commands[0] == "Drive")
                {
                    if (commands[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(commands[2])));
                    }
                    else
                    {
                        Console.WriteLine(truck.Drive(double.Parse(commands[2])));
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}