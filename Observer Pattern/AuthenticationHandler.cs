using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class AuthenticationHandler : LoggerManager
    {
        public string Email { get; set; }
        public bool State { get; set; }
        public List<ILogger> Loggers { get; set; }
        public void Notify(object args)
        {
            foreach(ILogger logger in Loggers)
            {
                logger.update(this, args);
            }
        }
        public void Attach(ILogger logger)
        {
            Loggers.Add(logger);
        }
        public void Detach(ILogger logger)
        {
            Loggers.Remove(logger);
        }

        public void Login()
        {
            if (Email == "ronle9519@gmail.com")
            {
                State = true;
                Notify("User login successfully");
            }
        }

        public void Logout()
        {
            if (State)
            {
                State = false;
                Notify("User log out");
            }
        }
    }
}
