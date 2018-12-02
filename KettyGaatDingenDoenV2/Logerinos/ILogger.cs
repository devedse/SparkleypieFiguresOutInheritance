using System;

namespace KettyGaatDingenDoenV2.Logerinos
{
    public abstract class ILogger
    {
        public abstract void WriteLog(string txt);

        public virtual void WriteLogMetDateTime(string txt)
        {
            WriteLog(DateTime.Now + ": " + txt);
        }
    }
}
