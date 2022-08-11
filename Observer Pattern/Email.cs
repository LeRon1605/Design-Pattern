using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Email : ILogger
    {
        public void update(LoggerManager subject, object args)
        {
            if (subject is AuthenticationHandler obj)
            {
                Console.WriteLine($"[Email] {(obj.State ? $"Send email to {obj.Email}" : "Log out")}");
            }
        }
    }
}
