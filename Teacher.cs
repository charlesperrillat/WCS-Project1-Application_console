using System;
namespace _2404_C_Projet1_Application_console
{
	public class Teacher
	{
		private string FirstName { get; set; }
		private string LastName { get; set; }
		private Student Student { get; set; }
		private Classes Classes { get; set; }
        private List<Student> ListOfStudents;

        public Teacher(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
			// Student = new Student(1, "Uzumaki", "Naruto", "10/10/1999");
			// AddToListOfStudents(Student); 
		}

		public void AddToListOfStudents(Student Student)
		{
			ListOfStudents.Add(Student);
		}

		public void DisplayListOfStudents()
		{
			foreach (Student student in ListOfStudents)
				Console.WriteLine(student); 
		}
	}
}

