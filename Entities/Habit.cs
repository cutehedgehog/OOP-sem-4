namespace HabitTracker
{
    class Habit
    {
        private string type;
        private string name;
        private double progress;
        private double completeProgress;
        private string userEmail;

        public string Type { get { return type; } set { type = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double Progress { get { return progress; } set { progress = value; } }
        public double CompleteProgress { get { return completeProgress; } set { completeProgress = value; } }
        public string UserEmail { get { return userEmail; } set { userEmail = value; } }

        public Habit()
        {
            type = null;
            name = null;
            progress = 0;
            completeProgress = 0;
            userEmail = null;   
        }
        public Habit(string t_type, string t_name, double t_progress, double t_completeProgress, string t_userEmail)
        {
            type = t_type;
            name = t_name;
            progress = t_progress;
            completeProgress = t_completeProgress;
            userEmail = t_userEmail;
        }
    }
}
