using System;

namespace ConsoleApp3
{
    interface Vehicle
    {
        void changeGear(int a);
        void applyBreak(int a);
        void speedUp(int a);
    }
    class Bicycle : Vehicle
    {
        int speed;
        int gear;
        public void applyBreak(int decrement)
        {
            speed = speed - decrement;
        }
        public void changeGear(int newGear)
        {
            gear = newGear;
        }
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }
        public void printStates()
        {
            Console.WriteLine("Bike Speed" + speed + "Bike Gear" + gear);
        }

    }
    class class1
        {
        public static void Main1()
        {
            Bicycle b = new Bicycle();
            b.changeGear(2);
            b.speedUp(2);
            b.applyBreak(1);
            b.printStates();
        }
    }
}
    

