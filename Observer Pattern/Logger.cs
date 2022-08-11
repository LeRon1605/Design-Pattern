using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Logger : ILogger
    {
        public void update(LoggerManager subject, object args)
        {
            if (subject is AuthenticationHandler obj)
            {
                Console.WriteLine($"[Logger] {args}");
            }
        }
    }
}
