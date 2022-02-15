using System;

namespace UserNameDataTask
{
	class Program
	{
		static void Main(string[] args)
		{
			//proge küsib kasutaja eesnime
			//küsib kasutajal sisestada numbrit 1-3
			//1- siis eesnimi tagurpidi
			//2- siis eesnime esimene täht
			//3- eesnime pikkus

			Console.WriteLine("Sisesta oma eesnimi:");
			string userName = Console.ReadLine();
			Console.WriteLine("Vali number 1-3:");
			char userNumber = Convert.ToChar(Console.ReadLine());



			switch (userNumber)
			{
				case '1':
					NameReverse(userName);
					break;
				case '2':
					FirstLetter(userName);
					break;
				case '3':
					NameLength(userName);
					break;
				default:
					Console.WriteLine("Kena päeva!");
					break;
			}



		}
		//fn siin

		public static void NameReverse(string userInput)
		{
			for (int i = userInput.Length - 1; i >= 0; i--)
			{
				Console.Write(userInput[i]);
			}
		}
		public static void FirstLetter(string userInput)
		{
			Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
		}
		public static void NameLength(string userInput)
		{
			Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
		}





		//public static void GetUserNameData(string userInput)
		//{
		//	Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
		//	Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");

		//	for (int i = userInput.Length - 1; i >= 0; i--)
		//	{
		//	Console.Write(userInput[i]);
		//}
		//	}

		//public static void GetUserNameData(string userInput)
		//	Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");

		//public static void GetUserNameData(string userInput)
		//	Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");



	}
}