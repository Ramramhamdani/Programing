using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Facebook : SocialMedia
    {
        public Facebook(string username, string password)
        {
            Login(username);
        }
        public override void Login(string name)
        {
            Console.WriteLine($"logging in {name} on Facebook...");
        }

        public override void Logout()
        {
            Console.WriteLine("logging out from Facebook...");
        }

        public override void PostMessage(string message)
        {
            Console.WriteLine($"posting message '{message}' on Facebook...");
            Logout();
        }
    }
}
