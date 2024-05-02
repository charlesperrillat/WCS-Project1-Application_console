using System;
namespace _2404_C_Projet1_Application_console
{
    public class ClassManager
    {
        public List<Classes> listOfClasses;

        public ClassManager()
        {
            listOfClasses = new List<Classes>();
            Classes maths = new Classes(1, "Maths");
            listOfClasses.Add(maths);
        }

        public void CreateClass()
        {
            Console.WriteLine("Creation of a new class:");
            Console.WriteLine();
            Console.Write("Class ID: ");
            int classId = int.Parse(Console.ReadLine());
            Console.Write("Class name: ");
            string className = Console.ReadLine();

            Classes lesson = new Classes(classId, className);

            listOfClasses.Add(lesson);

            Console.WriteLine("");
            Console.WriteLine(className + " has been added to the program.");
            Console.WriteLine("");
        }

        public void DeleteClass()
        {
            Console.WriteLine("Which class do you want to delete? Please enter its identifier:");
            Console.Write("Class Id: ");
            int classToDelete = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Classes lessons = listOfClasses.FirstOrDefault(lesson => lesson.Id == classToDelete);

            if (lessons == null)
            {
                Console.WriteLine("Class not found. Please try again.");
                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("You are going to delete this class: " + lessons.Name + ".");
                Console.WriteLine("Do you confirm? Yes / No: ");
                string userConfirmation = Console.ReadLine();
                if (userConfirmation.ToLower() == "yes")
                {
                    listOfClasses.Remove(lessons);
                    Console.WriteLine("Class " + lessons.Name + " has been deleted.");
                    Console.WriteLine("");
                }

                else
                {
                    Console.WriteLine("Class " + lessons.Name + " has not been deleted.");
                    Console.WriteLine("");
                }
            }
        }
    }
}

