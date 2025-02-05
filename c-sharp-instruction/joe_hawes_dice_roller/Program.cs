namespace joe_hawes_dice_roller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to dice roller ");
            Console.WriteLine("");
            
            string choice = "y";
            
            while (choice.ToLower() == "y")
            {
                Console.Write("Roll the Dice? (y/n) :");
            choice = Console.ReadLine();
                Console.WriteLine();



                
                int die1 = RollDice();
                int die2 = RollDice(); 
               
                Console.Write($"You rolled a {die1} and a {die2}! ");
                Console.WriteLine();
                if (die1 == 1 && die2 == 1)
                { printM("Snake Eyes!"); }
                else if (die1 == 6 && die2 == 6)
                { printM("Boxcars!"); }
                
                Console.WriteLine();
                Console.WriteLine("Total: " + (die1 + die2));
                Console.WriteLine();
                
                

            }
            static int RollDice()
            {
                Random random = new Random();
                return random.Next(1, 7); // Generates a number between 1 and 6
            }
            static void printM(string message)
            {
                Console.WriteLine(message);
            }

            Console.WriteLine("Goodbye------------------------------------- ");   
        }

                
    }
}
