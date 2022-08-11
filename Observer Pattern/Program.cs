using System;
using System.Collections.Generic;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthenticationHandler authenticationHandler = new AuthenticationHandler
            {
                State = false,
                Loggers = new List<ILogger>(),
                Email = "ronle9519@gmail.com"
            };
            ILogger logger = new Logger();
            ILogger email = new Email();
            authenticationHandler.Attach(logger);
            authenticationHandler.Attach(email);
            authenticationHandler.Login();
            authenticationHandler.Detach(email);
            authenticationHandler.Logout();
        }
    }
}
