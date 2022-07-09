using System;
using System.Diagnostics;

public class Bank
{
    public string Name { get; set; }
    public string SecurityData { get; set; }

    public Bank (string name)
    {
        this.Name = name;
        this.SecurityData = uuidEin(SecurityData);
    }
    private string uuidEin(string sender)
    {
        Guid uuid = Guid.NewGuid();
        string uuidInt = uuid.ToString();
        return sender = uuidInt;
    }
    public override string ToString()
    {
        return "Nome da instituição: " + Name + "\n" + 
               "Dados da instituição: " + SecurityData;
    }
}