using System;

namespace KTT
{
    class Program
    {
        static void Main(string[] args)
        {
            FindAllDerivedClasses();
        }

        static void PrintDelegateImplementation()
        {
            var database = new Database();
            var databaseProcessor = new DatabaseProcessor();
            
            Func<string, bool> sumHanlder = database.PersistToFile;
            sumHanlder += database.PersistToMSSQL;
            sumHanlder += database.PersistToMySQL;

            databaseProcessor.Process("test", sumHanlder);
        }

        static void FindAllDerivedClasses() => ReflectionUtilities.FindAllDerivedClasses();

    }
}
