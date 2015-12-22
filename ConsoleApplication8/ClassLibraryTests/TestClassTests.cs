using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ClassLibrary.Tests
{
    [TestClass()]
    public class TestClassTests
    {
        [TestMethod()]
        public void ReturnResponseTest()
        {
            Assert.AreEqual("Test", "Test");
        }

        [TestMethod()]
        public void ReturnResponse2Test()
        {
            Assert.Fail();
        }
    }
}
