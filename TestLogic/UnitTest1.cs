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
        public static List<string> nullStrList = null;
        public static List<string> oneStrList;
        public static List<string> manyStrList;
        public static List<int> oneIntList;
        public static List<int> manyIntList;

        [TestInitialize]
        public void NewLists ()
        {
            oneStrList = new List<string>();

            oneStrList.Add("string1");
            manyStrList = new List<string>();
            manyStrList.Add("string1");
            manyStrList.Add("string2");
            manyStrList.Add("string3");
            manyStrList.Add("string4");

            oneIntList = new List<int>();
            oneIntList.Add(1);

            manyIntList = new List<int>();
            manyIntList.Add(1);
            manyIntList.Add(2);
            manyIntList.Add(3);
            manyIntList.Add(4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullList()
        {
            nullStrList = nullStrList.MyReverse();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullStructList()
        {
            var intList = ListStructReverse<int>.MyReverse(null);
        }

        [TestMethod]
        public void TestOneOrZeroEllementInList ()
        {
            var newList = oneStrList.MyReverse();
            if (newList.Count == 1)
                Assert.AreEqual(newList[0],"string1");
        }

        [TestMethod]
        public void TestStructOneOrZeroEllementInList()
        {
            var newList = ListStructReverse<int>.MyReverse(oneIntList);
            if (newList.Count == 1)
                Assert.AreEqual(newList[0], 1);
        }

        [TestMethod]
        public void TestMoreThenOneEllementInList()
        {
            Assert.AreEqual(manyStrList.Count, 4);
            var newList = manyStrList.MyReverse();

            for (int i = manyStrList.Count; i > 0; i--)
            {
                Trace.WriteLine(manyStrList[newList.Count  - i] + " : string" + i.ToString());
                Assert.AreEqual(manyStrList[newList.Count-i], "string" + i.ToString());
            }
            
        }

        [TestMethod]
        public void TestStructMoreThenOneEllementInList()
        {
            Assert.AreEqual(manyIntList.Count, 4);
            var newList = ListStructReverse<int>.MyReverse(manyIntList);

            for (int i = manyIntList.Count; i > 0; i--)
            {
                Trace.WriteLine(newList[newList.Count - i] + " : " + manyIntList[i - 1]);
                Assert.AreEqual(newList[newList.Count - i], manyIntList[i - 1]);
            }

        }
    }
}
