namespace PolymorphismExercises
{
    public class Bus : Vehicle
    {
        private bool isEmpty;

        public bool IsEmpty
        {
            get { return this.isEmpty; }
            set { this.isEmpty = value; }
        }

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = fuelQuantity;
            this.TankCapacity = tankCapacity;
            this.IsEmpty = false;
        }

        public override double FuelConsumption
        {
            get
            {
                if (IsEmpty == true)
                {
                    return base.FuelConsumption;
                }
                else
                {
                    return base.FuelConsumption + 1.4;
                }
            }
            set
            {
                base.FuelConsumption = value;
            }
        }

        public override string Drive(double distance)
        {
            if (distance <= this.FuelQuantity / this.FuelConsumption)
            {
                this.FuelQuantity -= distance * FuelConsumption;
                return $"Bus travelled {distance} km";
            }
            else
            {
                return "Bus needs refueling";
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