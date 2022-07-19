using System;

public class Person
{
    public string Name { get; set; }
    private string cpf;
    public DateOnly Birthdate;
    public Gender Gender;

    public Person ( DateOnly birthdate, Gender gender, string name, string cpf )
    {
        Birthdate = birthdate;
        Gender = gender;
        Name = name;
        Cpf = cpf;
    }
    public string Cpf
    {
        get{return cpf;}
        set{cpf = value;}
    }
}