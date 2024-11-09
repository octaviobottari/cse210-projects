using System;

class Program
{
    static void Main()
    {
   
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int gradePercentage;


        if (int.TryParse(input, out gradePercentage))
        {
            string letter = "";
            string sign = "";


            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
            }
            else if (gradePercentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }


            if (letter != "A" && letter != "F")
            {
                int lastDigit = gradePercentage % 10;
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }
            else if (letter == "A" && gradePercentage >= 90 && gradePercentage < 97)
            {
                sign = "-";
            }

            Console.WriteLine($"Your grade is: {letter}{sign}");

            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations, you passed the course!");
            }
            else
            {
                Console.WriteLine("Keep trying, and you'll do better next time!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric grade percentage.");
        }
    }
}
