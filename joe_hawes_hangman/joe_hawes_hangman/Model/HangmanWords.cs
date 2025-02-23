using System.Diagnostics.Metrics;
using ConsoleLibrary;

namespace joe_hawes_hangman.Model
{
	public class HangmanWords
	{
		private static List<string> words = new List<string>()
										{
											"here", "face", "finger", "sun", "computer", "cat", "dog", "sun", "moon", "star", "fish", "book", "tree", "ball", "car",
											"pen", "hat", "cake", "chair", "door", "lamp", "bird", "rain", "shoe", "jump",
											"house", "smile", "apple", "grape", "cloud", "grass", "river", "table", "water", "hand",
											"blue", "happy", "funny", "window", "school", "mouse", "phone", "orange", "dance", "story",
											"bread", "candle", "friend", "pencil", "turtle", "butter", "guitar", "shadow", "puzzle", "rocket"
										};
		
		public string word = "";

		public string charsHiddenWord { get; set; }

		

		public static string GetRandomWord()
		{
			Random randWord = new Random();
			int index = randWord.Next(words.Count);
			string word = words[index];
			return word;
		}
	}
}