using System;
namespace lab11
{
    enum TypeBankAccount
    {
        Текущий,
        Сберегательный,
        Кредитный
    }
    internal class Program
    {      
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 11 главы\nУпражнение 11.1");
            BankAccountFactory factory = new BankAccountFactory();
            uint account1 = factory.CreateAccount();
            Console.WriteLine($"Создан банковский счет с номером счета: {account1}");
            uint account2 = factory.CreateAccount(2000, TypeBankAccount.Кредитный);
            Console.WriteLine($"Создан банковский счет с номером счета: {account2}");
            factory.CloseAccount(account2);
            Console.WriteLine($"Закрыт банковский счет с номером счета: {account2}");

            Console.WriteLine("\nДомашнее задание 11.1");
            Creator.CreateBuilding(100, 10, 50, 5);
            Creator.CreateBuilding(150, 15, 75, 7);
            Creator.PrintBuildingInfo();
            Creator.RemoveBuilding(1);
            Creator.PrintBuildingInfo();
            Console.ReadKey();
        }
    }
}
