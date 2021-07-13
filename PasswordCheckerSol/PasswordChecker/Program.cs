using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "1234567890";
            string specialChars = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

            int score = 0;

            Console.WriteLine("Please enter a password you would like to use:");
            string proposedPassword = Console.ReadLine();

            if (proposedPassword.Length >= minLength)
            {
                score += 1;
            }

            if (Tools.Contains(proposedPassword, uppercase))
            {
                score += 1;
            }

            if (Tools.Contains(proposedPassword, lowercase))
            {
                score += 1;
            }

            if (Tools.Contains(proposedPassword, digits))
            {
                score += 1;
            }

            if (Tools.Contains(proposedPassword, specialChars))
            {
                score += 1;
            }

            if (proposedPassword == "password" || proposedPassword == "1234")
            {
                score = 0;
            }

            switch (score)
            {
                case 1:
                    Console.WriteLine("The password is weak.");
                    break;
                case 2:
                    Console.WriteLine("The password is medium.");
                    break;
                case 3:
                    Console.WriteLine("The password is strong.");
                    break;
                case 4:
                    Console.WriteLine("The password is extremely strong.");
                    break;
                case 5:
                    Console.WriteLine("The password is extremely strong.");
                    break;
                default:
                    Console.WriteLine("The password does not meet any of the standards.");
                    break;
            }
        }
    }
}
