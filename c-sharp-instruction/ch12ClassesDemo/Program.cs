namespace ch12ClassesDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("welcome to ch9 (classes ch12) class demos \n --------------------------------------------------");

			
			

			Movie newMovie = new Movie();
			newMovie.Id = 1;
			newMovie.Title = "Jurassic World Rebirth";
			newMovie.Year = 2025;
			newMovie.Rating = "PG-13";
			newMovie.Director = "Gareth Edwards";
			Movies.Add(newMovie);

			//PrintL($"newMovie title = {newMovie.Title}");
			//PrintL(newMovie.ToString());

			string choice = "y";
			while (choice == "y")
			{

				// capture input of properties of a movie-----------------------------
				int id = PromptInt("Movie ID: ");
				string title = PromptString("Movie Title: ");
				int year = PromptInt("Year");
				string ageRating = PromptString("Age Rating: ");
				string director = PromptString("Director: ");
				//store this movie and capture a new one------------------------------
				
				choice = PromptString("Add another movie? y/n ");
			}
			// repeat until user is done entering movies
			//then display all movies
			PrintL("=======Moies==========");
			foreach (Movie move in Movies)
			{
				PrintL(movie.ToString());
			}
		}

		static int PromptInt(string prompt)
		{
			int result = 0;
			bool isValid = false;
			while (!isValid)
			{

				Print(prompt);
				if (Int32.TryParse(Console.ReadLine(), out result))
				{
					isValid = true;
				}
				else
				{
					PrintL("Error - invalid int.");

				}

			}
			return result;
		}
		static string PromptString(string prompt)
		{
			Print(prompt);
			return Console.ReadLine();
		}
		static void Print(string msg)
		{
			Console.Write(msg);
		}
		static void PrintL(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}
