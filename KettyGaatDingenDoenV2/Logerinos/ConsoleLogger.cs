using System;

namespace KettyGaatDingenDoenV2.Logerinos
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {

        }

        public override void WriteLog(string txt)
        {
            Console.WriteLine(">" + txt);
        }

        public override void WriteLogMetDateTime(string txt)
        {
            Console.WriteLine("Not supported");
        }
    }
}
