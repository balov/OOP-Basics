namespace PolymorphismExercises
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelConsumption = fuelConsumption + 0.9;
            this.FuelQuantity = fuelQuantity;
            this.TankCapacity = tankCapacity;
        }

        public override string Drive(double distance)
        {
            if (distance <= this.FuelQuantity / this.FuelConsumption)
            {
                this.FuelQuantity -= distance * FuelConsumption;
                return $"Car travelled {distance} km";
            }
            else
            {
                return "Car needs refueling";
            }
        }

        public override void Refuel(double fuel)
        {
            if (fuel + this.FuelQuantity < this.TankCapacity)
            {
                this.FuelQuantity += fuel;
            }
        }
    }
}