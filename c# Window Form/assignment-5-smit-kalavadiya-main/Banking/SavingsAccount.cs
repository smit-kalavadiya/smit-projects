using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class SavingsAccount : BankAccount
    {
        public int NumberOfDeposite { get; private set; }
        public SavingsAccount(decimal balance) : base(balance)
        {

        }
        public override string AccountType
        {
            get
            {
                return "Saving Account";
            }
        }
        public override void Deposite(decimal amount)
        {
            base.Deposite(amount);

            NumberOfDeposite++;
        }

        public override void Withdrawal(decimal amount)
        {
            if (amount > Balance)
            {
                throw new Exception("Insufficient Funds");
            }
            base.Withdrawal(amount);
        }
    }
}
