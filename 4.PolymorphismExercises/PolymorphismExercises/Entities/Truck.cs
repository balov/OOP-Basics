namespace PolymorphismExercises
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelConsumption = fuelConsumption + 1.6;
            this.FuelQuantity = fuelQuantity;
            this.TankCapacity = tankCapacity;
        }

        public override string Drive(double distance)
        {
            if (distance <= this.FuelQuantity / this.FuelConsumption)
            {
                this.FuelQuantity -= distance * FuelConsumption;
                return $"Truck travelled {distance} km";
            }
            else
            {
                return "Truck needs refueling";
            }
        }

        public override void Refuel(double fuel)
        {
            this.FuelQuantity += fuel * 0.95;
        }
    }
}