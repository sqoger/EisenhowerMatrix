using System;
using System.Collections.Generic;

namespace EisenhowerCore
{
    public class TodoMatrix
    {
        public TodoMatrix()
        {
            ImportantUrgent = new TodoQuarter();
            ImportantNotUrgent = new TodoQuarter();
            NotImportantUrgent = new TodoQuarter();
            NotImportantNotUrgent = new TodoQuarter();
        }
        public Dictionary<string, TodoQuarter> TodoQuarters { get; set; } = new Dictionary<string, TodoQuarter>
        {
              { "IU", ImportantUrgent },
              { "IN", ImportantNotUrgent },
              { "NU", NotImportantUrgent },
              { "NN", NotImportantNotUrgent }
        };
        public static TodoQuarter ImportantUrgent { get; set; }
        public static TodoQuarter ImportantNotUrgent { get; set; }
        public static TodoQuarter NotImportantUrgent { get; set; }
        public static TodoQuarter NotImportantNotUrgent { get; set; }

        private Dictionary<string, TodoQuarter> GetQuarters()
        {
            return TodoQuarters;
        }

        public TodoQuarter GetQuarter(String status)
        {
            if (TodoQuarters.ContainsKey(status))
            {
                TodoQuarter tdqrtr = TodoQuarters[status];
                return tdqrtr;
            }
            return null;
        }

        public void AddItem(String title, DateTime deadline, bool isImportant = false)
        {
            if (isImportant == false)
            {
                if ((deadline - DateTime.Now).TotalDays > 3)
                {
                    NotImportantNotUrgent.AddItem(title, deadline);
                }
                else
                {
                    NotImportantUrgent.AddItem(title, deadline);
                }
            }
            else
            {
                if ((deadline - DateTime.Now).TotalDays > 3)
                {
                    ImportantNotUrgent.AddItem(title, deadline);
                }
                else
                {
                    ImportantUrgent.AddItem(title, deadline);
                }
            }
        }

        //* `AddItem(String title, DateTime deadline, bool isImportant)`
        //  Adds new item to dictionary* todoQuarters* using adequate key.You should use method * AddItem* from * TodoQuarter* class.
        //  This method should be overloaded so as to accept two parameters only.In that case, isImportant should be `false` by default.


        //* `ArchiveItems()`

        //  Removes all *TodoItem* objects with a parameter* isDone* set to *true* from list *todoItems* in every element of dictionary *todoQuarters*

        //* `ToString()`

        //  Returns a todoQuarters list (an Eisenhower todoMatrix) formatted to string.

        public override string ToString()
        {
            string MatrixString = "";
            foreach (var item in TodoQuarters)
            {
                if (TodoQuarters.ContainsKey("IU"))
                {
                    MatrixString += $"Important & Urgent: \n{item.Value.ToString()}";
                }
                else if (TodoQuarters.ContainsKey("IN"))
                {
                    MatrixString += $"Important & Not Urgent: \n{item.Value.ToString()}";
                }
                else if (TodoQuarters.ContainsKey("NU"))
                {
                    MatrixString += $"Not Important & Urgent: \n{item.Value.ToString()}";
                }
                else
                {
                    MatrixString += $"Not Important & Not Urgent: \n{item.Value.ToString()}";
                }

            }
            return MatrixString;

        }


    }


}