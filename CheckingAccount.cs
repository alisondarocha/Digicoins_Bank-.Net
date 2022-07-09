using System;

public class CheckingAccount : IAccount
{
    private int Number { get; set; }
    private double Balance { get; set; }
    private Status Status;

    public CheckingAccount(Bank name, Customer client)
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
        if(Status == Status.Open)     
            if(value <= this.Balance)
            {
                this.Balance -= value;
                Console.WriteLine("Saque realizado");
                Console.WriteLine("-=-=-=-=-=-=-=-=-");
                Console.WriteLine("Saldo da conta: " + this.Balance);
            }
            else
                Console.WriteLine("ERRO! valor insuficiente");
        else
            Console.WriteLine("A conta se encontra: " + Status.Closer);
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
                Console.WriteLine("Impossível fazer depósito em valor negativo");
                Console.WriteLine("Saldo atual: " + this.Balance);
            }
        else
            Console.WriteLine("A conta se encontra: " + Status.Open);
    }
    public void Transfer(IAccount c2, double value)
    {
        if( Status == Status.Open)
        {
            if(value > 0)
                if(value <= this.Balance)
                {
                    this.Balance -= value;
                    Console.WriteLine("Transfenrência realizada com sucesso!");
                    Console.WriteLine("Saldo da conta: " + this.Balance);
                }
                else
                    Console.WriteLine("ERRO, saldo insuficiente!");
            else
                Console.WriteLine("Não é possível  transferir um valor negativo");
        }
        else
            Console.WriteLine("A conta está: " + Status.Closer);
    }
    public void ShowData(Customer client, Bank data)
    {
        Console.WriteLine("Cliente: " + client.Name);
        Console.WriteLine("Data de nascimento: " + client.Birthdate);
        Console.WriteLine("CPF: " + client.Cpf);
        Console.WriteLine("Número da conta: " + Number);
        Console.WriteLine("Situação da conta: " + Status);
        Console.WriteLine("Nome da instituição: " + data.Name);
        Console.WriteLine("Dados da instituição: " + data.SecurityData);
    }
}