using System;
using System.Collections.Generic;
using System.Text;

namespace Sphere_CDC
{
    class TestSphere
    {
        public static void Main(String[] args)
        {
            Sphere ball = new Sphere();
            Console.WriteLine("What is the diameter of the ball?");
            ball.setDiameter(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("The balls diameter is: "+ball.getDiameter());
            Console.WriteLine("The balls volume is: " + ball.getVolume());
            Console.WriteLine("The balls Surface area is: " + ball.getSurfaceArea());
        }
    }
}
