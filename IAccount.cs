using System;

public interface IAccount
{
    
    public void Withdraw(double value);
    public void Deposit(double value);
    public void Transfer(IAccount c2, double value);
}