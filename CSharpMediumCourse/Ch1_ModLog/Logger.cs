using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1_ModLog
{
    // Access Modifier
    public class Logger
    {
        // field
        private string logDirectory;
        private string logFilename;

        public Logger()
        {
            logDirectory = Environment.CurrentDirectory;
            logFilename = "log.txt";
        }

        public string LogDirectory { get { return logDirectory; } }

        // method
        public void LogSuccess(string msg)
        {

        }

        public void LogError(string msg)
        {

        }
    }
}
