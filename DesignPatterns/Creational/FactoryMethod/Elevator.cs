
namespace Altkom._3_5._07._2024.DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {
        private readonly Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>();
        public void Execute(IElevatorOperation? operation, int floor)
        {
            operation?.Operate(floor);
        }
        public void Execute(string operation, int floor)
        {
            Execute(GetOperation(operation), floor);
        }

        public virtual IElevatorOperation? GetOperation(string operation)
        {
            if (!_operations.TryGetValue(operation, out var elevatorOperation))
            {
                switch (nameof(Elevator) + operation)
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
                    default:
                        return null;
                }
                _operations[operation] = elevatorOperation;
            }

            return elevatorOperation;
        }
    }
}
