using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EisenhowerCore
{
    class Input
    {
        TodoMatrix todoMatrix = new TodoMatrix();
        Display display = new Display();
        public readonly List<string> StartMenu = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public readonly List<string> QuarterMenu = new List<string>() { "1", "2", "3", "4", "5" };

        public string userInputYesOrNo()
        {
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == "y" || userInput == "n")
                {
                    return userInput;
                }
                display.DisplayWrongInputMessage();
            }
            
            
        }

        public int ChooseTodoByIndex()
        {
            while (true)
            {
                string userInput = Console.ReadLine();
                int index = Int16.Parse(userInput) -1 ;
                return index;
            }
        }

        public string UserInputStartMenu()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (StartMenu.Contains(input))
                {
                    return input;
                }
                display.DisplayWrongInputMessage();
            }
        }

        public string UserInputQuarterMenu()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (StartMenu.Contains(input))
                {
                    return input;
                }
                display.DisplayWrongInputMessage();
            }

        }

        public string NewTodoTitle()
        {
            string input = Console.ReadLine();
            return input;
        }

        public DateTime NewTodoDeadline()
        {
            while (true)
            {
                string input = Console.ReadLine();
                DateTime dateTime;
                if (DateTime.TryParse(input, out dateTime))
                {
                    return dateTime;
                }
                display.DisplayWrongInputMessage();
            }

        }
    }
}
