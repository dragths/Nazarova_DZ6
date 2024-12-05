using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    public class BankChet1
    {
        
        private static int accountNumberCounter = 0; 
        private string accountNumber; 
        private decimal balance; 
        private AccountType accountType; 

   
        public BankChet1(AccountType accountType)
        {
            this.accountNumber = GenerateAccountNumber();
            this.balance = 0; 
            this.accountType = accountType;
        }

        private static string GenerateAccountNumber()
        {
            accountNumberCounter++;
            return "ACC" + accountNumberCounter.ToString("D6");
        }

        public void SetBalance(decimal balance)
        {
            this.balance = balance;
        }

        public void PrintBankChet()
        {

            Console.WriteLine($"Номер счета {accountNumber}");
            Console.WriteLine($"Баланс {balance}");
            Console.WriteLine($"Тип банковского счета {accountType}");
        }
    }

}
