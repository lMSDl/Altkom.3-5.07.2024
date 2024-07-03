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

            elevator.Execute(action, floor);


            action = "Up";
            floor = 6;

            elevator.Execute(action, floor);


            action = "GoTo";
            floor = 1;

            elevator.Execute(action, floor);

        }


        public class MyElevator : Elevator
        {

            public override IElevatorOperation? GetOperation(string operation)
            {
                if(operation == "left")
                {
                    return new TurnLeft();
                }

                return base.GetOperation(operation);
            }

            class TurnLeft : IElevatorOperation
            {
                public void Operate(int floor)
                {
                    Console.WriteLine($"Winda skręca w lewo na piętrze {floor}");
                }
            }
        }
     }
}
