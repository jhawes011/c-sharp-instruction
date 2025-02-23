using ConsoleLibrary;
namespace joe_hawes_BMDBFileIO
{
	internal class Program
	{
		
		static List<Movie> movies = new List<Movie>();
		static void Main(string[] args)
		{
			Console.WriteLine("======================Welcome to BMDB FileIO ================================\n");
			movies = MovieDB.GetMovies();
			int command = 8;
			while (command != 0)
			{
				ShowMenu();
				command = MyConsole.PromptInt("Command: ");
				MyConsole.PrintL("");
				switch (command)
				{
					case 1: ListMovies(); break;
					case 2: GetMovieById(); break;
					case 3: AddMovie(); break;
					case 4: RemoveMovie(); break;
				}
			}
			MyConsole.PrintL("");
			MyConsole.PrintL("======================== GOODBYE ======================\n \n");
		}	
		private static void ListMovies()
		{
			MyConsole.PrintL("=====Movies List=====");
			
			foreach (Movie m in movies)
			{
				MyConsole.PrintL(m.ToString());
			}
			MyConsole.PrintL("");
		}
		public static void GetMovieById()
		{
			int id = MyConsole.PromptInt("Enter Movie Id: ");
			var movie = movies.FirstOrDefault(m => m.Id == id);
			Console.WriteLine(movie != null ? movie.ToString() : "Movie not found.");
			MyConsole.PrintL("");
		}
		public static void AddMovie()
		{
			MyConsole.PrintL("=======Add Movie=======");
			int id = MyConsole.PromptInt("Enter Movie Id#: ");
			string title = MyConsole.PromptString("Enter title: ");
			int year = MyConsole.PromptInt("Enter year: ");
			string ageRating = MyConsole.PromptString("Enter age rating: ");
			string director = MyConsole.PromptString("Enter director: ");
			Movie m = new Movie(id, title, year, ageRating, director);
			movies.Add(m);
			MovieDB.SaveMovie(movies);
			MyConsole.PrintL("");
			MyConsole.PrintL($"===={title} added====\n");
		}
		public static void RemoveMovie()
		{
			MyConsole.PrintL("====Remove Movie====");
			int id = MyConsole.PromptInt("Enter Movie Id#: ");
			Movie movieToRemove = movies.Find(m => m.Id == id);

			if (movieToRemove != null)
			{
				movies.Remove(movieToRemove);
				MovieDB.SaveMovie(movies);
				MyConsole.PrintL($"===={movieToRemove.Title} removed successfully====\n");
			}
		}
		private static void ShowMenu()
		{
			MyConsole.PrintL("====COMMAND MENU====");
			MyConsole.PrintL("       1) List All Movies");
			MyConsole.PrintL("       2) Get Movie Details by ID");
			MyConsole.PrintL("       3) Add Movie");
			MyConsole.PrintL("       4) Remove Movie by ID");
			MyConsole.PrintL("       0) Exit");
		}
	}
}
