using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EisenhowerCore
{

    public class TodoMatrix
    {
        public bool IsImportant { get; set; }
        public enum QuarterType
        {
            ImportantUrgent, ImportantNotUrgent, NotImportantUrgent, NotImportantNotUrgent
        }

        public Dictionary<QuarterType, TodoQuarter> TodoQuarters = new Dictionary<QuarterType, TodoQuarter>();

        public TodoMatrix()
        {
            TodoQuarters[QuarterType.ImportantUrgent] = new TodoQuarter();
            TodoQuarters[QuarterType.ImportantNotUrgent] = new TodoQuarter();
            TodoQuarters[QuarterType.NotImportantUrgent] = new TodoQuarter();
            TodoQuarters[QuarterType.NotImportantNotUrgent] = new TodoQuarter();
        }


        public Dictionary<QuarterType, TodoQuarter> GetQuarters()
        {
            return TodoQuarters;
        }

        public TodoQuarter GetQuarter(QuarterType status)
        {
            return TodoQuarters[status];
        }

        public void AddItem(String title, DateTime deadline, bool IsImportant)
        {
            if (IsImportant == false)
            {
                if ((deadline - DateTime.Now).TotalDays > 3)
                {
                    TodoQuarters[QuarterType.NotImportantNotUrgent].AddItem(title, deadline);
                }
                else
                {
                    TodoQuarters[QuarterType.NotImportantUrgent].AddItem(title, deadline);
                }
            }
            else
            {
                if ((deadline - DateTime.Now).TotalDays > 3)
                {
                    TodoQuarters[QuarterType.ImportantNotUrgent].AddItem(title, deadline);
                }
                else
                {
                    TodoQuarters[QuarterType.ImportantUrgent].AddItem(title, deadline);
                }
            }
        }

        public void ArchiveItems()
        {
            foreach (TodoQuarter quarter in TodoQuarters.Values)
            {
                quarter.GetItems().RemoveAll(item => item.IsDone);
            }
        }

        public static void SaveItems(List<TodoItem> items, string filePath)
        {
            List<string> lines = new List<string>();

            //add a header row
            lines.Add("Item,Deadline,IsDone");
            foreach (var item in items)
            {
                lines.Add($"{item.Title}, {item.Deadline}, {item.IsDone}");
            }

            System.IO.File.WriteAllLines(filePath, lines);
        }

        public static List<TodoItem> LoadItems(string filePath)
        {
            List<TodoItem> output = new List<TodoItem>();
            var lines = System.IO.File.ReadAllLines(filePath).ToList();

            // remove the header row
            lines.RemoveAt(0);

            foreach (var line in lines)
            {
                var vals = line.Split(',');
                string title = vals[0];
                DateTime deadLine = Convert.ToDateTime(vals[1]);
                bool isDone = Convert.ToBoolean(vals[2]);
                TodoItem i = new TodoItem(title, deadLine);
                i.IsDone = isDone;


                output.Add(i);
            }

            return output;
        }

        public override string ToString()
        {
            string MatrixString = "";
            foreach (var item in TodoQuarters)
            {
                if (item.Key == QuarterType.ImportantUrgent)
                {
                    MatrixString += $"Important & Urgent: \n{item.Value}";
                }
                else if (item.Key == QuarterType.ImportantNotUrgent)
                {
                    MatrixString += $"Important & Not Urgent: \n{item.Value}";
                }
                else if (item.Key == QuarterType.NotImportantUrgent)
                {
                    MatrixString += $"Not Important & Urgent: \n{item.Value}";
                }
                else if (item.Key == QuarterType.NotImportantNotUrgent)
                {
                    MatrixString += $"Not Important & Not Urgent: \n{item.Value}";
                }

            }
            return MatrixString;


        }

    }
}