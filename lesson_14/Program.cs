//Створіть новий клас Account, що буде означати банківський рахунок.
//Кожен рахунок має свою назву та початкову сумму грошей на рахунку.
//Стан рахунку не може бути менше за 0.
//Реалізувати можливість додавати гроші на рахунок та віднімати гроші з рахунку.
//Реалізувати можливість отримати поточний стан рахунку, але не змінювати його напряму.

namespace lesson_14
{
    internal class Program
    {
        static void Main()
        {
            Account account1 = new("Name 1", 15.00);
            Account account2 = new("Name 2", 1000000.00);

            account1.Withdrawal(20);
            account1.Deposit(100);
            account1.PrintBalance();

            account2.Withdrawal(20);
            account2.Deposit(100);
            account2.PrintBalance();
        }
    }

    class Account
    {
        private readonly string _name;
        private double _balance;

        public Account(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string Name
        {
            get { return _name; }
        }

        public double Balance
        {
            get { return _balance; }
            set {
                if (value >= 0)
                {
                    _balance = value;
                    return;
                }
                Console.WriteLine("Balance can't be less than 0");
            }
        }

        public void Withdrawal(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Name: {Name}\nBalance: {Balance}");
        }
    }
}
