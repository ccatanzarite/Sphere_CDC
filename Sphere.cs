using System;

namespace Sphere_CDC
/**
 * This class models a sphere object
 * @author Clayton Catanzarite
 * @version 1.0
 */
{
    public class Sphere
    {
        private double diameter;
        
        public Sphere()
        {
            diameter = 2.0;
        }

        public Sphere(double diameter)
        {
            this.setDiameter(diameter);
        }

        public double getVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(diameter/2,3);
        }

        public double getSurfaceArea()
        {
            return 4.0 * Math.PI * Math.Pow(diameter / 2, 2);
        }

        public double getDiameter()
        {
            return diameter;
        }

        public void setDiameter(double diameter)
        {
            if (diameter < 2)
                this.diameter = 2.0;
            else
                this.diameter = diameter;
        }

        public String toString()
        {
            return "Sphere [diameter=" + diameter + "]";
        }
    }
}
