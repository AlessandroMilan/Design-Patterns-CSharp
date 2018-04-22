using ObjectPool.Reusable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectPool.Pool
{
    public class LoggerPool
    {
        private static readonly Lazy<LoggerPool> lazy =
            new Lazy<LoggerPool>(() => new LoggerPool());

        public static LoggerPool GetInstance { get { return lazy.Value; } }

        private List<Logger> LockedLoggers;

        private List<Logger> UnlockedLoggers;

        private int MaxPoolSize;

        private int PoolSize;

        private LoggerPool()
        {
            LockedLoggers = new List<Logger>();
            UnlockedLoggers = new List<Logger>();
            MaxPoolSize = 3;
            PoolSize = 0;
        }

        public Logger AquireLogger()
        {
            Logger logger;

            logger = TryGetLogger();
            if (logger == null)
            {
                if (PoolSize < MaxPoolSize)
                {
                    CreateLogger();
                    logger = TryGetLogger();
                    if (logger != null)
                    {
                        LockLogger(logger);
                    }
                }
            }
            else
            {
                LockLogger(logger);
            }

            return logger;
        }

        public void ReleaseLogger(Logger logger)
        {
            LockedLoggers.Remove(logger);
            UnlockedLoggers.Add(logger);
        }

        private void CreateLogger()
        {
            Logger logger;
            int nextId = ++PoolSize;

            logger = new Logger(nextId);
            UnlockedLoggers.Add(logger);
        }

        private Logger TryGetLogger()
        {
            Logger logger;

            logger = UnlockedLoggers.FirstOrDefault();

            return logger;
        }

        private void LockLogger(Logger logger)
        {
            UnlockedLoggers.Remove(logger);
            LockedLoggers.Add(logger);
        }
    }
}
