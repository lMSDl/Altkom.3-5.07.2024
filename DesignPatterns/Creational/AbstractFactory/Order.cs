using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Creational.AbstractFactory
{
    internal class Order
    {
        private readonly ICar _car;

        public Order(string manufacturer, string type, string segment)
        {
            switch (manufacturer)
            {
                case "Honda":
                    switch (type)
                    {
                        case nameof(ISedan):
                            switch (segment)
                            {
                                case "compact":
                                    _car = new HondaCompactSedan();
                                    break;
                                case "full":
                                    _car = new HondaFullSedan();
                                    break;
                            }
                            break;
                        case nameof(ISuv):
                            switch (segment)
                            {
                                case "compact":
                                    _car = new HondaCompactSuv();
                                    break;
                                case "full":
                                    _car = new HondaFullSuv();
                                    break;
                            }
                            break;
                    }
                    break;
                case "Toyota":
                    switch (type)
                    {
                        case nameof(ISedan):
                            switch (segment)
                            {
                                case "compact":
                                    _car = new ToyotaCompactSedan();
                                    break;
                                case "full":
                                    _car = new ToyotaFullSedan();
                                    break;
                            }
                            break;
                        case nameof(ISuv):
                            switch (segment)
                            {
                                case "compact":
                                    _car = new ToyotaCompactSuv();
                                    break;
                                case "full":
                                    _car = new ToyotaFullSuv();
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        public string ManufacturedCarName()
        {
            return _car.Name();
        }

    }
}
