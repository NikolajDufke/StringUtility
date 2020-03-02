using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtliity;

namespace TestStringUtility
{
    [TestClass]
    public class UnitTest1
    {
        private StringChecker st;
        private char testchar;
        private string teststring;

        [TestInitialize]
        public void init()
        {

           
            st = new StringChecker();



        }
  

        [TestMethod]
        public void TestFindSingleChar()
        {
            teststring = "Mysterious";
            testchar = 'y';
            int result =  st.CountOccurrences(testchar, teststring);
           Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestNumberOfChars()
        {
            teststring = "Mysterious";
            testchar = 's';
            int result = st.CountOccurrences(testchar, teststring);

            Assert.AreEqual(2,result);
        }

        [TestMethod]
        public void TestCaseSentative()
        {
            teststring = "Mysterious";
            testchar = 'S';
            int result1 = st.CountOccurrences(testchar, teststring);

            Assert.AreEqual(2,result1);

            testchar = 'M';
            int result2 = st.CountOccurrences(testchar, teststring);

            Assert.AreEqual(1, result2);

        }

        [TestMethod]
        public void TestNullException()
        {
            teststring = null;
            int result = st.CountOccurrences(testchar, teststring);

            Assert.AreEqual(-1,result);
        }

     

   
    }
}
