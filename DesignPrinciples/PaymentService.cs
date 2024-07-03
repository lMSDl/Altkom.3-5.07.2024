namespace Altkom._3_5._07._2024.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = [new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5)];

        public bool DeletePaymentAccount(PaymentAccount account)
        {
            return PaymentAccounts.Remove(account);
        }

        public PaymentAccount? FindByAllowedDebit(float debit)
        {
            return PaymentAccounts.SingleOrDefault(x => x.AllowedDebit == debit);
        }

        public bool Charge(int id, float amount)
        {
            var account = GetAccountById(id);
            if (account == null)
                return false;

            if (GetBalance(id) + account.AllowedDebit < amount)
                return false;

            account.Outcome += amount;
            return true;
        }

        private PaymentAccount? GetAccountById(int id)
        {
            return PaymentAccounts.Where(x => x.IsActive).SingleOrDefault(x => x.Id == id);
        }

        public void Fund(int id, float amount)
        {
            var account = GetAccountById(id);
            if (account == null)
                return;
            account.Income += amount;
        }

        public float? GetBalance(int id)
        {
            var account = GetAccountById(id);
            return account?.Income - account?.Outcome;
        }
    }
}
