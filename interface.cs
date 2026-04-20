using System;

interface IBank {
    void Deposit(double amount);
    void Withdraw(double amount);
}

class BankAccount : IBank {
    private double balance;

    // Constructor to set initial balance
    public BankAccount(double initialBalance) {
        balance = initialBalance;
    }

    public void Deposit(double amount) {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public void Withdraw(double amount) {
        if (amount <= balance) {
            balance -= amount;
            Console.WriteLine("Withdraw: " + amount);
        } else {
            Console.WriteLine("Insufficient balance");
        }
    }

    public void ShowBalance() {
        Console.WriteLine("Current Balance: " + balance);
    }

    public static void Main(string[] args) {
        BankAccount ba1 = new BankAccount(10000);

        ba1.Deposit(4000);
        ba1.Withdraw(2000);
        ba1.ShowBalance();
    }
}
