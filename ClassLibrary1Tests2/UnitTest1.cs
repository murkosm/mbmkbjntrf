using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibrary1Tests2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TimeSpan[] startTime = new TimeSpan[]
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
            };

            int[] durations = new int[] { 60, 30, 10, 10, 40 };
            TimeSpan beginWorkingTime = new  TimeSpan(8,0,0);
            TimeSpan endWorkingTime = new TimeSpan (18,0,0);
            int consultationTime = 30;

            string[] t = Class1.AvailablePeriods(startTime, durations, beginWorkingTime, endWorkingTime, consultationTime);
            Assert.IsNotNull(t);
        }
    }
}
