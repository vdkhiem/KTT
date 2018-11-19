using System;

public class Database
{
    public virtual bool PersistToFile(string name)
    {
        Console.WriteLine($"Persist to file {name}");
        return true;
    }

    public virtual bool PersistToMSSQL(string name)
    {
        Console.WriteLine($"Persist to MSSQL {name}");
        return true;
    }

    public virtual bool PersistToMySQL(string name)
    {
        Console.WriteLine($"Persist to MSSQL {name}");
        return true;
    }
}