using System;
using System.Collections.Generic;

namespace EisenhowerCore
{
    public class TodoMatrix
    {
        public Dictionary<string, TodoQuarter> TodoQuarters { get; set; } = new Dictionary<string, TodoQuarter>
        {
              { "IU", IU },
              { "IN", IN },
              { "NU", NU },
              { "NN", NN }
        };
        public static TodoQuarter IU { get; set; }
        public static TodoQuarter IN { get; set; }
        public static TodoQuarter NU { get; set; }
        public static TodoQuarter NN { get; set; }


        //possible keys of TODO quarter:
        //- 'IU' means that todoQuarter contains important todoItems & urgent
        //- 'IN' means that todoQuarter contains important todoItems & not urgent
        //- 'NU' means that todoQuarter contains not important todoItems & urgent
        //- 'NN' means that todoQuarter contains not important & not urgent todoItems


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
                    NN.AddItem(title, deadline);
                }
                else
                {
                    NU.AddItem(title, deadline);
                }
            }
            else
            {
                if ((deadline - DateTime.Now).TotalDays > 3)
                {
                    IN.AddItem(title, deadline);
                }
                else
                {
                    IU.AddItem(title, deadline);
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

        public string MatrixToString()
        {
            string MatrixString = "";
            foreach (var item in TodoQuarters)
            {
                if (TodoQuarters.ContainsKey("IU"))
                {
                    MatrixString = MatrixString + $"Important & Urgent: \n{item.Value.QuartToString()}";
                }
                if (TodoQuarters.ContainsKey("IN"))
                {
                    MatrixString = MatrixString + $"Important & Not Urgent: \n{item.Value.QuartToString()}";
                }
                if (TodoQuarters.ContainsKey("NU"))
                {
                    MatrixString = MatrixString + $"Not Important & Urgent: \n{item.Value.QuartToString()}";
                }
                else
                {
                    MatrixString = MatrixString + $"Not Important & Not Urgent: \n{item.Value.QuartToString()}";
                }

            }
            return MatrixString;

        }


    }


}