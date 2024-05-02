using System;
namespace _2404_C_Projet1_Application_console
{
	public class ClassesMenu
	{

        ClassManager classManager = new ClassManager();

        public ClassesMenu()
		{
		}

        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("You are in the \"Classes\" menu, what do you want to do?");
                Console.WriteLine();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. List existing classes");
                Console.WriteLine("2. Add a new class to the program");
                Console.WriteLine("3. Delete a class by its identifier");
                Console.WriteLine("4. Go back to main menu");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine();
                Console.Write("Your choice: ");

                string userQuery = Console.ReadLine();

                Console.WriteLine();

                while (userQuery != "1" && userQuery != "2" && userQuery != "3" && userQuery != "4")
                {
                    Console.WriteLine("Sorry, this option is not valid.");
                    Console.WriteLine();
                    Console.WriteLine("What do you want to do? Please type the number related to the desired option:");
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("1. List existing classes");
                    Console.WriteLine("2. Add a new class to the program");
                    Console.WriteLine("3. Delete a class by its identifier");
                    Console.WriteLine("4. Go back to main menu");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine();
                    Console.Write("Your choice: ");
                    userQuery = Console.ReadLine();
                    Console.WriteLine();
                }

                if (userQuery == "1")
                {
                    Console.WriteLine("Here is the list of the existing classes:");
                    Console.WriteLine("");
                    foreach (Classes lesson in classManager.listOfClasses)
                        Console.WriteLine(lesson.Id + " - " + lesson.Name);
                    Console.WriteLine("");
                }
                else if (userQuery == "2")
                    classManager.CreateClass();
                else if (userQuery == "3")
                {
                    classManager.DeleteClass();
                }
                else if (userQuery == "4")
                {
                    Console.WriteLine("You went back to the main menu.");
                    break;
                }
            }
        }
    }
}

