using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public interface ILogger
    {
        public void update(LoggerManager subject, object args);
    }
}
