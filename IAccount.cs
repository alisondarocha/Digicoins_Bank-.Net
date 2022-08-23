using System;
using Bank_Digicoins;

public interface IAccount
{
    public void Withdraw(double value);
    public void Deposit(double value);
    public void Transfer(Account account, double value);
}