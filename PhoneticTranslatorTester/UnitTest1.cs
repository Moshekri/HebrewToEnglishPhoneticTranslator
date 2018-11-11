using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HebrewToEnglishPhoneticTranslator;

namespace PhoneticTranslatorTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PhoneticTranslator translator = new PhoneticTranslator();
            string name = translator.GetTranslation("משה");
            Assert.AreEqual(name.ToLower(), "mshe");
            name = translator.GetTranslation("בן דוד");
            Assert.AreEqual(name.ToLower(), "bn-david");
            name = translator.GetTranslation("חמוטל");
            Assert.AreEqual(name.ToLower(), "hmotl");
            name = translator.GetTranslation("דרום");
            Assert.AreEqual(name.ToLower(), "drom");
            name = translator.GetTranslation("ורד");
            Assert.AreEqual(name.ToLower(), "vrd");
            name = translator.GetTranslation("רוני");
            Assert.AreEqual(name.ToLower(), "rony");
            name = translator.GetTranslation("רונן");
            Assert.AreEqual(name.ToLower(), "ronn");
        }
    }
}
