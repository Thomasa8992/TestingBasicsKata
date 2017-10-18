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
            //string myString = "Hello World!";
            //var myString = "Hello World!";

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

            foreach (var answer in question.DesiredAnswers)
            {
                Console.WriteLine(answer.Title + " is correct? " + answer.IsRightAnswer);
            }

            Console.ReadLine();
        }
    }
}
