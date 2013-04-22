namespace FigureRotator
{
    using System;

    public class Figure
    {
        // fields
        private double width;
        private double heigth;

        // constructor
        public Figure(double Width, double Heigth)
        {
            this.width = Width;
            this.heigth = Heigth;
        }

        // properites
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width can not be a negative number");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height can not be a negative number");
                }

                this.height = value;
            }
        }

        // methods
        public static Size GetRotatedSize(Figure shape, double Angle)
        {
            double newWidth = (Math.Abs(Math.Cos(angleOfFigure)) * currentSize.Width) +
                 (Math.Abs(Math.Sin(angleOfFigure)) * currentSize.Height);
            double newHeight = (Math.Abs(Math.Sin(angleOfFigure)) * currentSize.Width) +
                (Math.Abs(Math.Cos(angleOfFigure)) * currentSize.Height);

            return new Figure(newWidth, newHeight);
        }
    }
}