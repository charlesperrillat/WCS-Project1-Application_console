using System;
namespace _2404_C_Projet1_Application_console
{
	public abstract class Classes
	{
		protected int _id;
		protected string _name;

		public Classes(int id, string name)
		{
			_id = id;
			_name = name;
        }

		public Classes[] listOfClasses = new Classes[5];

		public void DisplayListOfClasses()
		{
			for (int i = 1; i <= listOfClasses.Length; i++)
			{
				Console.WriteLine($"{i}. {listOfClasses[i-1]}");
			}
		}
	}
}

