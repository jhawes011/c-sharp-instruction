namespace joe_hawes_grade_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter");
            

            string choice = "y";
            while (choice == "y" || choice == "Y")     // could also convert Y to y to make it case insensitive using .ToLower() or .ToUpper()
            {
                Console.WriteLine();
                Console.Write("Enter numerical grade: ");

                int grade = Convert.ToInt32(Console.ReadLine());
                
                string letterGrade = " ";
                
                if (grade >= 88 && grade <= 100)
                letterGrade = "A";
            else if (grade >= 80 && grade <= 87)
                letterGrade = "B";
            else if (grade >= 67 && grade <= 79)
                letterGrade = "C";
            else if (grade >= 60 && grade <= 66)
                letterGrade = "D";
            else
                letterGrade = "F";

            Console.WriteLine($"Letter grade: {letterGrade}");
                Console.WriteLine();   

            
            Console.Write("Continue? (y/n): ");    // could also use || to check for "Y" as well    
                choice = Console.ReadLine();
            }
            
            
            
            
            Console.WriteLine() ;
            Console.WriteLine("Thank you for using JHawes Letter Grade Converter! Goodbye :) ");
        }
    }
}
