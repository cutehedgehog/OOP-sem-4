using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitTracker.Entities
{
    class Record
    {
        private string name;
        private double progress;
        private bool isComplete;
        private string userEmail;
        private DateTime date;

        public string Name { get { return name; } set { name = value; } }
        public double Progress { get { return progress; } set { progress = value; } }
        public bool IsComplete { get { return isComplete; } set { isComplete = value; } }
        public string UserEmail { get { return userEmail; } set { userEmail = value; } }
        public DateTime Date { get { return date; } set { date = value; } }

        public Record()
        {
            name = null;
            progress = 0;
            isComplete = false;
            userEmail = null;
            date = DateTime.MinValue;
        }
        public Record(string t_name, double t_progress, bool t_isComplete, string t_userEmail, DateTime t_dateTime)
        {
            name = t_name;
            progress = t_progress;
            isComplete = t_isComplete;
            userEmail = t_userEmail;
            date = t_dateTime;
        }
    }
}
