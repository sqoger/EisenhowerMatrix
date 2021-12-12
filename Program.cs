using System;
using System.Collections.Generic;
using System.Text;

namespace EisenhowerCore
{
    class Program
    {
        public TodoMatrix todoMatrix = new TodoMatrix();
        public Display display = new Display();
        public Input input = new Input();
        public TodoQuarter todoQuarter = new TodoQuarter();

        public void QuarterMenu()
        {

        }
        
        public void Main()
        {
            while (true)
            {
                display.ClearScreen();
                display.DisplayTodos();
                display.DisplayStartMenu();
                string userInput = input.UserInputStartMenu();
                if (userInput == "7")
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    if (userInput == "6")
                    {
                        todoMatrix.ArchiveItems();
                    }
                    if (userInput == "5")
                    {
                        Console.WriteLine("title of your todo: ");
                        string title = input.NewTodoTitle();
                        //Console.WriteLine("deadline (DD/MM): ");
                        DateTime deadline = input.NewTodoDeadline();
                        //Console.WriteLine("is it important? (y/n): ");
                        //string YesOrNo = input.userInputYesOrNo();



                        todoMatrix.AddItem(title, deadline);
                    }
                    else
                    {   
                        if (userInput == "4")
                        {
                            display.displayQuarterInformation4();
                            TodoQuarter quarter = todoMatrix.GetQuarter(TodoMatrix.QuarterType.NotImportantNotUrgent);
                            quarter.ToString();
                            Console.Write(quarter);
                            display.DisplayQuarterMenu();
                            input.UserInputQuarterMenu();
                        }
                        if (userInput == "3")
                        {
                            display.displayQuarterInformation3();
                            TodoQuarter quarter = todoMatrix.GetQuarter(TodoMatrix.QuarterType.NotImportantUrgent);
                            quarter.ToString();
                            Console.Write(quarter);
                            display.DisplayQuarterMenu();
                            string userQuarterInput = input.UserInputQuarterMenu();
                            if (userQuarterInput == "5")
                            {
                                
                            }
                            if (userQuarterInput == "4")
                            {
                                //string getTodoIndex = input.userInputGetTodoIndex();
                                //quarter.GetItem
                                //Unmark();
                            }
                            if (userQuarterInput == "3")
                            {
                                //string getTodoIndex = input.userInputGetTodoIndex();
                                //quarter.GetItem
                                //mark();
                            }
                            if (userQuarterInput == "2")
                            {
                                //string getTodoIndex = input.userInputGetTodoIndex();
                                //quarter.GetItem
                                //remove item
                            }
                            if (userQuarterInput == "1")
                            {

                            }

                        }
                        if (userInput == "2")
                        {
                            display.displayQuarterInformation2();
                            TodoQuarter quarter = todoMatrix.GetQuarter(TodoMatrix.QuarterType.ImportantNotUrgent);
                            quarter.ToString();
                            Console.Write(quarter);
                            display.DisplayQuarterMenu();
                            input.UserInputQuarterMenu();
                        }
                        if (userInput == "1")
                        {
                            display.displayQuarterInformation1();
                            TodoQuarter quarter = todoMatrix.GetQuarter(TodoMatrix.QuarterType.ImportantUrgent);
                            quarter.ToString();
                            Console.Write(quarter);
                            display.DisplayQuarterMenu();
                            input.UserInputQuarterMenu();

                        }
                    }

                }
                
            }
        }
    }
}
