using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBasics
{
    class PasswordChecker
    {
        public static void CheckUserPasswordUntilCorrect()
        {
            // We need to do something

            var hasAnsweredCorrectly = false;

            // We need them to type 1234

            // We use a while loop because we want to loop until the user answers correctly
            while (!hasAnsweredCorrectly)
            {
                Console.WriteLine("Hi, whats your password?");
                var input = Console.ReadLine();
                hasAnsweredCorrectly = input == "1234";
            }
        }

        public static bool CheckUserPassword10Times()
        {
            // We use a for loop because we want to loop a specific number of times, in this case 10 times
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Type in your password?");
                var input = Console.ReadLine();
                if (input == "1234")
                {
                    Console.WriteLine("You've logged in successfully");
                    return true;
                }
            }

            Console.WriteLine("You're locked out now, sucka!");

            return false;
        }

        // Now, you can pass an array of strings, a list of strings, or anything
        /// <summary>
        /// Checks passwords given to see if it contains 1234
        /// </summary>
        /// <param name="passwords">The passwords to check</param>
        /// <returns>If passwords contains "1234", it returns true. Otherwise, it returns false.</returns>
        public static bool CheckUserPasswords(IEnumerable<string> passwords)
        {
            // We need to check the passwords array to see if it contains 1234

            // as an example, let's say passwords currently contains "2345", "3456", "1234", and "6789"

            foreach (var password in passwords)
            {
                if (password == "1234")
                {
                    Console.WriteLine("Sucessful entry");
                    return true;
                }
            }

            return false;
        }
    }
}
