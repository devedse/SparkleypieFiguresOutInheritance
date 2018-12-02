using KettyGaatDingenDoenV2.Logerinos;
using System;

namespace KettyGaatDingenDoenV2
{
    internal class Berekenaar
    {
        private ILogger _logger;
        public Berekenaar(ILogger logger)
        {
            _logger = logger;
        }

        public int Plus(int a, int b)
        {
            var c = a + b;
            _logger.WriteLog($"Berekening: {a} + {b} = {c}");
            return c;
        }

        public int Vermenigvuldigen(int a, int b)
        {
            var c = a * b;
            _logger.WriteLog($"Berekening: {a} * {b} = {c}");
            return c;
        }
    }
}
