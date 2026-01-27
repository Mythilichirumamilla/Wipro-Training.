using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Singleton
{
    public sealed class Logger
    {
        private static readonly Logger instance = new Logger();

        private Logger() { }

        public static Logger Instance => instance;

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
