using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class BankAccountFactory
    {
        private Dictionary<uint, BankAccount> accounts = new Dictionary<uint, BankAccount>();
        internal uint CreateAccount()
        {
            BankAccount account = new BankAccount();
            accounts.Add(account.number, account);
            return account.number;
        }
        internal uint CreateAccount(double balance)
        {
            BankAccount account = new BankAccount(balance);
            accounts.Add(account.number, account);
            return account.number;
        }
        internal uint CreateAccount(TypeBankAccount type)
        {
            BankAccount account = new BankAccount(type);
            accounts.Add(account.number, account);
            return account.number;
        }
        internal uint CreateAccount(double balance, TypeBankAccount type)
        {
            BankAccount account = new BankAccount(balance, type);
            accounts.Add(account.number, account);
            return account.number;
        }
        internal void CloseAccount(uint accountNumber)
        {
            accounts.Remove(accountNumber);
        }
    }
}

