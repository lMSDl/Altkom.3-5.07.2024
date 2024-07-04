namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class TextBox : Container
    {
        private string text;
        public string Text
        {
            get => text;
            set
            {
                text = value;
                Console.WriteLine($"{Name} zmienił wartość na {value}");
            }
        }

        protected override void Click(bool handled)
        {
            if (!handled)
                Console.WriteLine($"{Name} złapał focus");
            base.Click(true);
        }
    }
}
