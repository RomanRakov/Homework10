using System;
namespace lab11
{
    internal class BankTransaction
    {
        public readonly DateTime Date;
        public readonly double Amount;
        public BankTransaction(double amount)
        {
            Date = DateTime.Now;
            Amount = amount;
        }
    }
}
