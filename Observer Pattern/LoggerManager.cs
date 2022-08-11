using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public interface LoggerManager
    {
        public List<ILogger> Loggers { get; set; }
        public void Attach(ILogger logger);
        public void Detach(ILogger logger);
        public void Notify(object args);
    }
}
