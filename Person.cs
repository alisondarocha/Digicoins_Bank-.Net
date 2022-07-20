using System;

public class Person
{
    public string name {get; set;}
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
    public string Name
    {
        get{return name;}
        set{name = value;}
    }
}