using System;
namespace _2404_C_Projet1_Application_console
{
	public class MainMenu
	{
		StudentsMenu studentMenuManager = new StudentsMenu();
		ClassesMenu classesMenuManager = new ClassesMenu();

		public MainMenu()
		{
		}

		public void DisplayMenu()
		{
			while (true)
			{
				Console.WriteLine("Which menu do you want to access?");
				Console.WriteLine();
				Console.WriteLine("--------------");
				Console.WriteLine("1. Students");
				Console.WriteLine("2. Classes");
				Console.WriteLine("--------------");
				Console.WriteLine();
				Console.Write("Your choice: ");

				string userQuery = Console.ReadLine();

                Console.WriteLine();

                while (userQuery != "1" && userQuery != "2")
				{
					Console.WriteLine("Sorry, this option is not valid.");
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

				if (userQuery == "1")
					studentMenuManager.DisplayMenu();
				else if (userQuery == "2")
					classesMenuManager.DisplayMenu();
			}
		}

	}
}

