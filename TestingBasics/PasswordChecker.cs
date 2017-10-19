using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBasics
{
    class PasswordChecker
    {
        // Use While loop
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

        // Use for loop
        /// <summary>
        /// Ask the user for their password a certain number of times before locking them out
        /// </summary>
        /// <param name="times">The number of times to ask for the passwords</param>
        /// <returns>If they successfully log in, returns true. Otherwise, returns false.</returns>
        public static bool CheckUserPassword(int times)
        {
            // We use a for loop because we want to loop a specific number of times, in this case 10 times
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Please Enter your password");
                if (Console.ReadLine() == "1234") { return true; }
            }

            return false;
        }

        // Use a foreach loop
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
