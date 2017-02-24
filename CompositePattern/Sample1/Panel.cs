using System;
using System.Collections.Generic;

namespace CompositePattern.Sample1
{
    class Panel: Control
    {
        // Rule: Panel only contains sub panel or textbox

        private List<Control> ChildControls = new List<Control>();
        
        public override void AddControl(Control control)
        {
            if (this.Name != control.Name)
            {
                ChildControls.Add(control);
            }
            else
            {
                throw new Exception("Cannot add itself");
            }
        }

        public override void RemoveControl(Control control)
        {
            if (this.Name != control.Name)
            {
                ChildControls.Remove(control);
            }
            else
            {
                throw new Exception("Cannot remove itself");
            }
        }

        public override void Render(int level = 0)
        {
            Console.WriteLine(new string('-', level) + "Child Control for Panel(" + Name + ")  Render start");
            foreach (Control item in ChildControls)
            {
                //Panel objPanel = item as Panel;
                //if (item == null)
                //{
                //    Textbox objTextbox = item as Textbox;
                //    objTextbox.Render();
                //}
                //else
                //{
                //    objPanel.Render();
                //}
                item.Render(level + 2);
            }
            Console.WriteLine(new string('-', level) + "Child Control for Panel(" + Name + ")  Render End");
        }
    }
}
