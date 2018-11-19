using System;

namespace KTT
{
    class Program
    {
        static void Main(string[] args)
        {
            IsUserExist();
            DisplayUser();
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

        static void DisplayUsers() 
        {
            var users = (new UserManager(new UserRepo())).GetUsersByName();
            foreach(var user in users)
            {
                Console.WriteLine($"{user.Id} - {user.Name}");
            }
        }

        static void DisplayUser()
        {
            var user = (new UserManager(new UserRepo())).FindUserById();
            Console.WriteLine($"{user?.Id} - {user?.Name}");
        }

        static void IsUserExist()
        {
            if ((new UserManager(new UserRepo())).IsUserExist())
                Console.WriteLine("Found user!");
            else
                Console.WriteLine("User not found!");
        }
    }
}
