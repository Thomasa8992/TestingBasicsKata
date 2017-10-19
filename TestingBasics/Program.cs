// Here you are importing all the libraries/frameworks that you're using (think toolboxes)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBasics
{
    public class Program
    {
        static void Main(string[] args)
        {
            var passwords = new List<string>();
            passwords.Add("2345");
            passwords.Add("1234");

            var hasCorrectPassword = PasswordChecker.CheckUserPasswords(passwords);

            Console.WriteLine("has correct password? " + hasCorrectPassword);
            Console.ReadLine();


            //string myString = "Hello World!";
            //var myString = "Hello World!";

            var myStrings = GrabSomeWordsConcisely();

            foreach (var str in myStrings)
            {
                Console.WriteLine(str);
            }

            var cody = new User();
            Console.WriteLine("Have I verified my email address? " + cody.IsEmailVerified);

            cody.VerifyEmailAddress();
            Console.WriteLine("Have I verified my email address? " + cody.IsEmailVerified);
            cody.VerifyEmailAddress();

            Console.WriteLine("Create this first answer, which will be the right answer:");
            var firstAnswer = Console.ReadLine();
            Console.WriteLine("Great, you typed this: " + firstAnswer);

            Console.WriteLine("Great, now the second answer, which will be the wrong answer:");
            var secondAnswer = Console.ReadLine();

            var list = new List<string>();
            list.Select(x => x == "Hello");

            var question = new Question
            {
                DesiredAnswers = new []
                {
                    new Answer
                    {
                        IsRightAnswer = true,
                        Title = firstAnswer
                    },
                    new Answer
                    {
                        IsRightAnswer = false,
                        Title = secondAnswer
                    }
                }
            };

            question.Name = "What are you even doing?";

            foreach (var answer in question.DesiredAnswers)
            {
                Console.WriteLine(answer.Title + " is correct? " + answer.IsRightAnswer);
            }

            Console.ReadLine();

            var myAnswers = new List<Answer>();

            var initialAnswer = new Answer { IsRightAnswer = true, Title = "My Answer" };

            myAnswers.Add(initialAnswer);

            var answerFromList = myAnswers[0];

        }

        public static void DoSomething()
        {

        }

        // public is the modifier
        // static specifies you can call this without an instance of the Program class
        // The return type is specified directly before the method name
        public static List<string> GrabSomeWords()
        {
            var myStrings = new List<string>();

            myStrings.Add("test 1");
            myStrings.Add("test 2");
            myStrings.Add("test 3");
            myStrings.Add("test 4");
            myStrings.Add("test 5");
            myStrings.Add("test 6");
            myStrings.Add("test 7");
            myStrings.Add("test 8");
            myStrings.Add("test 9");
            myStrings.Add("test 10");

            var testing = myStrings[1]; //This would be a "test 2"

            return myStrings;
        }

        public static IEnumerable<string> GrabSomeWordsConcisely()
        {
            var myStrings = new List<string>();

            // Create an i = 0
            // Go as long as i <= 10
            // ++i means you start your first time through with i == 1
            for (int i = 0; i <= 1000; ++i)
            {
                myStrings.Add("test " + i);
            }

            var testing = myStrings[1]; //This would be a "test 2"

            return myStrings;
        }

        public static bool SendEmail(string email, string password, bool isAccountOwner)
        {
            return false;
        }

        static void AskQuestion(Question question)
        {
            Console.WriteLine(question.Name);
            var answer = Console.ReadLine();

            var number = GetEvenAtPosition(5);

            if (answer == "Hello")
            {
                Console.WriteLine("You answered correctly");
            }
            else
            {
                Console.WriteLine("Nope, try again");
            }
            // return at the end is not required for a void returning method
        }

        /// <summary>
        /// Grabs the even number at the position (not index) specified
        /// </summary>
        /// <param name="position">The position you want for the even number</param>
        /// <returns>The even number from the given position</returns>
        public static int GetEvenAtPosition(int position)
        {
            // How you write it out in an Algebraic formula:
            // x = position * 2 - 2
            // How you write that formula in C#:
            return position * 2 - 2;
        }
    }
}
