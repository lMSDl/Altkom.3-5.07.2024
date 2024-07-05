namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Visitor.I
{
    internal class HtmlVisitor : IVisitor
    {
        public string Visit(PlainText plainText)
        {
            return plainText.Text;
        }

        public string Visit(BoldText boldText)
        {
            return $"<b>{boldText.Text}</b>";
        }

        public string Visit(Hyperlink hyperlink)
        {

            return $"<a href={hyperlink.Link}>{hyperlink.Text}</a>";
        }
    }
}
