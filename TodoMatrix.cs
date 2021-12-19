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

        public void SaveItems()
        {
            bool isImportant = false;
            List<string> lines = new List<string>();
            string filePath = @"C:\Users\stplu\Desktop\C# OOP\Eisenhower\EisenhowerMatrix\Todos.csv";
            foreach (TodoQuarter quarter in TodoQuarters.Values)
            {
                if (quarter == TodoQuarters[QuarterType.ImportantUrgent] || quarter == TodoQuarters[QuarterType.ImportantNotUrgent])
                {
                    List<TodoItem> Todos = quarter.GetItems();
                    foreach (var Todo in Todos)
                    {
                        lines.Add($"{Todo.Title}, {Todo.Deadline}, {isImportant = true}");
                    }
                }
                else
                {
                    List<TodoItem> TodosNI = quarter.GetItems();
                    foreach (var Todo in TodosNI)
                    {
                        lines.Add($"{Todo.Title}, {Todo.Deadline}, {isImportant = false}");
                    }
                }
            }
            System.IO.File.WriteAllLines(filePath, lines);
        }

        public void LoadItems()
        {
            string filePath = @"C:\Users\stplu\Desktop\C# OOP\Eisenhower\EisenhowerMatrix\Todos.csv";
            var lines = System.IO.File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                var vals = line.Split(", ");
                string title = vals[0];
                DateTime deadLine = Convert.ToDateTime(vals[1]);
                bool isImportant = Convert.ToBoolean(vals[2]);
                AddItem(title, deadLine, isImportant);
            }            
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