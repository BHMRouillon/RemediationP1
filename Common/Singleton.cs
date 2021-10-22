using System;

namespace Common
{
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        public Singleton()
        {

        }

        public Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }

        public bool IsInstancied()
        {
            if (_instance == null)
            {

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
