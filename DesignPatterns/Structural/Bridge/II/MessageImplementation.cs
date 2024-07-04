using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Bridge.II
{
    internal interface IMessageImplementation
    {
        string PrepareMessage(string message);
        void SendMessage(string message);
    }
}
