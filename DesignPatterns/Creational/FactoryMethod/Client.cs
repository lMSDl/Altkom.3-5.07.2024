using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Creational.FactoryMethod
{
    internal class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var action = "Down";
            var floor = 5;

            IElevatorOperation elevatorOperation = null;
            switch (nameof(Elevator) + action)
            {
                case nameof(ElevatorDown):
                    elevatorOperation = new ElevatorDown();
                    break;
                case nameof(ElevatorUp):
                    elevatorOperation = new ElevatorUp();
                    break;
                case nameof(ElevatorGoTo):
                    elevatorOperation = new ElevatorGoTo();
                    break;
            }

            if (elevatorOperation != null)
            {
                elevator.Execute(elevatorOperation, floor);
            }

        }
     }
}
