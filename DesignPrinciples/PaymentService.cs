namespace Altkom._3_5._07._2024.DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(PaymentAccount account, float amount)
        {
            return account?.Charge(amount) ?? false;
        }

        public void Fund(PaymentAccount account, float amount)
        {
            account?.Fund(amount);
        }
    }
}
