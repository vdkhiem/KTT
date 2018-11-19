using System;
using System.Collections.Generic;
using System.Linq;

public class UserManager 
{
    private UserRepo userRepo;
    public UserManager (UserRepo userRepo)
    {
        this.userRepo = userRepo;
    }

    public IList<User> GetUsersByName()
    {
        var users = userRepo.GetBooks();
        var selectedUsers = users.Where(p => p.Name.Contains("User 1")).ToList();
        return selectedUsers;
    } 

    public User FindUserById()
    {
        var users = userRepo.GetBooks();
        var selectedUser = users.FirstOrDefault(p => p.Name.Contains("User 5"));
        return selectedUser;
    }

    public bool IsUserExist() => userRepo.GetBooks().Any(p => p.Name.Contains("User 5"));
}