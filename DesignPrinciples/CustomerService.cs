namespace Altkom._3_5._07._2024.DesignPrinciples
{
    public class CustomerService
    {
        private ICollection<Customer> Customers { get; } = [new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5)];


        public Customer? GetById(int id)
        {
            return Customers.Where(x => x.IsActive).SingleOrDefault(x => x.Id == id);
        }
    }
}
