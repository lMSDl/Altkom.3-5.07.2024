namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.State
{
    internal class HeatingUpState : State
    {
        public HeatingUpState(CoffeeMachine coffeeMachine) : base(coffeeMachine)
        {
            Task.Delay(5000).ContinueWith(x => CoffeeMachine.State = new IdleState(CoffeeMachine));
        }

        public override void Large()
        {
            System.Console.WriteLine("Nie teraz.. Rozgrzewam się..");
        }

        public override void Small()
        {
            Large();
        }
    }
}