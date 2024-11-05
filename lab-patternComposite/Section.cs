using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_patternComposite
{
    public class Section : Component
    {
        private List<Component> children = new List<Component>();

        public Section(string name) : base(name)
        {
        }
        public void Add(Component component)
        {
            children.Add(component);
        }
        public void Remove(Component component)
        {
            children.Remove(component);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (Component component in children)
            {
                component.Display(depth + 1);
            }
        }
    }
}
