namespace FactoryMethodPattern.Sample2
{
    class Program
    {
        public static void Excute()
        {
            IVehicleFactory factory = new FordFactory();
            var fordExplorer = factory.Create();
            fordExplorer.ShowInfo();
        }
    }
}
