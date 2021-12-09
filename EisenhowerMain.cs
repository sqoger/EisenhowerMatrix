using System;
using System.Collections.Generic;

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
            DateTime V = DateTime.Now;
            List<TodoItem> list = new List<TodoItem>()
                {
                    new TodoItem("tdgewf1", V),
                    new TodoItem("td2avsdvcdsa", V),
                    new TodoItem("asdaf", V)
                };
            foreach (var item in list)
            {
                Console.WriteLine(item.TdToString());
                item.Mark();
            }

        }

    }
}
