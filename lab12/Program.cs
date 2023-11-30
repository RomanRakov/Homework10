using System;
namespace lab12
{
    enum TypeBankAccount
    {
        Текущий,
        Сберегательный,
        Кредитный
    }
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Лабораторная 12 главы\nУпражнение 12.1");
            BankAccount account1 = new BankAccount(1000, TypeBankAccount.Текущий);
            BankAccount account2 = new BankAccount(5000, TypeBankAccount.Сберегательный);
            Console.WriteLine($"Банковский аккаунт 1 == Банковский аккаунт 2: {account1 == account2}\n" +
                $"Банковский аккаунт 1 != Банковский аккаунт 2: {account1 != account2}\n" +
                $"Банковский аккаунт 1:\n{account1}" +
                $"Банковский аккаунт 2:\n{account2}");

            Console.WriteLine("Упражнение 12.2");
            var rational1 = new RationalNumber(4, 5);
            var rational2 = new RationalNumber(2, 5);
            Console.WriteLine($"Рациональное число 1: {rational1}\n" +
                $"Рациональное число 2: {rational2}\n" +
                $"Рациональное число 1 == Рациональное число 2: {rational1 == rational2}\n" +
                $"Рациональное число 1 != Рациональное число 2: {rational1 != rational2}\n" +
                $"Рациональное число 1 < Рациональное число 2: {rational1 < rational2}\n" +
                $"Рациональное число 1 > Рациональное число 2: {rational1 > rational2}\n" +
                $"Рациональное число 1 <= Рациональное число 2: {rational1 <= rational2}\n" +
                $"Рациональное число 1 >= Рациональное число 2: {rational1 >= rational2}\n" +
                $"Рациональное число 1 + Рациональное число 2: {rational1 + rational2}\n" +
                $"Рациональное число 1 - Рациональное число 2: {rational1 - rational2}\n" +
                $"Рациональное число 1 * Рациональное число 2: {rational1 * rational2}\n" +
                $"Рациональное число 1 / Рациональное число 2: {rational1 / rational2}\n" +
                $"Рациональное число 1 % Рациональное число 2: {rational1 % rational2}\n" +
                $"Рациональное число 1++: {++rational1}\n" +
                $"Рациональное число 2--: {--rational2}\n");

            Console.WriteLine("Домашнее задание 12.1");
            var complex1 = new ComplexNumber(2, 3);
            var complex2 = new ComplexNumber(4, 5);
            Console.WriteLine($"Первое комплексное число: {complex1}\nВторое комплексное число: {complex2}");
            var sum = complex1.Sum(complex1,complex2);
            Console.WriteLine($"Сумма: {sum}");
            var product = complex1.Multiplication(complex1, complex2);
            Console.WriteLine($"Умножение: {product}");
            var difference = complex1.Subtraction(complex1, complex2);
            Console.WriteLine($"Вычитание: {difference}");
            var isEqual = complex1.Equals(complex1, complex2);
            Console.WriteLine($"Комплекнсые числа равны: {isEqual}");

            Console.WriteLine("\nДомашнее задание 12.2");
            Book[] books = new Book[]
            {
                new Book("Книга 1", "Автор 2", "Издательство 3"),
                new Book("Книга 2", "Автор 3", "Издательство 1"),
                new Book("Книга 3", "Автор 1", "Издательство 2")
            };
            var bookContainer = new BookContainer(books);
            bookContainer.SortBooks((book1, book2) => book1.Title.CompareTo(book2.Title));
            Console.WriteLine("Сортировано по названию:");
            foreach (var book in books)
            {
                Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Издательство: {book.Publisher}");
            }
            bookContainer.SortBooks((book1, book2) => book1.Author.CompareTo(book2.Author));
            Console.WriteLine("Сортировано по автору:");
            foreach (var book in books)
            {
                Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Издательство: {book.Publisher}");
            }      
            bookContainer.SortBooks((book1, book2) => book1.Publisher.CompareTo(book2.Publisher));
            Console.WriteLine("Сортировано по издательству:");
            foreach (var book in books)
            {
                Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Издательство: {book.Publisher}");
            }
            Console.ReadKey();
        }
    }
}