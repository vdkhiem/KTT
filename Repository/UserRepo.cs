using System;
using System.Collections.Generic;

public class UserRepo
{
    public IEnumerable<User> GetBooks()
    {
        return new List<User>()
        {
            new User() {Id = 1, Name = "User 1"},
            new User() {Id = 2, Name = "User 1"},
            new User() {Id = 3, Name = "User 3"},
        };
    }
}