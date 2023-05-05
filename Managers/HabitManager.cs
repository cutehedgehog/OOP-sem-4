using HabitTracker.Entities;
using System;
using System.Collections.Generic;

namespace HabitTracker.Managers
{
    class HabitManager
    {
        List<Habit> habits = new List<Habit>();
        UserManager userManager = new UserManager();

        public void AddHabit(Habit t_habit)
        {
            if (userManager.GetUser(t_habit.UserEmail) != null && !habits.Exists(x=> x.Name == t_habit.Name && x.UserEmail == t_habit.UserEmail))
            {
                habits.Add(t_habit);
            }
            else
            {
                Console.WriteLine("No such user!");
            }
        }

        public void RemoveHabit(Habit t_habit)
        {
            if (habits.Exists(x => x.Name == t_habit.Name && x.UserEmail == t_habit.UserEmail))
            {
                habits.Remove(t_habit);
            }
            else
            {
                Console.WriteLine("No such habit!");
            }
        }

        public void EditHabit(Habit t_habit)
        {
            if (habits.Exists(x => x.Name == t_habit.Name && x.UserEmail == t_habit.UserEmail))
            {
                int index = habits.FindLastIndex(x => x.Name == t_habit.Name && x.UserEmail == t_habit.UserEmail);
                habits.RemoveAt(index);
                habits.Add(t_habit);
            }
            else
            {
                Console.WriteLine("No such habit!");
            }
        }

        public List<Habit> GetUserHabits(string t_email)
        {
            List<Habit> userHabits = new List<Habit>();
            foreach(var habit in habits)
            {
                if(habit.UserEmail == t_email)
                {
                    userHabits.Add(habit);
                }
            }
            return userHabits;
        }
        public Habit GetHabit(string t_email, string t_name)
        {
            foreach (var habit in habits)
            {
                if (habit.UserEmail == t_email && habit.Name == t_name)
                {
                    return habit;
                }
            }
            return null;
        }
    }
}
