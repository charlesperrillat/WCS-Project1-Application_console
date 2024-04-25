using System;
namespace _2404_C_Projet1_Application_console
{
	public class ClassesMenu
	{
		public ClassesMenu()
		{
		}

        public static void Menu()
        {
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

            while (userQuery != "1" && userQuery != "2" && userQuery != "3" && userQuery != "4")
            {
                Console.WriteLine("Sorry, this option is not valid. Please enter a valid option.");
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
            }

            Console.WriteLine();

            if (userQuery == "1")
            {
                Console.WriteLine("Here is the list of the existing classes:");
            }
            else if (userQuery == "2")
            {
                Console.WriteLine("Which class do you want to add to the program?");
            }
            else if (userQuery == "3")
            {
                Console.WriteLine("Which class do you want to delete? Please enter the identifier of the class: ");
            }
            else if (userQuery == "4")
            {
                Console.WriteLine("You went back to the main menu.");
                MainMenu.Menu();
            }
        }
    }
}

