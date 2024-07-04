using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Creational.Builder
{
    internal class VehicleProductionInfoBuilder : VehicleBuilderFacade
    {
        public VehicleProductionInfoBuilder()
        {
        }

        internal VehicleProductionInfoBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleProductionInfoBuilder SetManufacturer(string value)
        {
            Vehicle.Manufacturer = value;
            return this;
        }
        public VehicleProductionInfoBuilder SetProductionDate(DateTime value)
        {
            Vehicle.ProductionDate = value;
            return this;
        }
    }
}
