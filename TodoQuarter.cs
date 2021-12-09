using System;
using System.Collections.Generic;
using System.Text;

namespace EisenhowerCore { 

    public class TodoQuarter {

        public List<TodoItem> TodoItems { get; set; } = new List<TodoItem>();

        List<TodoItem> TodoQuart()
        {
            return TodoItems;
        }

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

        private List<TodoItem> GetItems()
        {
            return TodoItems;
        }

        public List<string> QuartToString()
        {
            List<string> QuartStringList = new List<string>();

            for (int i = 0; i < TodoItems.Count; i++)
            {
                QuartStringList.Add($"{i + 1}. {TodoItems[i]}");
            }
            return QuartStringList;
        }
    }

}