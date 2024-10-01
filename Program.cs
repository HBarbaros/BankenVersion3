using System;

namespace Bank
{
    class Program
    {
        private static Customer customer;
        private static Account account;

        public static void Main(string[] args)
        {
            if (Login())
            {
                ShowMenu();
            }
            else
            {
                Console.WriteLine("Invalid credentials. Please try again.");
            }
        }

        public static bool Login()
        {
            Console.WriteLine("Welcome to the Bank!");

            while (true)
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name cannot be empty. Please try again.");
                    continue;
                }

                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(password))
                {
                    Console.WriteLine("Password cannot be empty. Please try again.");
                    continue;
                }

                customer = new Customer(name, password);
                account = new Account(1);
                Console.WriteLine($"Account created for {customer.Name}.");
                return true;
            }
        }

        public static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Deposit();
                        break;

                    case "2":
                        Withdraw();
                        break;

                    case "3":
                        CheckBalance();
                        break;

                    case "4":
                        Console.WriteLine("Thank you! Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        public static void Deposit()
        {
            Console.Write("Enter amount to deposit: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
            {
                account.Deposit(depositAmount);
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
            }
        }

        public static void Withdraw()
        {
            Console.Write("Enter amount to withdraw: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
            {
                account.Withdraw(withdrawAmount);
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
            }
        }

        public static void CheckBalance()
        {
            account.CheckBalance();
        }
    }

}
