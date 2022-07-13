using System;
using System.Diagnostics;

public class Bank
{
    public string Name { get; set; }
    public Guid SecurityData = Guid.NewGuid();

    public Bank (string name)
    {
        this.Name = name;
    }
   
    public override string ToString()
    {
        return "Nome da instituição: " + Name + "\n" + 
               "Dados da instituição: " + SecurityData;
    }
}