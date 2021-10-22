using Common.Injection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class InjectionUT
    {
        [TestMethod]
        public void TestInjection()
        {
            User user = new User();

            //Singleton : une seule instance partagée
            Common.Injection.Singleton singleton = new Common.Injection.Singleton();
            singleton.GetInstance(user);
            Assert.AreEqual(user, singleton.Get());

            Common.Injection.Singleton singleton2 = new Common.Injection.Singleton();
            Assert.AreEqual(user, singleton2.Get());

            //A chaque nouvelle implémentation : une nouvelle instance
            Transient transient = new Transient();
            transient.GetInstance(user);
            Assert.AreNotEqual(user, transient.Get());

            //Une instance par requête HTTP
            Scope scope = new Scope();
            scope.GetInstance(user);
            Assert.AreEqual(user, scope.Get());
            Scope scope2 = new Scope();
            Assert.AreNotEqual(null, scope2.Get());
            Assert.AreNotEqual(user, scope2.Get());
            Assert.AreNotEqual(scope.Get(), scope2.Get());
        }
    }
}
