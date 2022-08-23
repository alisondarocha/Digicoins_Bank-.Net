using System;
using Bank_Digicoins;

public class CheckingAccount : Account
{
    public CheckingAccount(Bank bank, Customer customer)
    {
        Status = Status.Open;
        Number = Random(Number);
        this.Balance = 0;
    }
}