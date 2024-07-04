using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Creational.Builder
{
    internal abstract class BaseVehicleBuilder
    {
        protected Vehicle Vehicle { get; } = new Vehicle();

        protected BaseVehicleBuilder()
        {
        }

        protected BaseVehicleBuilder(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)Vehicle.Clone();
        }
    }
}
