namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Visitor.I
{
    internal interface IVisitor
    {
        string Visit(PlainText plainText);
        string Visit(BoldText boldText);
        string Visit(Hyperlink hyperlink);
    }
}
