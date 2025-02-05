namespace joe_hawes_guessing_game
{
    internal class Program
    {
        private static int guess;

        static void Main(string[] args)
        {
            Print("Welcome to the Guess the Number Game");
            Print("++++++++++++++++++++++++++++++++++++");
            Print("I'm thinking of a number from 1 to 100. \nTry to guess it.");

            Random rand = new();
            int ranNum = rand.Next(1, 101);

            Print(ranNum.ToString());
            Print("Enter number: ");

            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out guess);

            while (!validInput || guess != ranNum)
            {
                if (!validInput)
                {
                    Print("Invalid input. Please enter a number.");
                }
                else if (guess < ranNum)
                {
                    Print(ranNum - guess > 10 ? "Way Too low !! Guess again." : "Too low! Guess again. \n" + "Enter number: ");
                }
                else if (guess > ranNum)
                {
                    Print(guess - ranNum > 10 ? "Way too high! Guess again." : "Too high! Guess again. \n" + "Enter Number: ");
                }
                else 
                {
                    Print("You guessed it right !! Great job !!");
                    break;
                }

                Print("Enter number: ");
                input = Console.ReadLine();
                validInput = int.TryParse(input, out guess);
            }

            Print("Would you like to play again? (y/n) : ");
            string playAgain = Console.ReadLine();
            if (playAgain.ToLower() == "y")
            {
                Main(args); // Restart the game
            }
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
                
        }
               
    
        
     

        

        
  
        

            
        

        
