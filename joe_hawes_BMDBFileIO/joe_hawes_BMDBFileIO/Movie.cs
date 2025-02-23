using ConsoleLibrary;

namespace joe_hawes_BMDBFileIO
{
	public  class Movie
	{
		private string year;

		

		public Movie(int id, string title, int year, string ageRating, string director)
		{
			this.Id = id;
			this.Title = title;
			this.Year = year;
			this.AgeRating = ageRating;
			this.Director = director;

		}

		public int Id { get; set; }
		public string Title { get; set; }
		public int Year { get; set; }
		public string AgeRating { get; set; }
		public string Director { get; set; }
		public override string ToString()
		{
			return $"Movie:   {Id}   - {Title}, {Year}, {AgeRating}, {Director}";
		}



	}
}
