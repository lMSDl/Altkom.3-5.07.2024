namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Command
{
    internal class RemoveCommand : ICommand
    {
        private Garden Garden { get; }
        private string PlantName { get; }

        public RemoveCommand(Garden garden, string plantName)
        {
            Garden = garden;
            PlantName = plantName;
        }

        public bool Execute()
        {
            return Garden.Remove(PlantName);
        }

        public void Reverse()
        {
            Garden.Add(PlantName);
        }
    }
}
