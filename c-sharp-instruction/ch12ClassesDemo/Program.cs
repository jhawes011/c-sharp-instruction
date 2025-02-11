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
			

			//PrintL($"newMovie title = {newMovie.Title}");
			//PrintL(newMovie.ToString());

			string choice = "y";
			while (choice == "y")
			{

				// capture input of properties of a movie-----------------------------
				int id = MyConsole.PromptInt("Movie ID: ");
				string title = MyConsole.PromptString("Movie Title: ");
				int year = MyConsole.PromptInt("Year");
				string ageRating = MyConsole.PromptString("Age Rating: ");
				string director = MyConsole.PromptString("Director: ");
				//store this movie and capture a new one------------------------------
				
				
				choice = MyConsole.PromptString("Add another movie? y/n ");
			}
			// repeat until user is done entering movies
			//then display all movies
			MyConsole.PrintL("=======Movies==========");
			foreach (Movie movie in Movies)
			{
				MyConsole.PrintL(movie.ToString());
			}
			MyConsole.PrintL("Bye-------------------------");
		}

		
	}
}
