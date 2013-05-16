using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, fullName, howFeel;

            Console.WriteLine("Please enter your first name");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            lastName = Console.ReadLine();

            fullName = String.Concat(firstName, " ", lastName);
            Console.WriteLine("Hello " + fullName + ", are you doing well today?");
            howFeel = Console.ReadLine();

            
           if (howFeel == "yes" || howFeel == "Yes" || howFeel == "YES" || howFeel == "yEs" )
            {
                Console.WriteLine("That is wonderful news" + fullName +"! So am I,");
                Console.Read();
            }
            else if(howFeel == "no" || howFeel == "No" || howFeel == "NO" || howFeel =="nO")
            {
                Console.WriteLine("I am sorry to hear that " + fullName + ", That really is a shame");
                Console.Read();
            }
            else
            {
                Console.WriteLine("I am sorry I am not programmed to interpret that response.");
                Console.Read();
            }
        }
    }
}
