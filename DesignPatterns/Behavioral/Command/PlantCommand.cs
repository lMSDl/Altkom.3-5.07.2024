namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Command
{
    internal class PlantCommand : ICommand
    {
        private Garden Garden { get; }
        private string PlantName { get; }

        public PlantCommand(Garden garden, string plantName)
        {
            Garden = garden;
            PlantName = plantName;
        }

        public bool Execute()
        {
            return Garden.Add(PlantName);
        }

        public void Reverse()
        {
            Garden.Remove(PlantName);
        }
    }
}
