using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBasics
{
    // This is your class (think cookie cutter)
    class User
    {
        // These are your variables (whether or not your cookie has arms, or has a head, or any other property) 
        public string Name { get; set; }
        public bool IsEmailVerified { get; set; }
        public Question MyQuestion { get; set; }

        // This is your constructor, called when you use the `new` keyword (what happens when you initially cut out the cookie)
        public User()
        {
            Name = "Placeholder";
            IsEmailVerified = false;
        }

        public void VerifyEmailAddress()
        {
            if (!IsEmailVerified)
            {
                IsEmailVerified = true;
            }
            else
            {
                Console.WriteLine("Hey man, you've already verified");
            }
        }
    }
}
