namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Mediator
{
    internal abstract class ChatMemeber
    {
        public string Nick { get; set; }

        private IMediator? mediator;
        public IMediator Mediator
        {
            get => mediator;
            set
            {
                if (mediator != null)
                    mediator.Quit(this);
                mediator = value;
                if (mediator != null)
                    mediator.Join(this);
            }
        }

        public abstract void Receive(string from, string message, bool isPrivate);
    }
}