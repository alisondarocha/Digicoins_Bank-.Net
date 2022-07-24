using System;

public class Program
{
    static void Main(string[] args)
    {
        var customer1 = new Customer("Júlio", DateOnly.Parse("2000/07/09") , "538.123.141-40", Gender.Male);
        var customer2 = new Customer("Júlia", DateOnly.Parse("1990/01/06"), "896-123-543-10", Gender.Female);

        var digicoinBank = new Bank();

        var accountSavingCustomer1 = new AccountSavings(digicoinBank, customer1);
        var checkingAccountCustomer2 =  new CheckingAccount (digicoinBank, customer2);
        var accountSavingCustomer2 = new AccountSavings(digicoinBank, customer2);

        Console.WriteLine(digicoinBank);
        Console.WriteLine(customer1);
        Console.WriteLine(accountSavingCustomer1);
        
        Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=- \n");
        Console.WriteLine(customer2);
        Console.WriteLine(checkingAccountCustomer2);     
        Console.WriteLine(accountSavingCustomer2);

        Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=- \n");
        accountSavingCustomer2.Deposit(500);
        accountSavingCustomer2.Withdraw(200);
    }
}