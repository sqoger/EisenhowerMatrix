using EisenhowerMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EisenhowerCore
{

    public class TodoQuarter
    {
        private Display display;
        

        public List<TodoItem> TodoItems { get; set; }

        public TodoQuarter(List<TodoItem> todoItems)
        {
            this.TodoItems = todoItems;
            this.display = new Display();
        }


        //DateTime V = DateTime.Now;
        //List<TodoItem> TodoItems = new List<TodoItem>()
        //{

        //};

        public void AddItem(string title, DateTime deadline)
        {
            //Append *TodoItem* object to *todoItems*
            var todoItem = new TodoItem(title, deadline);
            this.TodoItems.Add(todoItem);
            return; 
        }

        public void RemoveItem(int index)
        {
            // Removes *TodoItem* object using *index* of list *todoItems*
        }

        public void ArchiveItems()
        {
            //Removes all *TodoItem* objects with a parameter *isDone* set to *true* from list *todoItems*.
        }

        public void GetItem(int index)
        {
            //Returns *TodoItem* object from *index* of list *todoItems*.
        }

        public void GetItems()
        {
            //Returns private field *todoItems*.
        }

        //public string ToString()
        //{
        //    //Returns a formatted list of *todoItems*. There is an expecting output:
        //}

        public void PrintTodoQuarter()
        {
            this.display.Print(this.todoItems);
            foreach (var item in TodoItems)
            {
                todoItem.PrintTodoItem();
            }
        }

        
















    //public TData Data { get; set; }

    //public TDescription Description { get; set; }

    ////int[] intArray = { 1, 2, 3, 4, 5 };


    ////char[] charArray = { 'a', 'b', 'c' };




    //static void printArray<T>(T[] array)
    //{
    //    foreach (var elem in array)
    //    {
    //        Console.Out.WriteLine(elem);
    //    }
    //}
    ////List<T> todoItems = new List<T>();
    //public T AddItem(string title, DateTime deadline)
    //{
    //    todoItems.Add(Console.ReadLine());
    //}

    //public T RemoveItem(int index)
    //{
    //    todoItems.RemoveAt(int.Parse(Console.ReadLine()));
    //}

    //public T ArchiveItems(TodoItem)
    //{
    //    foreach (var items in todoItem)
    //    {
    //        if (IsDone == true)
    //        {
    //            todoItem.Remove(items);
    //            break;
    //        }

    //    }
    //}

    //static T GetItems<T>(T[] array)
    //{
    //    return array[];
    //}

    ////    public string TdToString()
    ////    {
    ////        String TdTitle = GetTitle();
    ////        DateTime TdDeadline = GetDeadline();
    ////        if (IsDone == false)
    ////        {
    ////            return ($"[ ] {TdDeadline.ToString("dd/MM")} {TdTitle}");
    ////        }
    ////        else
    ////            return ($"[X] {TdDeadline.ToString("dd/MM")} {TdTitle}");
    ////    }
    ////}

    public static void SaveItems(List<TodoItem> items, string filePath)
        {
            List<string> lines = new List<string>();

            // add a header row
            lines.Add("Title, Deadline");
            foreach (var elem in items)
            {
                lines.Add($"{elem.IsDone}, {elem.Title}, {elem.Deadline}");
            }
            System.IO.File.WriteAllLines(filePath, lines);
        }

        //public static List<TodoItem> LoadItems(string filePath)
        //{
        //    List<TodoItem> output = new List<TodoItem>();
        //    var lines = System.IO.File.ReadAllLines(filePath).ToList();

        //    //remove the header row
        //    lines.RemoveAt(0);

        //    foreach (var line in lines)
        //    {
        //        var vals = line.Split(',');
        //        TodoItem i = new TodoItem();
        //        //i.IsDone = vals[0];
        //        i.Title = vals[1];
        //        //i.Deadline = vals[2];

        //        output.Add(i);

        //    }

        //    return output;
        //}
    }
}