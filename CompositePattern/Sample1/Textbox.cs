using System;

namespace CompositePattern.Sample1
{
    class Textbox : Control
    {
        // Textbox is leaf

        public override void Render(int level = 0)
        {
            Console.WriteLine(new string('-', level) + $"Textbox({ Name })Rendered");
        }
    }
}
