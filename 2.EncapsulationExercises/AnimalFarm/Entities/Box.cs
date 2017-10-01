using System;

namespace AnimalFarm.Models
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public Box()
        {
        }

        public double Length
        {
            get { return this.length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public double GetSurfaceArea()
        {
            double surfaceArea = 2 * length * width + 2 * length * height + 2 * width * height;
            return surfaceArea;
        }

        public double GetLateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * length * height + 2 * width * height;
            return lateralSurfaceArea;
        }

        public double GetVolume()
        {
            double volume = height * width * length;
            return volume;
        }
    }
}