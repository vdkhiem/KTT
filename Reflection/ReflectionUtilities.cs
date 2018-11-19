using System;

public class ReflectionUtilities
{
    public static void FindAllDerivedClasses()
    {
        Console.WriteLine("Find all derived classes of Database");
        var derivedClasses = typeof(Database).Assembly.GetTypes();
        foreach (var item in derivedClasses)
        {
            if (item.IsSubclassOf(typeof(Database)))
            {
                Console.WriteLine("{0}", item);
                var graph = (Database)Activator.CreateInstance(item);
                graph.PersistToFile("Test");
            }
        }
    }
}
