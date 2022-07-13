using System;

public class Customer : Person
{
    public Customer(string name, DateOnly birthdate, string cpf, Gender gender)
                    : base( birthdate, gender, name, cpf)
    {
       
    }
    public override string ToString()
    {
        return "Nome: " + Name + "\n" +
        "Data de nascimento: " + Birthdate + "\n" +
        "CPF: " + Cpf;
    }
}
