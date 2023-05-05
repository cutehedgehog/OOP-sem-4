using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitTracker.Entities;

namespace HabitTracker.Managers
{
    class HistoryManager
    {
        List<Record> records = new List<Record>();

        public void AddRecord(Record t_record)
        {
            if (records.Exists(x => x.UserEmail == t_record.UserEmail && x.Name == t_record.Name && x.Date == t_record.Date))
            {
                Console.WriteLine("This record already exists!");
            }
            else
            {
                records.Add(t_record);
            }
        }
        public void ClearHistory(string t_email) 
        {
            List<Record> newRecords = new List<Record>();
            foreach (var record in records) 
            { 
                if (record.UserEmail != t_email)
                {
                    newRecords.Add(record);
                }
            }
            records = newRecords;
        }
        public double MaxProgress(string t_name, string t_userEmail)
        {
            double maxProgress = 0;
            foreach (var record in records)
            {
                if (record.UserEmail == t_userEmail && record.Name == t_name && record.Progress > maxProgress)
                {
                    maxProgress = record.Progress;
                }
            }
            return maxProgress;
        }
        public int LongestComplete(string t_name, string t_userEmail)
        {
            int count = 0;
            foreach (var record in records)
            {
                if(record.UserEmail == t_userEmail && record.Name == t_name && record.IsComplete)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
