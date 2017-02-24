using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Sample1
{
    class Program
    {
        public static void Excute()
        {
            // Create a Panel1 has textbox1.1 and panel1.2
            // panel1.1 has textbox1.1.1 and textbox1.1.2

            Control panel1 = new Panel { Name = "Panel1" };

            var textbox11 = new Textbox { Name = "Textbox1.1" };

            var panel12 = new Panel { Name = "Panel1.2" };

            var textbox111 = new Textbox { Name = "Textbox111" };
            var textbox112 = new Textbox { Name = "Textbox112" };

            panel12.AddControl(textbox111);
            panel12.AddControl(textbox112);

            panel1.AddControl(textbox11);
            panel1.AddControl(panel12);

            panel1.Render();
        }
    }
}
