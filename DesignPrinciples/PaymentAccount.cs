namespace Altkom._3_5._07._2024.DesignPrinciples
{
    public class PaymentAccount
    {
        public PaymentAccount(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }
        public float Income { get; set; }
        public float Outcome { get; set; }
        public float AllowedDebit { get; set; }

        public bool IsDebit()
        {
            return Income - Outcome < 0;
        }
    }
}
