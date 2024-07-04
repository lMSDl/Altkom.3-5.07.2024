using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Creational.Prototype
{
    internal class Person : ICloneable, ICloneable<Person>
    {
        public Person Parent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address? Address { get; set; }
        public ICollection<Person> Children { get; private set; } = new List<Person>();

        public object ShallowClone()
        {
            var clone = MemberwiseClone();
            return clone;
        }

        Person ICloneable<Person>.Clone()
        {
            return (Person)Clone();
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true, ReferenceHandler = ReferenceHandler.Preserve });
        }

        public object DeepClone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Parent = (Person)Parent?.Clone();
            clone.Address = (Address)Address?.Clone();
            return clone;
        }

        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = (Address)Address?.Clone();
            clone.Children = (ICollection<Person>)Children.ToList();
            return clone;
        }
    }
}
