using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Facade.III
{
    internal interface IXmlConverter
    {
        string ToXml<T>(T obj);
    }
}
