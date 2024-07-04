
namespace Altkom._3_5._07._2024.DesignPatterns.Structural.Facade.I
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public string? DefaultString { get; set; }
        public int DefaultInt { get; set; }
    }
}