using ConsoleLibrary;

namespace joe_hawes_animal_counter
{
	public abstract class Animal : ICountable
	{
		protected int count = 0;

		public void IncrementCount()
		{
			count++;
		}
		public void ResetCount()
		{
			count = 0;
		}
		public int GetCount()
		{
			return count; 
		}
		public abstract string GetCountString();


	}
}
