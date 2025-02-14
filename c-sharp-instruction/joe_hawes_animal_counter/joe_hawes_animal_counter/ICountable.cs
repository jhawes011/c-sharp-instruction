using ConsoleLibrary;

namespace joe_hawes_animal_counter
{
	internal interface ICountable
	{

		abstract void IncrementCount();
		abstract void ResetCount();
		 int GetCount();
		 string GetCountString();

	}
}
