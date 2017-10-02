using System;

namespace OOPConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//StudentDemo();
			InheritanceDemo();
			Console.ReadLine();
		}

		private static void InheritanceDemo()
		{
			Animal anAnimal = new Animal();
			Lion aLion = new Lion();
			TellAnimalToEatTwice(aLion);
		}

		private static void TellAnimalToEatTwice(Animal anAnimal)
		{
			anAnimal.Eat();
			anAnimal.Eat();
		}

		private static void StudentDemo()
		{
			var mattias = new Student();
			mattias.Name = "Mattias Asplund";
			mattias.Email = "mattiasasplund@test.com";
			mattias.TooTired += Mattias_TooTired;
			mattias.StudyHarder();// ctrl + . to create generate a method class
			mattias.StudyHarder();
			mattias.StudyHarder();
			Console.WriteLine($"Hello World to {mattias}");
			
		}

		private static void Mattias_TooTired(object sender, EventArgs e) //Mattis_TooTired is callback method
		{
			Console.WriteLine("Student needs to rest");
		}
	}
}
