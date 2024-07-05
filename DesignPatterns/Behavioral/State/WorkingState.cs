using System.Threading;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.State
{
    internal class WorkingState : State
    {
        private readonly CancellationTokenSource cancellationTokenSource;
        public WorkingState(CoffeeMachine coffeeMachine, int time) : base(coffeeMachine)
        {
            cancellationTokenSource = new CancellationTokenSource();
            Task.Delay(TimeSpan.FromMilliseconds(time), cancellationTokenSource.Token).ContinueWith(x =>
            {
                CoffeeMachine.State = new IdleState(CoffeeMachine);
                cancellationTokenSource.Dispose();
            });
        }

        public override void Large()
        {
            System.Console.WriteLine("Anulacja");
            cancellationTokenSource.Cancel();
        }

        public override void Small()
        {
            System.Console.WriteLine("Anulacja");
            cancellationTokenSource.Cancel();
        }
    }
}