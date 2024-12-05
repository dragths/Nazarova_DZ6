using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    internal class Program
    {
        static void task1()
        {
            /* Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
            банковского счета (использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
            доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и
            вывести информацию об объекте класса на печать.*/
            Console.WriteLine("Упражнение 7.1");
            BankChet myAccount = new BankChet();
            Console.Write("Введите номер счета: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Введите баланс: ");
            decimal.TryParse(Console.ReadLine(), out var balance);

            Console.WriteLine("Выберите тип счета: ");
            Console.WriteLine("0 - Сберегательный");
            Console.WriteLine("1 - Расчетный");
            int.TryParse(Console.ReadLine(), out var accountTypeInput);
            AccountType accountType = (AccountType)accountTypeInput;

            myAccount.BankChetDetails(accountNumber, balance, accountType);

            myAccount.PrintBankChet();
        }
        static void task2()
        {
            /*Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
            номер счета генерировался сам и был уникальным. Для этого надо создать в классе
            статическую переменную и метод, который увеличивает значение этого переменной.*/
            Console.WriteLine("Упражнение 7.2");
            Console.WriteLine("Выберите тип счета: ");
            Console.WriteLine("0 - Сберегательный");
            Console.WriteLine("1 - Расчетный");
            int.TryParse(Console.ReadLine(), out var accountTypeInput);
            AccountType accountType = (AccountType)accountTypeInput;

            BankChet1 myAccount = new BankChet1(accountType);

            Console.Write("Введите баланс: ");
            decimal.TryParse(Console.ReadLine(), out var balance);
            myAccount.SetBalance(balance);

            myAccount.PrintBankChet();
        }
        static void task3()
        {
            /*Добавить в класс счет в банке два метода: снять со счета и положить на
            счет. Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
            положительного результата изменяет баланс.*/
            Console.WriteLine("Упражнение 7.3");
            Console.WriteLine("Выберите тип счета: ");
            Console.WriteLine("0 - Сберегательный");
            Console.WriteLine("1 - Расчетный");
            int.TryParse(Console.ReadLine(), out var accountTypeInput);
            AccountType accountType = (AccountType)accountTypeInput;

            BankChet2 myAccount = new BankChet2(accountType);
            Console.Write("Введите начальный баланс: ");
            decimal.TryParse(Console.ReadLine(), out var initialBalance);
            myAccount.SetBalance(initialBalance);

            myAccount.PrintBankChet();

            Console.Write("Введите сумму для внесения: ");
            decimal.TryParse(Console.ReadLine(), out var depositAmount);
            myAccount.Deposit(depositAmount);

            Console.Write("Введите сумму для снятия: ");
            decimal.TryParse(Console.ReadLine(), out var withdrawAmount );
            myAccount.Withdraw(withdrawAmount);

            myAccount.PrintBankChet();
        }
        static void task4()
        {
            /*Реализовать класс для описания здания (уникальный номер здания,
            высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
            предусмотреть методы для заполнения полей и получения значений полей для печати.
            Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
            квартир на этаже и т.д.*/
            Console.WriteLine("ДЗ 7.1");
            Building building = new Building();
            Console.Write("Введите высоту здания (в метрах): ");
            double.TryParse(Console.ReadLine(), out var height);
            building.SetHeight(height);

            Console.Write("Введите этажность здания: ");
            int.TryParse(Console.ReadLine(), out var floors);
            building.SetFloors(floors);

            Console.Write("Введите общее количество квартир: ");
            int.TryParse(Console.ReadLine(), out var apartments);
            building.SetApartments(apartments);

            Console.Write("Введите количество подъездов: ");
            int.TryParse(Console.ReadLine(), out var entrances);
            building.SetEntrances(entrances);

           
            building.PrintBuildingDetails();

        }
        static void Main(string[] args)
        {
            task1();
            task2();    
            task3();
            task4();

        }
    }
}
