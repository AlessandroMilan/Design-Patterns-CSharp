using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectPool.Reusable
{
    public class Logger
    {
        public int ID { get; private set; }

        public Logger(int id)
        {
            ID = id;
        }
    }
}
