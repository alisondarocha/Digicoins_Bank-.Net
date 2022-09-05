using System;
using Bank_Digicoins;

public class AccountSaving : Account
{ 
    public AccountSaving (Bank bank, Customer customer)
    {
        Status = Status.Open;
        Number = Random(Number);
        this.Balance = 0;
    }    
}    
