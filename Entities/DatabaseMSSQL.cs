using System;

public class DatabaseMSSQL : Database
{
    public override bool PersistToFile(string name)
    {
        base.PersistToFile(name);
        Console.WriteLine($"PXSupplierMaint: Persist to file {name}");
        return true;
    }
}