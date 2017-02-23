using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSA;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Map_Method_With_String()
        {
            int expected = 5;
            int actual = GetInternalCode("C");
            Assert.IsTrue(expected == actual);
        }

        private static int GetInternalCode(string externalCode)
        {
            return externalCode
                .Map("A", 0)
                .Map("B", 2)
                .Map("C", 5)
                .Else(-1);
                
        }
    }
}
