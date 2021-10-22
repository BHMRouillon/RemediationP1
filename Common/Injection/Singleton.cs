using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Injection
{
    public class Singleton
    {
        private static Singleton instance = null;
        private static object Object = null;

        public Singleton()
        {
        }

        public Singleton GetInstance(object obj)
        {
            {
                if (instance == null)
                {
                    instance = new Singleton();
                    Object = obj;
                }
                return instance;
            }
        }
        public object Get()
        {
            return Object;
        }
    }
}
