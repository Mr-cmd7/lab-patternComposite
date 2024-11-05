using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_patternComposite
{
    public class Page : Component
    {
        public Page(string name) : base(name)
        {
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
}
