using System;

public class AccountSavings : IAccount
{ 
    private double Balance { get; set; }
    private int Number { get; set; }
    private Status Status;

    public AccountSavings( Bank name, Customer client )
    {
        Status = Status.Open;
        Number = random(Number);
        this.Balance = 0;
    }
    private int random(int number)
    {
        Random numberRandom = new Random();
        int numberAccount = numberRandom.Next(10000000, 99999999);
        return number = numberAccount;
    }
    public void Withdraw(double value)
    {
        if(value <= this.Balance)
            {
                this.Balance -= value;
                Console.WriteLine("Saque realizado");
                Console.WriteLine("-=-=-=-=-=-=-=-=-");
                Console.WriteLine("Saldo da conta: R$" + this.Balance);
            }
        else
            Console.WriteLine("ERRO! valor insuficiente");
    }
    public void Deposit(double value)
    {
        if(Status == Status.Open)
            if(value > 0)
            {
                this.Balance += value;
                Console.WriteLine($"`Você depositou {value} em sua conta!");
            }
            else
            {
                Console.WriteLine("Impossível fazer depósito");
                Console.WriteLine("Saldo atual: R$" + this.Balance);
            }
        else
            Console.WriteLine("ERRO, sua conta atualmente está " + Status.Closer);
    }
    public void Transfer(IAccount c2, double value)
    {
        if(Status == Status.Open)
        {
            if(value > 0 )
            {
                if(value <= this.Balance)
                {
                    this.Balance -= value;
                    Console.WriteLine("Transfenrência realizada com sucesso!");
                    Console.WriteLine("Saldo da conta: R$" + this.Balance);
                }
                else
                    Console.WriteLine("ERRO, saldo insuficiente!");
            }
            else
                Console.WriteLine("Não é possível transferir um valor negativo");
        }
        else 
            Console.WriteLine("ERRO, sua conta atualmente está " + Status.Closer);
    }

    private string ShowBalance()
    {
        return "O saldo atual da sua conta é: R$" + this.Balance;
    }

    public override string ToString()
    {
        return  "Tipo de conta: Saving" + "\n" +
                "Número da conta: " + Number + "\n" +
                "Situação da conta: " + Status + 
                "\n" + ShowBalance();
                
    }    
}