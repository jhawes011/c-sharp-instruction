using ConsoleLibrary;

namespace joe_hawes_BMDBFileIO
{
	public class MovieDB
	{

		private const string Dir = @"C:\C#\files\";
		private const string Path = Dir + "Movies.txt";
		private const string Sep = "|";

		public static void SaveMovie(List<Movie> movies)
		{
			using StreamWriter writer = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));
			foreach (Movie movie in movies)
			{
				writer.Write(movie.Id + Sep);
				writer.Write(movie.Title + Sep);
				writer.Write(movie.Year + Sep);
				writer.Write(movie.AgeRating + Sep);
				writer.Write(movie.Director);
				writer.WriteLine();
			}

		}
		public static List<Movie> GetMovies()
		{
			using StreamReader reader = new (new FileStream(Path, FileMode.Open, FileAccess.Read));
			List<Movie> movies = new List<Movie>();
			while (reader.Peek() != -1)
			{
				string row = reader.ReadLine();
				string[] cols = row.Split(Sep);
				if (cols.Length == 5)
				{
					int id = int.Parse(cols[0]);
					string title = cols[1];
					int year = int.Parse(cols[2]);
					string ageRating = cols[3];
					string director = cols[4];
					Movie m = new(id, title, year, ageRating, director);
					movies.Add(m);
				}
			}
			return movies;
		}
	}
}
