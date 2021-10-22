using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Injection
{
    public class Scope
    {
        private static Dictionary<Scope, object> KeyValues = new Dictionary<Scope, object>();
        private static object Object;

        public Scope()
        {
        }

        public void GetInstance(object obj)
        {
            Object = obj;
            KeyValues.Add(this, obj);
        }
        public object Get()
        {
            if (KeyValues.ContainsKey(this))
            {
                return KeyValues.GetValueOrDefault(this);
            }
            else
            {
                var obj = (Object.GetType()).GetConstructors().First();
                Object = obj.Invoke(null);
                KeyValues.Add(this, obj);
                return Object;
            }
        }
    }
}
