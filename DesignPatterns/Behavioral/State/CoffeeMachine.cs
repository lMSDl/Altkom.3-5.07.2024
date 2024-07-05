using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.State
{
    internal class CoffeeMachine
    {
        private State state;
        public State State
        {
            get => state;
            set
            {
                Console.WriteLine($"Zmiana stanu na {value.GetType().Name}");
                state = value;
            }
        }

        public CoffeeMachine()
        {
            State = new HeatingUpState(this);
        }

        public void SmallCoffee()
        {
            State.Small();
        }

        public void LargeCoffee()
        {
            State.Large();
        }
    }
}
