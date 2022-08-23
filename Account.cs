namespace Bank_Digicoins
{
    public class Account : IAccount
    {
        public double Balance { get; set; }
        public int Number { get; set; }
        public Status Status;
        public int Random(int number)
        {
            Random numberRandom = new Random();
            int numberAccount = numberRandom.Next(10000000, 99999999);
            return number = numberAccount;
        }
        public void Withdraw(double value)
        {
            if (value <= this.Balance)
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
            if (Status == Status.Open)
                if (value > 0)
                {
                    this.Balance += value;
                    Console.WriteLine("Deposito realizado com sucesso!");
                    Console.WriteLine($"Saldo atual da conta: {this.Balance}");
                }
                else
                {
                    Console.WriteLine("Impossível fazer depósito");
                    Console.WriteLine($"Saldo atual da conta R$" + this.Balance);
                }
            else
                Console.WriteLine("ERRO, sua conta atualmente está " + Status.Closer);
        }
        public void Transfer(Account account, double value)
        {
            if (Status == Status.Open)
            {
                if (value > 0)
                {
                    if (value <= this.Balance)
                    {
                        this.Balance -= value;
                        Console.WriteLine("Transfenrência realizada com sucesso!");
                        Console.WriteLine("Saldo da conta: R$" + this.Balance);
                        account.Balance += value;
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

        public void ShowBalance()
        {
            Console.WriteLine("O saldo atual da sua conta é: R$" + this.Balance);
        }

        public override string ToString()
        {
            return "Saldo da conta" + "\n" +
                    "Número da conta: " + Number + "\n" +
                    "Situação da conta: " + Status;

        }
    }
}