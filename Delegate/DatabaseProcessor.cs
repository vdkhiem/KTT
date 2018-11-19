using System;
public class DatabaseProcessor
{
    public bool Process(string a, Func<string, bool> saveToDB)
    {
        return saveToDB(a);
    }
}