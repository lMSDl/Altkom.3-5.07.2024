﻿namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Visitor.I
{
    internal class Client
    {
        public static void Execute()
        {
            var collection = new IElement[]
{
                new PlainText() {Text = "Plain"},
                new PlainText() { Text = "\n" },
                new BoldText() {Text = "Bold"},
                new PlainText() { Text = "\n" },
                new Hyperlink() {Text = "Hyperlink",  Link=@"https:\\some.url.pl"}
};

            /*foreach (var item in collection)
            {
                Console.Write(item.ToHtml());
            }*/

            var visitor = new HtmlVisitor();
            foreach (var item in collection)
            {
                Console.Write(item.Accept(visitor));
            }
        }
    }
}
