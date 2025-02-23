using ConsoleLibrary;

namespace ClassDemoDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============Class Demo Dictionaries===============");
			Dictionary<string, string> usStates = new Dictionary<string, string>();
			usStates.Add("OH", "Ohio");
			usStates.Add("IN", "Indiana");

			MyConsole.PrintL("Enter some US states. enter EX to exit");
			MyConsole.PrintL("=======================================");
			string stateAbbreviation = "";
			while (stateAbbreviation != "EX")
			{
				stateAbbreviation = MyConsole.PromptString("Us state abbreviation: ").ToUpper();
				if (stateAbbreviation == "EX") 
				break;
				string stateName = MyConsole.PromptString("State name: ");
				usStates.Add(stateAbbreviation, stateName);
				//usStates[stateAbbreviation] = stateName;
			}

			MyConsole.PrintL("GetAdd states:");
			MyConsole.PrintL($"Key 'OH' = {usStates["OH"]}");

			MyConsole.PrintL("Display all keys in dictionary");
			List<string> states = new List<string>(usStates.Keys);
			foreach(string s in states.Keys)
				{
				MyConsole.Print(s + ", ");
			}
			MyConsole.PrintL("");

			MyConsole.PrintL("Display all values in dictionary");

			// store in a dictionary



		}
	}
}
