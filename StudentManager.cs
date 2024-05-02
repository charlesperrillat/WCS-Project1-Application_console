using System;
namespace _2404_C_Projet1_Application_console
{
	public class StudentManager
	{
        public List<Student> ListOfStudents;

        public StudentManager()
		{
            ListOfStudents = new List<Student>();
            Student studentOne = new Student(1, "Shelby", "Thomas", "10/10/1999");
            ListOfStudents.Add(studentOne);
        }

        public void CreateStudent()
        {
            Console.WriteLine("Creation of a new student:");
            Console.WriteLine();
            Console.Write("Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            Console.Write("Student last name: ");
            string studentLastName = Console.ReadLine();
            Console.Write("Student first name: ");
            string sutdentFirstName = Console.ReadLine();
            Console.Write("Student birth date: ");
            string studentBirthDate = Console.ReadLine();

            Student student = new Student(studentId, studentLastName, sutdentFirstName, studentBirthDate);

            ListOfStudents.Add(student);

            Console.WriteLine();
        }

        public void DisplayStudent()
        {
            Console.Write("Enter the Id of the student: ");
            int studentToDisplay = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            foreach (Student student in ListOfStudents)
            {
                if (studentToDisplay == student.Id)
                {
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine("Student details:");
                    Console.WriteLine("");
                    Console.WriteLine(string.Format("Name {0,16}", ": " + student.LastName));
                    Console.WriteLine(string.Format("First name {0,10}", ": " + student.FirstName));
                    Console.WriteLine("Date of birth: " + student.DateOfBirth);
                    Console.WriteLine("");
                    Console.WriteLine("Academic results:");
                    Console.WriteLine("");
                    // afficher les cours avec les notes et appreciations
                    // afficher la moyenne
                    Console.WriteLine("----------------------------------------------------------------------");

                    Console.WriteLine("");
                }
            }
        }


    }
}

