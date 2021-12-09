using EisenhowerMatrix;
using System;
using System.Collections.Generic;
using System.Text;

namespace EisenhowerCore 
{

    public class TodoItem
    {
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsDone { get; set;  }
        private Display display;
        public TodoItem(string title, DateTime deadline)
        {
            this.Title = title;
            this.Deadline = deadline;
            this.IsDone = false;
            display = new Display();
        }


        string GetTitle()
        {
            return this.Title;
        }

        DateTime GetDeadline()
        {
            return this.Deadline;
        }

        public bool Mark()
        {
            return this.IsDone = true;
        }

        public bool Unmark()
        {
            return this.IsDone = false;
        }

        public string TdToString()
        {
            String TdTitle = GetTitle();
            DateTime TdDeadline = GetDeadline();
            if (IsDone == false)
            {
                return ($"[ ] {TdDeadline.ToString("dd/MM")} {TdTitle}");
            }
            else
                return ($"[X] {TdDeadline.ToString("dd/MM")} {TdTitle}");
        }

        public void PrintTodoItem()
        {
            display.Print(this.Title, this.Deadline, this.IsDone);
        }
    }

}