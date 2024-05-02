using System;
namespace _2404_C_Projet1_Application_console
{
	public class Student
	{
		public int Id { get; set; }
		public string LastName { get; set; }
        public string FirstName { get; set; }
        public string DateOfBirth { get; set; }
        
        // Un liste de notes (nombre à virgule) et d'appréciation du professeur (texte) pour chaque cours
        // La moyenne de ses notes qui sera calculée à la volée et ne sera pas enregistrée dans le fichier

        public Student(int id, string lastName, string firstName, string dateOfBirth)
		{
			Id = id;
			LastName = lastName;
			FirstName = firstName;
			DateOfBirth = dateOfBirth;
		}
	


        double sumOfTheGrades;
        double meanOfTheStudent;
        public double CalculateTheMean()
		{

			return meanOfTheStudent;
		}
	}
}

