using System.Collections.Generic;

namespace FactoryMethodPattern.Sample2
{
    abstract class Vehicle
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public List<string> Accessories = new List<string>();

        public abstract void ShowInfo();
    }
}
