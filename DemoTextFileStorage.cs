using EisenhowerCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EisenhowerMatrix
{
    class DemoTextFileStorage
    {
        public static void TextFileStorage()
        {
            List<TodoItem> items = new List<TodoItem>();

            ListOfItems(items);

            string itemsFile = @"items.csv";

            TextFileProcessor.SaveItems(items, itemsFile);
            var newItems = TextFileProcessor.LoadItems(itemsFile);

            foreach (var item in newItems)
            {
                Console.WriteLine($"{item.Title}, {item.Deadline}, {item.IsDone}");
            }
        }
        public static void ListOfItems(List<TodoItem> items)
        {
                items.Add(new TodoItem("Buy a ticket", new DateTime(2021,12,21)) { IsDone = true });
                items.Add(new TodoItem("dfwff a ticket", new DateTime(2022, 12, 01)) { IsDone = false });
                items.Add(new TodoItem("Buy a car", new DateTime(2012, 12, 21)) { IsDone = false });
        }
        
    }
}
