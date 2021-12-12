using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EisenhowerCore
{
    class Input
    {
        Display display = new Display();
        public readonly List<string> StartMenu = new List<string>() { "1", "2", "3", "4", "5", "6", "7" };
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
            DateTime deadline = DateTime.Now;
            return deadline;
            //while (true)
            //{
            //    string format = "dd/MM";
            //    string input = Console.ReadLine();
            //    DateTime dateTime;
            //    if (DateTime.TryParseExact(input, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
            //    {
            //        return dateTime;
            //    }
            //    display.DisplayWrongInputMessage();
            //}

        }

        

    }
}
