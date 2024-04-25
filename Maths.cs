using System;
namespace _2404_C_Projet1_Application_console
{
	public class Maths : Classes
	{
		public Maths(int id, string name) : base(id, name)
		{
			listOfClasses[id - 1] = name;
		}

		
	}
}

