using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Twitter : SocialMedia
    {
        public Twitter(string username, string password)
        {
            Login(username);
        }
        public override void Login(string name)
        {
            Console.WriteLine($"logging in '{name}' on Twitter...");
        }

        public override void Logout()
        {
            Console.WriteLine("logging out from Twitter...");
        }

        public override void PostMessage(string message)
        {
            Console.WriteLine($"posting message '{message}' on Twitter...");
            Logout();
        }
    }
}
