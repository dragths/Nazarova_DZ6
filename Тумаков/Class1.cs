using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    public enum AccountType
    {
        Saving,
        Tekyshi,
    }
    public class BankChet
    {
        
        private string accountNumber;
        private decimal balance;
        private AccountType accountType;

        public void  BankChetDetails(string accountNumber, decimal balance, AccountType accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.accountType = accountType;
        }

        public void PrintBankChet()
        {
            Console.WriteLine($"Номер счета {accountNumber}");
            Console.WriteLine($"Баланс {balance}");
            Console.WriteLine($"Тип банковского счета {accountType}");
        }
       
    }

}
