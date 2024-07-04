using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Creational.Builder
{
    internal class VehicleBuilderFacade : BaseVehicleBuilder
    {
        public VehicleBuilderFacade()
        {
        }

        internal VehicleBuilderFacade(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder Parts => new VehicleBuilder(Vehicle);
        public VehicleProductionInfoBuilder Info => new VehicleProductionInfoBuilder(Vehicle);
    }
}
