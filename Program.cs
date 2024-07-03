

using Altkom._3_5._07._2024.DesignPrinciples;

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
    if(!paymentService.Charge(customer.Account, 100))
    {
        Console.WriteLine("Brak środków na koncie");
    }    

}