using System;
using System.Collections.Generic;
using System.Text;

namespace EisenhowerCore
{
    class Display
    {

        public string StartMenu = @"
-------------------------------
1. urgent & important items
2. not urgent & important items
3. urgent & not important items
4. not urgent & not important items
5. Add todo
6. Archive marked todos
7. Quit
";

        public string UrgentImportant = @"
-------------------------------
urgent & important items
";
        public string NotUrgentImportant = @"
-------------------------------
not urgent & important items
";
        public string UrgentNotImportant = @"
-------------------------------
urgent & not important items
";
        public string NotUrgentNotImportant = @"
-------------------------------
not urgent & not important items
";

        public string QuarterMenu = @"
-------------------------------
Options:
1. Add todo
2. Delete todo
3. Mark todo
4. Unmark todo
5. back
";


        public string WrongInput = @"
-------------------------------
wrong input, try again
------------------------------";

        public string ChooseTodo = "choose todo item by index: ";


        TodoMatrix todoMatrix = new TodoMatrix();

        public void displayChooseTodo()
        {
            Console.WriteLine(ChooseTodo);
        }

        public void displayQuarterInformation1()
        {
            Console.WriteLine(UrgentImportant);
        }
        public void displayQuarterInformation2()
        {
            Console.WriteLine(NotUrgentImportant);
        }
        public void displayQuarterInformation3()
        {
            Console.WriteLine(UrgentNotImportant);
        }
        public void displayQuarterInformation4() 
        {
            Console.WriteLine(NotUrgentNotImportant);
        }




        public void ClearScreen()
        {
            Console.Clear();
        }
        public void DisplayTodos()
        {
            Console.WriteLine(todoMatrix.ToString());
        }

        public void DisplayStartMenu()
        {
            Console.WriteLine(StartMenu);
        }

        public void DisplayQuarterMenu()
        {
            Console.WriteLine(QuarterMenu);
        }

        public void DisplayWrongInputMessage()
        {
            Console.WriteLine(WrongInput);
        }

        //public void DisplayQuarter(QuarterType quartertype)
        //{
        //    if (quarterType == QuarterType.Matrix)
        //}
         

    }
}
