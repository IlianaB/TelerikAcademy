using System;

namespace DefiningClasses
{
    public class Display
    {
        //Display fields
        private double size;
        private int colors;

        //Display constructors
        public Display()
            : base()
        {
        }

        public Display(double size)
        {
            this.Size = size;
        }

        public Display(double size, int colors)
            : this(size)
        {
            this.Colors = colors;
        }

        //Display properties
        public double Size
        {
            get 
            { 
                return this.size; 
            }
            set 
            {
                if (value < 2 || value > 7)
                {
                    throw new ArgumentOutOfRangeException("The size of the display must be between 2 and 7 inches!");
                }

                this.size = value; 
            }
        }

        public int Colors
        {
            get 
            { 
                return this.colors; 
            }
            set 
            {
                if (colors < 0)
                {
                    throw new ArgumentOutOfRangeException("Colors must be a positive value!");
                }

                this.colors = value; 
            }
        }
    }
}
