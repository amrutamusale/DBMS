using System;

namespace ConsoleApp4
{
    public class Shape
    {
        protected Location c;
        public string ToString()
        {
            return string.Empty;
        }
        public double Area()
        {
            return 0.00;
        }
        public double Parimeter()
        {
            return 0.00;
        }
    }
    public class Rectangle : Shape
    {
        protected double side1, side2;
    }
    public class circle : Shape
    {
        protected double radius;
    }
    public class Location
    {
        private double x, y;
    }
    class class1
    {
        public static void Main1()
        {

        }
    }
}


    

