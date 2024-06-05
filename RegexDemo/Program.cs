using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input1 = "Hooray for Regex! It's a match made in code heaven!";

            // Finder det exacte ord match. 
            string pattern1 = @"\bmatch\b";

            // Tjek om ordet match findes i input1 string.
            bool isMatch = Regex.IsMatch(input1, pattern1); // IsMatch = static method, kan kaldes uden at instantiere Regex

            Console.WriteLine("Matcher ordet:");
            Console.WriteLine($"{isMatch}\n"); // Output: True


            //
            
            string input2 = "mic@example.com";
            // string input2 = "micexample.com"; // fejl fordi der ikke findes @

            string pattern2 = @"^\S+@\S+\.\S+$";

            // Leder efter en string der starter med
            // en eller flere non-whitespace char + @ + non-whitespace char + . + non-whitespace char
            // og slutter med $ en eller flere non-whitespace char

            // Tjek om input2 er en valid Email addresse. 
            bool isValidEmail = Regex.IsMatch(input2, pattern2);

            Console.WriteLine("Er det en korrekt Email Addresse:");
            Console.WriteLine(isValidEmail); // Output: True
        }
    }
}

/*
 What is C# Regex and Why You Should Learn It
C# Regex, or regular expressions in C#, is a powerful tool that allows you to manipulate text data -
by searching, matching, and replacing patterns within the text.
It helps in solving a great number of text-related tasks, such as - 
form validation, data extraction, and text transformations.
Mastering C# regular expressions will make you a more efficient developer -
and provide you the ability to tackle complex text-manipulation tasks with ease.
 * */
