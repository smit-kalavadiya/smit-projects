using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class ChequingAccount : BankAccount
    {
        public decimal TansactionFee { get; protected set; }
        public int NumberOfWithdrawl { get; private set; }

        public override string AccountType
        {
            get
            {
                return "Chequing Account";
            }
        }
        public ChequingAccount(decimal balance) : base(balance)
        {
            TansactionFee = 1;
        }
        public ChequingAccount(decimal balance, string accountNumber) : base(balance)
        {
            this.AccountNumber = accountNumber;
            TansactionFee = 1;
        }
        public override void Withdrawal(decimal amount)
        {
            if ((amount + TansactionFee) > Balance)
            {
                throw new Exception("insufficient funds after transaction fee");
            }
            base.Withdrawal(amount + TansactionFee);
            NumberOfWithdrawl++;
        }
    }
}
