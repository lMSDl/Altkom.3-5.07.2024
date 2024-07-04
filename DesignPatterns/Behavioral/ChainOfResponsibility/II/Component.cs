﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal abstract class Component
    {
        public string Name { get; set; }
        public Component? Parent { get; set; }

        public void Click()
        {
            Click(false);
        }

        protected virtual void Click(bool handled)
        {
            Parent?.Click(handled);
        }
    }
}
