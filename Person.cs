using System;

public class Person
{
    public string Name { get; set; }
    public string Cpf { get; set; }
    public DateOnly Birthdate;
    public Gender Gender;
    
    public Person ( DateOnly birthdate, Gender gender, string name, string cpf )
    {
        Birthdate = birthdate;
        Gender = gender;
        Name = name;
        Cpf = cpf;
    }
}