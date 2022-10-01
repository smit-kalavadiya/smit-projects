using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class BankAccount
    {
        public List<BankTransaction> Transactions { get; private set; }
        public string AccountNumber { get; protected set; }

        public virtual string AccountType { get; set; }

        public BankAccount(decimal balance)
        {
            Balance = balance;
            Transactions = new List<BankTransaction>();
        }
        public decimal Balance { get; private set; }

        public virtual void Deposite(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Can't deposite negative amount");
            }
            Balance += amount;
            Transactions.Add(new BankTransaction(TransactionType.Deposit, amount));
        }
        public virtual void Withdrawal(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Can't widthdraw negative amount");
            }
            Balance -= amount;

            Transactions.Add(new BankTransaction(TransactionType.Withdrawal, amount));

        }
    }
}
