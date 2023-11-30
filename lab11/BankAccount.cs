using System;
using System.Collections.Generic;
namespace lab11
{
    internal class BankAccount
    {
        internal uint number;
        private double balance;
        private TypeBankAccount type;
        internal Queue<BankTransaction> transactions = new Queue<BankTransaction>();
        internal BankAccount()
        {
            this.number = this.GenerateNumber();
        }
        internal BankAccount(double balance)
        {
            this.number = this.GenerateNumber();
            this.balance = balance;
        }
        internal BankAccount(TypeBankAccount type)
        {
            this.number = this.GenerateNumber();
            this.type = type;
        }
        internal BankAccount(double balance, TypeBankAccount type)
        {
            this.number = this.GenerateNumber();
            this.balance = balance;
            this.type = type;
        }
        private uint GenerateNumber()
        {
            return (uint)DateTime.Now.Ticks;
        }
        public void Transfer(BankAccount recipient, double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Недостаточно средств");
                return;
            }
            else
            {
                balance -= amount;
                recipient.balance += amount;
                transactions.Enqueue(new BankTransaction(amount));
                Console.WriteLine("Перевод успешно выполнен");
            }
        }
        public void Info()
        {
            Console.WriteLine($"Номер счета: {number}\nБаланс: {balance}\nТип счета: {type}\n");
        }
    }
}
