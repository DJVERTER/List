using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Vehicle
    {
        public string brand = "Ford";
        public string brand2 = "Croazier";
        public virtual void honkSound()
        {
            Console.WriteLine("Sound!");
        }

        
    }
}
