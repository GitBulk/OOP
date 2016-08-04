namespace AbstractFactoryPattern.Sample1
{
    public abstract class Desktop
    {
        public string Model { get; set; }
        public abstract string Name { get; }
    }
}