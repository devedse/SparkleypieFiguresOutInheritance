using System;
using System.IO;

namespace KettyGaatDingenDoenV2.Logerinos
{
    public class FileLogger : ILogger
    {
        public override void WriteLog(string txt)
        {
            File.AppendAllText(@"log.txt", txt + Environment.NewLine);
        }
    }
}
