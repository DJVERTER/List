using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Car : Vehicle
    {
        public override void honkSound()
        {
            Console.WriteLine("Bip");
        }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = Model; }
        }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = Color; }
        }
        private int year;
        public int Year
        {
            get { return year; }
            set { year = Year; }
        }
        private int wehl;
        public int Wehl
        {
            get { return wehl; }
            set { wehl = Wehl; }
        }

        public Car(string modelName, string modelColor, int modelYear, int numberWehl)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
            wehl = numberWehl;
        }
    }
}
