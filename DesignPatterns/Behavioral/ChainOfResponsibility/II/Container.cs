using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Container : Component
    {
        protected ICollection<Component> Content { get; } = new List<Component>();
        public void Add(Component component)
        {
            Content.Add(component);
            component.Parent = this;
        }
    }
}
