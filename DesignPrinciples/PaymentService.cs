namespace Altkom._3_5._07._2024.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = [new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5)];

        public bool Charge(int id, float amount)
        {
            var account = GetAccountById(id);
            return account?.Charge(amount) ?? false;
        }

        public void Fund(int id, float amount)
        {
            var account = GetAccountById(id);
            account?.Fund(amount);
        }

        private PaymentAccount? GetAccountById(int id)
        {
            return PaymentAccounts.Where(x => x.IsActive).SingleOrDefault(x => x.Id == id);
        }
    }
}
