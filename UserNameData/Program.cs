using System;

namespace UserNameData
{
	class Program
	{
		static void Main(string[] args)
		{
			//proge küsib kasutaja eesnime
			//programm kuvab eesnime pikkust
			//programm kuvab eesnime esimest tähte
			//proge kuvab eesnime tagurpidi
			//mainis ei tohi rohkem kui kolm rida

			Console.WriteLine("Sisesta oma eesnimi:");
			string userName = Console.ReadLine();

			GetUserNameData(userName);

		}


		public static void GetUserNameData(string userInput)
		{
			Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
			Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");

			for (int i = userInput.Length - 1; i >= 0; i--)
			{
				Console.Write(userInput[i]);
			}
		}


	}
}
