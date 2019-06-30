using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public abstract class SocialMedia
    {
        public abstract void Login(string name);
        public abstract void PostMessage(string message);
        public abstract void Logout();
    }
}
