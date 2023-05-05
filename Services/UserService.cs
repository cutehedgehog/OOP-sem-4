using HabitTracker.Entities;
using HabitTracker.Managers;
using System;


namespace HabitTracker.Services
{
    internal class UserService
    {
        private string currEmail;
        private UserManager userManager = new UserManager();
        public string CurrEmail { get; set; }
        public void LogIn(string t_email, string t_password)
        {
            if (currEmail != null)
            {
                Console.WriteLine("Log out first!");
            }
            else
            {
                User tempUser = userManager.GetUser(t_email);
                if (tempUser == null)
                {
                    Console.WriteLine("No such user!");
                }
                else if(tempUser.Password == t_password)
                {
                    currEmail = t_email;
                }
                else
                {
                    Console.WriteLine("Wrong password!");
                }
            }
        }
        public void LogOut()
        {
            if (currEmail != null)
            {   
                currEmail = null;
            }
            else
            {
                Console.WriteLine("Log in first!");
            }
        }

        public void Register(string t_email, string t_name, string t_password)
        {
            userManager.AddUser(new User(t_email, t_name, t_password));
        }

        public void EditName(string t_email, string t_name)
        {
            if(userManager.GetUser(t_email) != null) {
                User tempUser = userManager.GetUser(t_email);
                tempUser.Name = t_name;
                userManager.EditUser(tempUser);
            }
        }
        public void EditPassword(string t_email, string t_password, string t_newPassword)
        {
            if (userManager.GetUser(t_email) != null)
            {
                User tempUser = userManager.GetUser(t_email);
                if(tempUser.Password == t_password)
                {
                    tempUser.Password = t_newPassword;
                    userManager.EditUser(tempUser);
                }
                else
                {
                    Console.WriteLine("Wrong password!");
                }
            }
        }
        public void RemoveUser(string t_email, string t_password)
        {
            if (userManager.GetUser(t_email) != null)
            {
                User tempUser = userManager.GetUser(t_email);
                if (tempUser.Password == t_password)
                {
                    userManager.RemoveUser(tempUser);
                    currEmail = null;
                }
                else
                {
                    Console.WriteLine("Wrong password!");
                }
            }
        }
    }
}
