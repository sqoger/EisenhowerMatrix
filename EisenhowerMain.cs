using System;

namespace EisenhowerCore
{
    public class EisenhowerMain
    {
        static void Main(string[] args)
        {
            DateTime V = DateTime.Now;
            TodoItem todo1 = new TodoItem("tdgewf1", V);
            TodoItem todo2 = new TodoItem("td2avsdvcdsa", V);
            todo1.Mark();
            Console.WriteLine(todo1.TdToString());
            Console.WriteLine(todo2.TdToString());
        }
    }
}
