using System;
using System.Collections.Generic;
using static EisenhowerCore.TodoQuarter;

namespace EisenhowerCore
{
    public class EisenhowerMain
    {
        static void Main(string[] args)
        {
            //TodoItem todo1 = new TodoItem("tdgewf1", V);
            //TodoItem todo2 = new TodoItem("td2avsdvcdsa", V);
            //todo1.Mark();
            //Console.WriteLine(todo1.TdToString());
            //Console.WriteLine(todo2.TdToString())

            //List<TodoItem> list = new List<TodoItem>()
            //    {
            //        new TodoItem("tdgewf1", V),
            //        new TodoItem("td2avsdvcdsa", V),
            //        new TodoItem("asdaf", V)
            //    };
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.TdToString());
            //    item.Mark();
            //}
            DateTime V = DateTime.Now;
            var TodoQuart = new TodoQuarter();
            //var TodoMtrx = new TodoMatrix();
            //TodoMtrx.AddItem("hehe", V);
            //TodoMtrx.AddItem("hehe", V);
            //TodoMtrx.AddItem("hehe", V);
            //TodoMtrx.AddItem("hehe", V);
            TodoQuart.AddItem("haha", V);
            TodoQuart.AddItem("haha", V);
            TodoQuart.AddItem("haha", V);
            TodoQuart.AddItem("haha", V);
            TodoQuart.GetItem(0).Mark();
            //TodoQuart.ArchiveItems();
            //string t = TodoMtrx.MatrixToString();
            string y = TodoQuart.QuartToString();
            //Console.Write(y);
            //Console.Write(t);
            Console.Write(y);


        }

    }
}




