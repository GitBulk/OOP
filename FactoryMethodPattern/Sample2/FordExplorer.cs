using System;

namespace FactoryMethodPattern.Sample2
{
    class FordExplorer : Vehicle
    {
        public FordExplorer()
        {
            Model = "Ford Explorer";
            Engine = "4.0 L Cologne V6";
            Accessories.Add("Car Cover");
            Accessories.Add("Sun Shade");
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Engine: {0}", Engine);
            Console.WriteLine("Accessories:");
            foreach (var accessory in Accessories)
            {
                Console.WriteLine("\t{0}", accessory);
            }
        }
    }
}
