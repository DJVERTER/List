using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Ship : Vehicle
    {
        public override void honkSound()
        {
            Console.WriteLine("Boop");
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = Model; }
        }

        private int length;
        public int Length
        {
            get { return length; }
            set { length = Length; }
        }

        private int power;
        public int Power
        {
            get { return power; }
            set { power = Power; }
        }

        public Ship(string modelName, int modelLength, int modelPower)
        {
            model = modelName;
            length = modelLength;
            power = modelPower;
        }
    }
}
