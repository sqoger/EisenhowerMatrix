using System;
using System.Collections.Generic;
using System.Linq;

namespace EisenhowerCore
{
    public class EisenhowerMain
    {
        
        //static void printArray(char[] array)
        //{
        //    foreach (var elem in array)
        //    {
        //        Console.Out.WriteLine(elem);
        //    }
        //}
        static void Main(string[] args)
        {
            DateTime V = DateTime.Now;
            List<TodoItem> list = new List<TodoItem>() 
            {
                new TodoItem("tdgewf1", V),
                new TodoItem("td2avsdvcdsa", V),
                new TodoItem("asdaf", V)
            };

            //TodoItem todoItem = new TodoItem();
            //todoItem.Title = "First task";
            //Console.WriteLine(todoItem);
            //DateTime V = DateTime.Now;
            //TodoItem todoItem = new TodoItem("tdgewf1", V);
            //TodoItem todo2 = new TodoItem("td2avsdvcdsa", V);
            //todoItem.Mark();

            foreach (var item in list)
            {
                Console.WriteLine(item.TdToString());
                item.Mark();
            }

            //Console.WriteLine(todoItem.TdToString());
            //Console.WriteLine(todo2.TdToString());


            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int result = myArray.Min();
            //Console.WriteLine(result);

            //    DemoTodoQuarter();
            //}
            //private static void DemoTodoQuarter()
            //{
            //    List<TodoItem> items = new List<TodoItem>();

            //    BaseList(items);

            //    string itemFile = @"W:\Хобби\new\Хобби\CodeCool\Projects\C#\EisenhowerMatrix\Test\gg\gg.csv";

            //    TodoQuarter.SaveItems(items, itemFile);

            //    var newItem = TodoQuarter.LoadItems(itemFile);

            //    foreach (var item in items)
            //    {
            //        Console.Out.WriteLine($"{ item.IsDone} {item.Title}");
            //    }

            //    void BaseList(List<TodoItem> items)
            //    {
            //        items.Add(new TodoItem { Title = "gygy" });
            //    }


        }
    }
}
