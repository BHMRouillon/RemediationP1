using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Injection
{
    public class Transient
    {
        private static object Object;

        public Transient()
        {
        }

        public void GetInstance(object obj)
        {
            Object = obj;
        }
        public object Get()
        {
            var e = (Object.GetType()).GetConstructors().First().Invoke(null);
            return e;
        }
    }
}
