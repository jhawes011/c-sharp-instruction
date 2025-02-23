using System.Reflection.Metadata.Ecma335;
using System.Security;

namespace ch6Demos
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Print("Welcome to Chapter 6 Demos - METHODS");


            // Get info for a movie (title, year, rating, director)
            string choice = "y";
            while (choice == "y") 
            {
                string title = GetString("Enter movie title: ");
                int year = GetInt("Enter release year: ", 1900, 2050);
                string rating = GetString("Enter age rating: ");
                string director = GetString("Enter director: ");

                // validate y or n
                choice = GetString("Do you want to continue? (y/n): ", "y", "n");
            }



            Print("Hello, World!");
        }

        static int GetInt(string prompt)
        {
                Print(prompt, "");
                return Int32.Parse(Console.ReadLine());
        }
        
        static int GetInt(string prompt, int min, int max)
        {
            bool success = false;
            int nbr = 0;
            while (!success)
            { Print(prompt, "");
                nbr = Int32.Parse(Console.ReadLine());
                
                if (nbr < min || nbr > max)
                    Print($"Error: Out of range. Try again");
                else { 
                        success = true;
                }
            }
            return nbr;
        }
        static string GetString(string propt, string str1, string str2)
        { 
            string retStr = "";
            bool success = false;
            while (!success)
            {
                retStr = GetString(prompt);
                if (retStr == str1 || retStr == str2)
                {
                    success = true;
                }
                else
                {
                    Print($"Error: Must be {str1} or {str2}. Try again.");
                }
            }
            return retStr;


        }
        //define method that accepts a prompt which is a string and returns a string from console ( GetString method)
        static string GetString(string prompt) 
        {
            Print(prompt, "");
            return Console.ReadLine();
        }

        // Method accepts one input variable and returns nothing
        static void Print(string msg, string endLine="\n")
        {
            Console.Write(msg + endLine);
        }
    }
}
