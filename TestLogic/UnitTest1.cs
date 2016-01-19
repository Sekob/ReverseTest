using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestLogic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullList()
        {
            List<string> strList = null;
            strList = strList.MyReverse();
        }

        [TestMethod]
        public void TestOneOrZeroEllementInList ()
        {
            List<string> strList = new List<string>();
            strList.Add("string1");
            var newList = strList.MyReverse();
            if (newList.Count == 1)
                Assert.AreEqual(newList[0],"string1");
        }

        [TestMethod]
        public void TestMoreThenOneEllementInList()
        {
            List<string> strList = new List<string>();
            strList.Add("string1");
            strList.Add("string2");
            strList.Add("string3");
            strList.Add("string4");

            Assert.AreEqual(strList.Count, 4);
            var newList = strList.MyReverse();

            for (int i = strList.Count; i > 0; i--)
            {
                Trace.WriteLine(strList[newList.Count  - i] + " : string" + i.ToString());
                Assert.AreEqual(strList[newList.Count-i], "string" + i.ToString());
            }
            
        }
    }
}
