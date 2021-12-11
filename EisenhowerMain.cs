using System;


namespace EisenhowerCore
{
    public class EisenhowerMain
    {
        static void Main(string[] args)
        {
            DateTime V = DateTime.Now;
            var TodoQuart = new TodoQuarter();
            var todoMatrix = new TodoMatrix();
            //TodoQuart.AddItem("hehe", V);
            //TodoQuart.AddItem("haha", V);
            //TodoQuart.AddItem("hehe", V);
            //TodoQuart.AddItem("haha", V);
            //TodoQuart.GetItem(0).Mark();
            todoMatrix.AddItem("hihi", V);
            string y = TodoQuart.ToString();
            string z = todoMatrix.ToString();
            Console.Write(y);
            Console.Write(z);



        }

    }
}




