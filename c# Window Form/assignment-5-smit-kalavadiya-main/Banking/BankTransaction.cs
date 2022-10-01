using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class BankTransaction
    {

        public BankTransaction(TransactionType type, decimal amount)
        {
            this.Type = type;
            this.Amount = amount;
        }

        public TransactionType Type { get; set; }

        public decimal Amount { get; set; }

        public string DisplayAmount
        {
            get
            {
                return Type.ToString() + ": " + Amount.ToString("c");
            }
        }
    }
}
