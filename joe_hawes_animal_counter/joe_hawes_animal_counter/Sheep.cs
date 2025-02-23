using System.Xml.Linq;
using ConsoleLibrary;

namespace joe_hawes_animal_counter
{
	internal class Sheep : Animal
	{
		private string name;
		public Sheep(string name)
		{
			this.name = name;
		}



		public void SetName(string newName)
		{
			name = newName;
		}


		public string GetName()
		{
			return name;
		}


		
		public override string GetCountString()
		{
			string  sheepCount = $"{count} {name}";
			return sheepCount;
		}


	}
}
