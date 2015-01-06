using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("Unit")]
        public void TestMethod1()
        {
            Assert.AreEqual(1, Class1.SomeMethod());
        }

        [TestMethod, TestCategory("Functional")]
        public void TestMethod2()
        {
            Assert.AreEqual(1, Class1.SomeMethod());
        }
    }
}
