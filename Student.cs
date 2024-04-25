using System;
namespace _2404_C_Projet1_Application_console
{
	public class Student
	{
		private int _id;
		private string _lastName;
		private string _firstName;
		private string _dateOfBirth;
        // Un liste de notes (nombre à virgule) et d'appréciation du professeur (texte) pour chaque cours
        // La moyenne de ses notes qui sera calculée à la volée et ne sera pas enregistrée dans le fichier

        public Student(int id, string lastName, string firstName, string dateOfBirth)
		{
			_id = id;
			_lastName = lastName;
			_firstName = firstName;
			_dateOfBirth = dateOfBirth;
		}

		public int GetId()
		{
			return _id;
		}

		public string GetLastName()
		{
			return _lastName;
		}

		public string GetFirstName()
		{
			return _firstName;
		}

		public string GetDateOfBirth()
		{
			return _dateOfBirth;
		}

        double sumOfTheGrades;
        double meanOfTheStudent;
        public double CalculateTheMean()
		{

			return meanOfTheStudent;
		}
	}
}

