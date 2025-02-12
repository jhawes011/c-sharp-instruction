using System.Runtime.Intrinsics.X86;
using ConsoleLibrary;

namespace joe_hawes_person_manager
{
	public class Customer : Person
	{




		public string DisplayText(string sep)
		{
			return $"{base.DisplayText(sep)} {Ssn}";
		}


	}
}
