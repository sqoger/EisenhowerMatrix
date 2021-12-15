using System;
using System.Collections.Generic;
using System.IO;

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

        internal void AddItem(string title, DateTime deadline, object IsImportant)
        {
            throw new NotImplementedException();
        }


        public void ArchiveItems()
        {
            foreach (TodoQuarter quarter in TodoQuarters.Values)
            {
                quarter.GetItems().RemoveAll(item => item.IsDone);
            }
        }

        public override string ToString()
        {
            string MatrixString = "";
            foreach (var item in TodoQuarters)
            {
                if (item.Key == QuarterType.ImportantUrgent)
                {
                    MatrixString += $"Important & Urgent: \n{item.Value.ToString()}";
                }
                else if (item.Key == QuarterType.ImportantNotUrgent)
                {
                    MatrixString += $"Important & Not Urgent: \n{item.Value.ToString()}";
                }
                else if (item.Key == QuarterType.NotImportantUrgent)
                {
                    MatrixString += $"Not Important & Urgent: \n{item.Value.ToString()}";
                }
                else if (item.Key == QuarterType.NotImportantNotUrgent)
                {
                    MatrixString += $"Not Important & Not Urgent: \n{item.Value.ToString()}";
                }

            }
            return MatrixString;


        }

    }
}