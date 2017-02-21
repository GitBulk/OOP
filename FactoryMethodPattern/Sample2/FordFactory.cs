namespace FactoryMethodPattern.Sample2
{
    class FordFactory : IVehicleFactory
    {
        public Vehicle Create()
        {
            return new FordExplorer();
        }
    }
}
