﻿using System;
using System.IO;

namespace Suijing.Utils
{
    public  class LogHepler
    {
        private static readonly log4net.ILog logdebugger = log4net.LogManager.GetLogger("logdebugger");

        private static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");

        public static void SetConfig()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void SetConfig(FileInfo configFile)
        {
            log4net.Config.XmlConfigurator.Configure(configFile); 
        }

        public static void WriteLog(string info)
        {
            if (logdebugger.IsDebugEnabled)
            {
                logdebugger.Debug(info);
            }
        }

        public static void WriteLog(string info,Exception se)
        {
            if(logerror.IsErrorEnabled)
            {
                logerror.Error(info,se);
            }
        }

    }
}
