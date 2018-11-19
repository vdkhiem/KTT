using System;

public class DatabaseMYSQL : Database
{
    public override bool PersistToMSSQL(string name)
    {
        base.PersistToMSSQL(name);
        Console.WriteLine($"PXVendorMaint: Persist to MSSQL {name}");
        return true;
    }
}