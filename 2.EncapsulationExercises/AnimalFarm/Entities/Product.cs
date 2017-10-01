using System;

namespace AnimalFarm.Models
{
    public class Product
    {
        private string name;
        private double coast;

        public Product(string name, double coast)
        {
            this.Name = name;
            this.Coast = coast;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public double Coast
        {
            get { return this.coast; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.coast = value;
            }
        }
    }
}