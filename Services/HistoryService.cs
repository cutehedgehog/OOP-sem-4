using HabitTracker.Managers;
using HabitTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitTracker.Services
{
    class HistoryService
    {
        private string currEmail;
        private HistoryManager historyManager = new HistoryManager();
        public void AddUserRecord(Habit habit, DateTime t_dateTime)
        {
            historyManager.AddRecord(new Record(habit.Name, habit.Progress, habit.Progress >= habit.CompleteProgress, habit.UserEmail, t_dateTime));
        }

        public void ClearUserHistory(User t_user)
        {
            historyManager.ClearHistory(t_user.Email);
        }

        public double HabitMaxProgress(Habit t_habit)
        {
            return historyManager.MaxProgress(t_habit.Name, t_habit.UserEmail);
        }
        public int HabitLongestComplete(Habit t_habit)
        {
            return historyManager.LongestComplete(t_habit.Name, t_habit.UserEmail);
        }
    }
}
