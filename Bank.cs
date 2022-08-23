using System;
using System.Diagnostics;

public sealed class Bank
{
    public string Name = "Digicoin Bank";
    public Guid SecurityData {get; set;} = Guid.NewGuid();

    public override string ToString()
    {
        return "Nome da instituição: " + Name + "\n" + 
               "Dados da instituição: " + SecurityData;
    }
}