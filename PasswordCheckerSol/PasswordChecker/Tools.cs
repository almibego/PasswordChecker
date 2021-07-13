using System;

namespace PasswordChecker
{
    public class Tools
    {
        public Tools()
        {
        }

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }

        public static void ContainsTest()
        {
            string uppercaseWord = "LASDAD";
            string lowercaseWord = "pssst";
            string mixedWord = "lkaAWEkasfkEW";

            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine("Running \"tests...\"");
            Console.WriteLine($"Should be true: {Contains(uppercaseWord, uppercase)}");
            Console.WriteLine($"Should be false: {Contains(uppercaseWord, lowercase)}");
            Console.WriteLine($"Should be false: {Contains(lowercaseWord, uppercase)}");
            Console.WriteLine($"Should be true: {Contains(lowercaseWord, lowercase)}");
            Console.WriteLine($"Should be true: {Contains(mixedWord, uppercase)}");
            Console.WriteLine($"Should be true: {Contains(mixedWord, lowercase)}");
        }
    }
}