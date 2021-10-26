using AbstractClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new("Mustang", "Red", 1969, 4);
            Console.WriteLine();
            Console.WriteLine($"Model: {myCar.brand}, {myCar.Model} \nColor:{myCar.Color}, \nYear:{myCar.Year}, \nwd:{myCar.Wehl}");
            myCar.honkSound();
            Car myCar2 = new("Mondeo", "Silver", 2002, 2);
            Console.WriteLine();
            Console.WriteLine($"Model: {myCar2.brand}, {myCar2.Model} \nColor:{myCar2.Color}, \nYear:{myCar2.Year}, \nwd:{myCar2.Wehl}");
            myCar2.honkSound();
            Car myCar3 = new("Fusion", "Green", 2010, 2);
            Console.WriteLine();
            Console.WriteLine($"Model: {myCar3.brand}, {myCar3.Model} \nColor:{myCar3.Color}, \nYear:{myCar3.Year}, \nwd:{myCar3.Wehl}");
            myCar3.honkSound();
            Console.WriteLine();
            Ship myShip = new("Variag", 300, 500);
            Console.WriteLine($"Model: {myShip.brand2}, \nLength:{myShip.Length}, \nPower:{myShip.Power}");
            myShip.honkSound();

        }
    }
}