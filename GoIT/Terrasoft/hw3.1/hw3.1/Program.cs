using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] logins = new string[] { "adm", "moder", "user" };
            string[] passwords = new string[] { "qwerty", "pass", "1234" };
            string[] roles = new string[] { "admin", "moderator", "user" };

            Console.WriteLine("Input your login: ");
            string log = Console.ReadLine();

            Console.WriteLine("Input your password: ");
            string pass = Console.ReadLine();
            
            

            if(log == logins[0] && pass == passwords[0] )
            {
                Console.WriteLine("Hello, Admin!");
                Console.WriteLine("User: {0}. Password: {1}. Role: {2}.", logins[0], passwords[0], roles[0]);
                Console.WriteLine("User: {0}. Password: {1}. Role: {2}.", logins[1], passwords[1], roles[1]);
                Console.WriteLine("User: {0}. Password: {1}. Role: {2}.", logins[2], passwords[2], roles[2]);
            }
            else if (log == logins[1] && pass == passwords[1])
            {
                Console.WriteLine("We have 3 users in our system");
            }
            else if(log == logins[2] && pass == passwords[2])
            {
                Console.WriteLine("Hello, User! \n");
                Console.WriteLine("User with role user: {0}", logins[2]);
            }
            else
            {
                Console.WriteLine("Try again");
            }
                Console.ReadKey();
        }
    }
}
