using System;
using System.IO;

namespace SecureUserLib
{
    public static class Logger
    {
        public static void Log(string message)
        {
            File.AppendAllText(
                "app.log",
                $"{DateTime.Now}: {message}{Environment.NewLine}"
            );
        }
    }
}
