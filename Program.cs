namespace _2404_C_Projet1_Application_console;

class Program
{
    static void Main(string[] args)
    {
        Maths maths = new Maths(1, "Maths");

        maths.DisplayListOfClasses();

        MainMenu.Menu();
    }
}

