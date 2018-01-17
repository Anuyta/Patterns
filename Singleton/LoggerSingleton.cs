using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class LoggerSingleton
    {
        private static readonly LoggerSingleton instance = new LoggerSingleton();

        static LoggerSingleton() //lazy init
        {
        }

        private LoggerSingleton()
        {
        }

        public static LoggerSingleton GetInstance()
        {
            return instance;
        }

        public void AddToLog(string filePath, string mess)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(mess);
            }
        }
    }
}
