using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class SingletonUT
    {
        [TestMethod]
        public void TestSingleton()
        {
            //On cr�e un singleton que l'on instancie.
            var singleton = new Common.Singleton();
            var instance = singleton.GetInstance();
            Assert.AreEqual(true, singleton.IsInstancied());

           //On en cr�e un deuxi�me sans l'instancier.
           //Les deux sont similaires.
            var secondSingleton = new Common.Singleton();
            Assert.AreEqual(true, secondSingleton.IsInstancied());
        }
    }
}
