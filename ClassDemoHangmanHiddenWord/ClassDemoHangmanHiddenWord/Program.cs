using ConsoleLibrary;
namespace ClassDemoHangmanHiddenWord
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hangman class demo hidden word");

			//define theWord
			string theWord = "superstitious";
			MyConsole.PrintL($"the word is {theWord}");
			//generate hidden word(string == theWord.Length, all underscores
			string hiddenWord = "";
			//# letters in theWord
			//hiddenWord is going to be the same length as theWord and all underscores
			foreach (char word in theWord)
			{
				hiddenWord += "_";
			}
			DisplayHiddenWord(hiddenWord);

			//resolve correctly guessed letters
			string letter = "";
			bool winner = false;
			while (!winner)
			{
				
				letter = MyConsole.PromptString("Guess a letter: ");

				//iterate over theWord and find any matches for letter
				//char[] hiddenWordArray = hiddenWord.ToCharArray();

				char[] charsTheWord = theWord.ToCharArray();
				char[] charsHiddenWord = hiddenWord.ToCharArray();
				for (int i = 0; i < theWord.Length; i++)
				{
					char c = charsTheWord[i];
					if (letter.Equals(c.ToString()))
					{
						MyConsole.PrintL($"letter found! {i}");
						//resolve this character in hiddenWord
						charsHiddenWord[i] = letter[0];
					}
				}
				hiddenWord = new string(charsHiddenWord);
				if (hiddenWord.IndexOf('_') == -1)
					{
					winner = true;
				}
				
				DisplayHiddenWord(hiddenWord);
			}
		}

		private static void DisplayHiddenWord(string hiddenWord)
		{
			MyConsole.PrintL($"hidden word: {hiddenWord}");
			//display the hiddenWord with spaces seperating the underscores
			foreach (char c in hiddenWord)
			{
				MyConsole.Print(c + " ");
			}
			MyConsole.PrintL();
		}
	}
}
