using EisenhowerCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EisenhowerMatrix
{
    public class TextFileProcessor
    {
        public static void SaveItems(List<TodoItem> items, string filePath)
        {
            List<string> lines = new List<string>();

            //add a header row
            lines.Add("Item,Deadline,IsDone");
            foreach (var item in items)
            {
                lines.Add($"{item.Title}, {item.Deadline}, {item.IsDone}");
            }

            System.IO.File.WriteAllLines(filePath, lines);
        }

        public static List<TodoItem> LoadItems(string filePath)
        {
            List<TodoItem> output = new List<TodoItem>();
            var lines = System.IO.File.ReadAllLines(filePath).ToList();

            // remove the header row
            lines.RemoveAt(0);

            foreach (var line in lines)
            {
                var vals = line.Split(',');
                string title = vals[0];
                DateTime deadLine = Convert.ToDateTime(vals[1]);
                bool isDone = Convert.ToBoolean(vals[2]);
                TodoItem i = new TodoItem(title,deadLine);
                i.IsDone = isDone;
                

                output.Add(i);
            }

            return output;
        }
    }

   
}
