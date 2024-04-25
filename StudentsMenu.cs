﻿using System;
namespace _2404_C_Projet1_Application_console
{
	public class StudentsMenu
	{
		public StudentsMenu()
		{
		}

		public static void Menu()
		{
			Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("1. List students");
            Console.WriteLine("2. Create a new student");
            Console.WriteLine("3. View an existing student");
            Console.WriteLine("4. Add a grade and review for a course on an existing student");
            Console.WriteLine("5. Go back to main menu");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Your choice: ");

            string userQuery = Console.ReadLine();

            while (userQuery != "1" && userQuery != "2" && userQuery != "3" && userQuery != "4" && userQuery != "5")
            {
                Console.WriteLine("Sorry, this option is not valid. Please enter a valid option.");
                Console.WriteLine();
                Console.WriteLine("What do you want to do? Please type the number related to the desired option:");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("1. List students");
                Console.WriteLine("2. Create a new student");
                Console.WriteLine("3. View an existing student");
                Console.WriteLine("4. Add a grade and review for a course on an existing student");
                Console.WriteLine("5. Go back to main menu");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine();
                Console.Write("Your choice: ");
                userQuery = Console.ReadLine();
            }

            Console.WriteLine();

            if (userQuery == "1")
            {
                Console.WriteLine("Here is the list of the students:");
            }
            else if (userQuery == "2")
            {
                Console.WriteLine("You are going to create a new student, please enter the required information:");
            }
            else if (userQuery == "3")
            {
                Console.WriteLine("Which student do you want to view?");
            }
            else if (userQuery == "4")
            {
                Console.WriteLine("You are going to add a grade and review for a course on an existing student");
            }
            else if (userQuery == "5")
            {
                Console.WriteLine("You went back to the main menu.");
                MainMenu.Menu();
            }
        }
    }
}

