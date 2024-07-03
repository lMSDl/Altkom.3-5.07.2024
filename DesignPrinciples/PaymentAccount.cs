using System.Security.Principal;

namespace Altkom._3_5._07._2024.DesignPrinciples
{
    public class PaymentAccount
    {
        public float Income { get; private set; }
        public float Outcome { get; private set; }
        public float AllowedDebit { get; set; }


        public bool Charge(float amount)
        {
            if (GetBalance() < amount)
                return false;

            Outcome += amount;
            return true;
        }
        public void Fund(float amount)
        {
            Income += amount;
        }

        private float GetBalance()
        {
            return Income - Outcome + AllowedDebit;
        }
    }
}
