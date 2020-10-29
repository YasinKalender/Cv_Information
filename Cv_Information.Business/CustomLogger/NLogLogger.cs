using Cv_Information.Business.Abstract;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Business.CustomLogger
{
    public class NLogLogger : INLog
    {
        public void Log(string mesaj)
        {
            var log = LogManager.GetLogger("logger");
            log.Log(LogLevel.Error, mesaj);
            
        }
    }
}
