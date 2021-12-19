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
        //public TodoQuarter todoQuarter = new TodoQuarter();

        public void Main()
        {
            while (true)
            {
                display.ClearScreen();
                display.DisplayTodos(todoMatrix);
                display.DisplayStartMenu();
                string userInput = input.UserInputStartMenu();
                if (userInput == "9")
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    if (userInput == "8")
                    {
                        todoMatrix.SaveItems();
                    }
                    if (userInput == "7")
                    {
                        todoMatrix.LoadItems();
                    }
                    if (userInput == "6")
                    {
                        todoMatrix.ArchiveItems();
                    }
                    if (userInput == "5")
                    {
                        Console.WriteLine("title of your todo: ");
                        string title = input.NewTodoTitle();
                        Console.WriteLine("deadline (DD/MM/YYYY): ");
                        DateTime deadline = input.NewTodoDeadline();
                        Console.WriteLine("is it important? (y/n): ");
                        string YesOrNo = input.userInputYesOrNo();
                        if (YesOrNo == "y")
                        {
                            todoMatrix.AddItem(title, deadline, true);
                        }
                        else
                        {
                            todoMatrix.AddItem(title, deadline, false);
                        }
                    }
                    else
                    {
                        if (userInput == "4")
                        {
                            display.displayQuarterInformation4();
                            TodoQuarter quarterNotImportantNotUrgent = todoMatrix.GetQuarter(TodoMatrix.QuarterType.NotImportantNotUrgent);
                            quarterNotImportantNotUrgent.ToString();
                            Console.Write(quarterNotImportantNotUrgent);
                            display.DisplayQuarterMenu();
                            string userInputforQuarter = input.UserInputQuarterMenu();
                            if (userInputforQuarter == "5")
                            {

                            }
                            if (userInputforQuarter == "4")
                            {
                                display.displayChooseTodo();
                                int index = input.ChooseTodoByIndex();
                                TodoItem todo = quarterNotImportantNotUrgent.GetItem(index);
                                todo.Unmark();
                            }
                            if (userInputforQuarter == "3")
                            {
                                display.displayChooseTodo();
                                int index = input.ChooseTodoByIndex();
                                TodoItem todo = quarterNotImportantNotUrgent.GetItem(index);
                                todo.Mark();
                            }
                            if (userInputforQuarter == "2")
                            {
                                display.displayChooseTodo();
                                int index = input.ChooseTodoByIndex();
                                quarterNotImportantNotUrgent.RemoveItem(index);
                            }
                            if (userInputforQuarter == "1")
                            {
                                Console.WriteLine("title of your todo: ");
                                string title = input.NewTodoTitle();
                                Console.WriteLine("deadline (DD/MM/YYYY): ");
                                DateTime deadline = input.NewTodoDeadline();
                                Console.WriteLine("is it important? (y/n): ");
                                string YesOrNo = input.userInputYesOrNo();
                                if (YesOrNo == "y")
                                {
                                    todoMatrix.AddItem(title, deadline, true);
                                }
                                else
                                {
                                    todoMatrix.AddItem(title, deadline, false);
                                }
                            }
                        }
                        if (userInput == "3")
                        {
                            display.displayQuarterInformation3();
                            TodoQuarter quarterNotImportantUrgent = todoMatrix.GetQuarter(TodoMatrix.QuarterType.NotImportantUrgent);
                            quarterNotImportantUrgent.ToString();
                            Console.Write(quarterNotImportantUrgent);
                            display.DisplayQuarterMenu();
                            string userInputforQuarter = input.UserInputQuarterMenu();
                            if (userInputforQuarter == "5")
                            {

                            }
                            if (userInputforQuarter == "4")
                            {
                                display.displayChooseTodo();
                                int index = input.ChooseTodoByIndex();
                                TodoItem todo = quarterNotImportantUrgent.GetItem(index);
                                todo.Unmark();
                            }
                            if (userInputforQuarter == "3")
                            {
                                display.displayChooseTodo();
                                int index = input.ChooseTodoByIndex();
                                TodoItem todo = quarterNotImportantUrgent.GetItem(index);
                                todo.Mark();
                            }
                            if (userInputforQuarter == "2")
                            {
                                display.displayChooseTodo();
                                int index = input.ChooseTodoByIndex();
                                quarterNotImportantUrgent.RemoveItem(index);
                            }
                            if (userInputforQuarter == "1")
                            {
                                Console.WriteLine("title of your todo: ");
                                string title = input.NewTodoTitle();
                                Console.WriteLine("deadline (DD/MM/YYYY): ");
                                DateTime deadline = input.NewTodoDeadline();
                                Console.WriteLine("is it important? (y/n): ");
                                string YesOrNo = input.userInputYesOrNo();
                                if (YesOrNo == "y")
                                {
                                    todoMatrix.AddItem(title, deadline, true);
                                }
                                else
                                {
                                    todoMatrix.AddItem(title, deadline, false);
                                }
                            }
                        }
                            if (userInput == "2")
                            {
                                display.displayQuarterInformation2();
                                TodoQuarter quarterImportantNotUrgent = todoMatrix.GetQuarter(TodoMatrix.QuarterType.ImportantNotUrgent);
                                quarterImportantNotUrgent.ToString();
                                Console.Write(quarterImportantNotUrgent);
                                display.DisplayQuarterMenu();
                                string userInputforQuarter = input.UserInputQuarterMenu();
                                if (userInputforQuarter == "5")
                                {

                                }
                                if (userInputforQuarter == "4")
                                {
                                    display.displayChooseTodo();
                                    int index = input.ChooseTodoByIndex();
                                    TodoItem todo = quarterImportantNotUrgent.GetItem(index);
                                    todo.Unmark();
                                }
                                if (userInputforQuarter == "3")
                                {
                                    display.displayChooseTodo();
                                    int index = input.ChooseTodoByIndex();
                                    TodoItem todo = quarterImportantNotUrgent.GetItem(index);
                                    todo.Mark();
                                }
                                if (userInputforQuarter == "2")
                                {
                                    display.displayChooseTodo();
                                    int index = input.ChooseTodoByIndex();
                                    quarterImportantNotUrgent.RemoveItem(index);
                                }
                                if (userInputforQuarter == "1")
                            {
                                Console.WriteLine("title of your todo: ");
                                string title = input.NewTodoTitle();
                                Console.WriteLine("deadline (DD/MM/YYYY): ");
                                DateTime deadline = input.NewTodoDeadline();
                                Console.WriteLine("is it important? (y/n): ");
                                string YesOrNo = input.userInputYesOrNo();
                                if (YesOrNo == "y")
                                {
                                    todoMatrix.AddItem(title, deadline, true);
                                }
                                else
                                {
                                    todoMatrix.AddItem(title, deadline, false);
                                }
                            }
                        }
                            if (userInput == "1")
                            {
                                display.displayQuarterInformation1();
                                TodoQuarter quarterImportantUrgent = todoMatrix.GetQuarter(TodoMatrix.QuarterType.ImportantUrgent);
                                quarterImportantUrgent.ToString();
                                Console.Write(quarterImportantUrgent);
                                display.DisplayQuarterMenu();
                                string userInputforQuarter = input.UserInputQuarterMenu();
                                if (userInputforQuarter == "5")
                                {

                                }
                                if (userInputforQuarter == "4")
                                {
                                    display.displayChooseTodo();
                                    int index = input.ChooseTodoByIndex();
                                    TodoItem todo = quarterImportantUrgent.GetItem(index);
                                    todo.Unmark();
                                }
                                if (userInputforQuarter == "3")
                                {
                                    display.displayChooseTodo();
                                    int index = input.ChooseTodoByIndex();
                                    TodoItem todo = quarterImportantUrgent.GetItem(index);
                                    todo.Mark();
                                }
                                if (userInputforQuarter == "2")
                                {
                                    display.displayChooseTodo();
                                    int index = input.ChooseTodoByIndex();
                                    quarterImportantUrgent.RemoveItem(index);
                                }
                                if (userInputforQuarter == "1")
                                {
                                    Console.WriteLine("title of your todo: ");
                                    string title = input.NewTodoTitle();
                                    Console.WriteLine("deadline (DD/MM/YYYY): ");
                                    DateTime deadline = input.NewTodoDeadline();
                                    Console.WriteLine("is it important? (y/n): ");
                                    string YesOrNo = input.userInputYesOrNo();
                                    if (YesOrNo == "y")
                                    {
                                        todoMatrix.AddItem(title, deadline, true);
                                    }
                                    else
                                    {
                                        todoMatrix.AddItem(title, deadline, false);
                                    }
                                }

                            }
                        }

                    }

                }
            }
        }
    }

