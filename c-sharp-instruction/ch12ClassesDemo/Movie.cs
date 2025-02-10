
//remove using statements

namespace ch12ClassesDemo
{
	public class Movie     // match name of class to name of save file
	{
		public int Id { get; set; }  
		public string Title { get; set; }
		public int Year { get; set; }
		public string Rating { get; set; }
		public string Director { get; set; }

		//define a constructor to Movie class
		public Movie()   // no class keyword
		{

		}
		public Movie(int Id, string Title, int Year, string Rating, string Director)
		{
			this.Id = Id;
		}
		public string ToString()
		{
			return $"Movie({Id}): {Title},{Year},{Rating},{Director}";
		}
	}
}
