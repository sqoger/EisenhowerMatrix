using System;
using System.Collections.Generic;

namespace EisenhowerCore { 

    public class TodoQuarter
    {

        public List<TodoItem> TodoItems { get; set; } = new List<TodoItem>();


        public List<TodoItem> AddItem(string title, DateTime deadline)
        {
            TodoItems.Add(new TodoItem(title,deadline) { Title = title, Deadline = deadline});
            return TodoItems;
        }

        public List<TodoItem> RemoveItem(int index)
        {
            TodoItems.RemoveAt(index);
            return TodoItems;
        }

        public List<TodoItem> ArchiveItems()
        {
            for (int i = 0; i < TodoItems.Count; i++)
            {
                if (TodoItems[i].IsDone == true)
                {
                    TodoItems.RemoveAt(i);
                }
            }
            return TodoItems;
        }

        public TodoItem GetItem(int index)
        {
            return TodoItems[index];
        }

        public List<TodoItem> GetItems()
        {
            return TodoItems;
        }

        // to override
        public override string ToString()
        {
            //List<string> QuartStringList = new List<string>();
            string QuartString = "";

            for (int i = 0; i < TodoItems.Count; i++)
            {
                TodoItem todoItem = TodoItems[i];
                QuartString = QuartString + ($"{i + 1}. {todoItem.ToString()} \n");
            }
            return QuartString;
        }
    }

}