using System;
namespace _2404_C_Projet1_Application_console
{
	public class MainMenu
	{
		public MainMenu()
		{
		}

		public static void Menu()
		{
			Console.WriteLine("Which menu do you want to access? Please type the number related to the desired option:");
            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine("1. Students");
			Console.WriteLine("2. Classes");
            Console.WriteLine("--------------");
            Console.WriteLine();
			Console.Write("Your choice: ");

			string userQuery = Console.ReadLine();

			while (userQuery != "1" && userQuery != "2")
			{
				Console.WriteLine("Sorry, this option is not valid. Please enter a valid option.");
				Console.WriteLine();
				Console.WriteLine("Which menu do you want to access? Please type the number related to the desired option:");
                Console.WriteLine();
                Console.WriteLine("--------------");
                Console.WriteLine("1. Students");
				Console.WriteLine("2. Classes");
                Console.WriteLine("--------------");
                Console.WriteLine();
				Console.Write("Your choice: ");
				userQuery = Console.ReadLine();
			}

			Console.WriteLine();

            if (userQuery == "1")
			{
				Console.WriteLine("You have entered the \"Students\" menu, what do you want to do?");
				StudentsMenu.Menu();
			}
			else if (userQuery == "2")
			{
				Console.WriteLine("You have entered the \"Classes\" menu, what do you want to do?");
				ClassesMenu.Menu();
			}
			
		}
	}
}

