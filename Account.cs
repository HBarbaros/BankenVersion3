class Account
{
    public int AccountNumber { get; private set; }
    private decimal balance;

    public Account(int accountNumber)
    {
        AccountNumber = accountNumber;
        balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Successfully deposited {amount}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid amount.");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current balance: {balance}");
    }
}