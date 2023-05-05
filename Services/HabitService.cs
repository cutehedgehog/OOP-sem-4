using HabitTracker.Managers;
using System;


namespace HabitTracker.Services
{
    class HabitService
    {
        private HabitManager habitManager = new HabitManager();
        public void AddUserHabit(string t_type, string t_name, double t_progress, double t_completeProgress, string t_userEmail)
        {
            habitManager.AddHabit(new Habit(t_type, t_name, t_progress, t_completeProgress, t_userEmail));
        }

        public void RemoveHabit(string t_type, string t_name, double t_progress, double t_completeProgress, string t_userEmail)
        {
            habitManager.RemoveHabit(new Habit(t_type, t_name, t_progress, t_completeProgress, t_userEmail));
        }

        public void EditProgress(string t_name, double t_progress, string t_userEmail)
        {
            Habit tempHabit = habitManager.GetHabit(t_userEmail, t_name);
            if (tempHabit != null)
            {
                tempHabit.Progress = t_progress;
                habitManager.EditHabit(tempHabit);
            }
            else
            {
                Console.WriteLine("No such habit!");
            }
        }
        public void EditCompleteProgress(string t_name, double t_completeProgress, string t_userEmail)
        {
            Habit tempHabit = habitManager.GetHabit(t_userEmail, t_name);
            if (tempHabit != null)
            {
                tempHabit.CompleteProgress = t_completeProgress;
                habitManager.EditHabit(tempHabit);
            }
            else
            {
                Console.WriteLine("No such habit!");
            }
        }
    }
}
