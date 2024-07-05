

using Altkom._3_5._07._2024.DesignPrinciples;
using Altkom._3_5._07._2024.SOLID.L;



Altkom._3_5._07._2024.DesignPatterns.Behavioral.Strategy.Client.Execute();



static void TestDesignPrinciples()
{
    var inputId = 1;

    var customerService = new CustomerService();

    var customer = customerService.GetById(inputId);

    if (customer is null)
    {
        Console.WriteLine("Brak klienta o podanym id");
        return;
    }

    var paymentService = new PaymentService();
    paymentService.Fund(customer.Account, 500);
    if (!paymentService.Charge(customer.Account, 100))
    {
        Console.WriteLine("Brak środków na koncie");
    }

}

static void LSP()
{
    int a = 4;
    int b = 9;

    var rectangle = CreateRectangle(a, b);
    Console.WriteLine($"{a} * {b} = {rectangle.Area}");


    Rectangle CreateRectangle(int a, int b)
    {
        return new Square { A = a, B = b };
    }
}