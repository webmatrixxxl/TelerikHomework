using System;

namespace Abstraction
{
    public class Rectangle : Figure
    {
        private double width;
        private double heigth;
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid input data. Width must be positive!");
                }
            }
        }

        public double Height
        {
            get
            {
                return this.heigth;
            }

            set
            {
                if (value > 0)
                {
                    this.heigth = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid input data. Height must be positive!");
                }
            }

        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}