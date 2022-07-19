using System;

public class Program
{
    static void Main(string[] args)
    {
        var customer1 = new Customer("Júlio", DateOnly.Parse("2000/07/09") , "538.123.141-40", Gender.Male);
        var customer2 = new Customer("Júlia", DateOnly.Parse("1990/01/06"), "896-123-543-10", Gender.Female);

        var digicoinBank = new Bank();

        var accountSaving1 = new AccountSavings(digicoinBank, customer1);
        var accountChecking1 =  new CheckingAccount (digicoinBank, customer2);

        Console.WriteLine(customer1);
        Console.WriteLine(accountSaving1);
        Console.WriteLine(digicoinBank);
        Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=- \n");

        accountChecking1.ShowData(customer2, digicoinBank);
    }
}