namespace CompositePattern.Sample1
{
    abstract class Control
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Render(int level = 0);

        public virtual void AddControl(Control control) { }

        public virtual void RemoveControl(Control control) { }
    }
}
