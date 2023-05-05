using System;
using System.Collections.Generic;
using HabitTracker.Entities;

namespace HabitTracker.Managers
{
    class UserManager
    {
        List<User> users = new List<User>();

        public void AddUser(User t_user)
        {
            if (users.Exists(x => x.Email == t_user.Email))
            {
                Console.WriteLine("This user already exists!");
            }
            else
            {
                users.Add(t_user);
            }
        }

        public void RemoveUser(User t_user)
        {
            if (users.Exists(x => x.Email == t_user.Email))
            {
                users.Remove(t_user);
            }
            else
            {
                Console.WriteLine("No such user!");
            }
        }

        public void EditUser(User t_user)
        {
            if (users.Exists(x => x.Email == t_user.Email))
            {
                int index = users.FindLastIndex(x => x.Email == t_user.Email);
                users.RemoveAt(index);
                users.Add(t_user);
            }
            else
            {
                Console.WriteLine("No such user!");
            }
        }

        public List<User> GetAllUsers()
        {
            return users;
        }
        public User GetUser(string t_email)
        {
            if (users.Exists(x => x.Email == t_email))
            {
                return users.Find(x => x.Email == t_email);
            }
            else
            {
                return null;
            }
        }

    }
}
