using ClassLibrary1;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TimeSpan[] start = new TimeSpan[2];
            start[1] = new TimeSpan(15, 30, 0);
            start[0] = new TimeSpan(8, 0, 0);
            int[] d = new int[2];
            d[1] = 10;
            d[0] = 50;

            TimeSpan b = new TimeSpan(8, 0, 0);

            TimeSpan e = new TimeSpan(18, 0, 0);
            Calculations calculations = new Calculations(start, d, b, e, 30);
            string[] result = calculations.AvailablePeriods();
            Assert.IsNotNull(result);

            string[] timeSlots = {
            "8:50-9:20",
            "9:20-9:50",
            "9:50-10:20",
            "10:20-10:50",
            "10:50-11:20",
            "11:20-11:50",
            "11:50-12:20",
            "12:20-12:50",
            "12:50-13:20",
            "13:20-13:50",
            "13:50-14:20",
            "14:20-14:50",
            "14:50-15:20",
            "15:40-16:10",
            "16:10-16:40",
            "16:40-17:10",
            "17:10-17:40"
            };

            for (int i = 0; i< timeSlots.Length; i++)
            {
                Assert.AreEqual(result[i], timeSlots[i]);
            }
        }


        [TestMethod]
        public void TestMethod2()
        {
            TimeSpan[] start = new TimeSpan[0];
            int[] d = new int[0];

            TimeSpan b = new TimeSpan(8, 0, 0);

            TimeSpan e = new TimeSpan(18, 0, 0);
            Calculations calculations = new Calculations(start, d, b, e, 30);
            string[] result = calculations.AvailablePeriods();
            Assert.IsNotNull(result);

            string[] timeSlots = {
            "8:00-8:30",
            "8:30-9:00",
            "9:00-9:30",
            "9:30-10:00",
            "10:00-10:30",
            "10:30-11:00",
            "11:00-11:30",
            "11:30-12:00",
            "12:00-12:30",
            "12:30-13:00",
            "13:00-13:30",
            "13:30-14:00",
            "14:00-14:30",
            "14:30-15:00",
            "15:00-15:30",
            "15:30-16:00",
            "16:00-16:30",
            "16:30-17:00",
            "17:00-17:30"
            };

            for (int i = 0; i < timeSlots.Length; i++)
            {
                Assert.AreEqual(result[i], timeSlots[i]);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            TimeSpan[] start = new TimeSpan[2];
            start[1] = new TimeSpan(18, 30, 0);
            start[0] = new TimeSpan(7, 0, 0);
            int[] d = new int[2];
            d[1] = 10;
            d[0] = 50;

            TimeSpan b = new TimeSpan(8, 0, 0);

            TimeSpan e = new TimeSpan(18, 0, 0);
            Calculations calculations = new Calculations(start, d, b, e, 30);
            string[] result = calculations.AvailablePeriods();
            Assert.IsNotNull(result);

            string[] timeSlots = {
            "8:00-8:30",
            "8:30-9:00",
            "9:00-9:30",
            "9:30-10:00",
            "10:00-10:30",
            "10:30-11:00",
            "11:00-11:30",
            "11:30-12:00",
            "12:00-12:30",
            "12:30-13:00",
            "13:00-13:30",
            "13:30-14:00",
            "14:00-14:30",
            "14:30-15:00",
            "15:00-15:30",
            "15:30-16:00",
            "16:00-16:30",
            "16:30-17:00",
            "17:00-17:30",
            "17:30-18:00"
            };

            for (int i = 0; i < timeSlots.Length; i++)
            {
                Assert.AreEqual(result[i], timeSlots[i]);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            TimeSpan[] start = new TimeSpan[2];
            start[1] = new TimeSpan(15, 30, 0);
            start[0] = new TimeSpan(8, 0, 0);
            int[] d = new int[2];
            d[1] = 10;
            d[0] = 50;

            TimeSpan b = new TimeSpan(8, 0, 0);

            TimeSpan e = new TimeSpan(18, 0, 0);
            Calculations calculations = new Calculations(start, d, b, e, 120);
            string[] result = calculations.AvailablePeriods();
            Assert.IsNotNull(result);

            string[] timeSlots = {
            "8:50-10:50",
            "10:50-12:50",
            "12:50-14:50",
            "15:40-17:40"
            };

            for (int i = 0; i < timeSlots.Length; i++)
            {
                Assert.AreEqual(result[i], timeSlots[i]);
            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            TimeSpan[] start = new TimeSpan[2];
            start[1] = new TimeSpan(15, 30, 0);
            start[0] = new TimeSpan(8, 0, 0);
            int[] d = new int[2];
            d[1] = 10;
            d[0] = 50;

            TimeSpan b = new TimeSpan(8, 0, 0);

            TimeSpan e = new TimeSpan(18, 0, 0);
            Calculations calculations = new Calculations(start, d, b, e, 47);
            string[] result = calculations.AvailablePeriods();
            Assert.IsNotNull(result);

            string[] timeSlots = {
            "8:50-9:37",
            "9:37-10:24",
            "10:24-11:11",
            "11:11-11:58",
            "11:58-12:45",
            "12:45-13:32",
            "13:32-14:19",
            "14:19-15:06",
            "15:40-16:27",
            "16:27-17:14"
            };

            for (int i = 0; i < timeSlots.Length; i++)
            {
                Assert.AreEqual(result[i], timeSlots[i]);
            }
        }

        [TestMethod]
        public void TestMethod6()
        {
            TimeSpan[] start = new TimeSpan[3];
            start[1] = new TimeSpan(15, 30, 0);
            start[0] = new TimeSpan(8, 0, 0);
            start[2] = new TimeSpan(16, 13, 0);
            int[] d = new int[3];
            d[1] = 10;
            d[0] = 50;
            d[2] = 6;

            TimeSpan b = new TimeSpan(8, 0, 0);

            TimeSpan e = new TimeSpan(18, 0, 0);
            Calculations calculations = new Calculations(start, d, b, e, 30);
            string[] result = calculations.AvailablePeriods();
            Assert.IsNotNull(result);

            string[] timeSlots = {
            "8:50-9:20",
            "9:20-9:50",
            "9:50-10:20",
            "10:20-10:50",
            "10:50-11:20",
            "11:20-11:50",
            "11:50-12:20",
            "12:20-12:50",
            "12:50-13:20",
            "13:20-13:50",
            "13:50-14:20",
            "14:20-14:50",
            "14:50-15:20",
            "15:40-16:10",
            "16:19-16:49",
            "16:49-17:19",
            "17:19-17:49"
            };

            for (int i = 0; i < timeSlots.Length; i++)
            {
                Assert.AreEqual(result[i], timeSlots[i]);
            }
        }

        [TestMethod]
        public void TestMethod7()
        {
            TimeSpan[] start = new TimeSpan[2];
            start[1] = new TimeSpan(15, 30, 0);
            start[0] = new TimeSpan(8, 0, 0);
            int[] d = new int[2];
            d[1] = 10;
            d[0] = 50;

            TimeSpan b = new TimeSpan(9, 23, 0);

            TimeSpan e = new TimeSpan(19, 4, 0);
            Calculations calculations = new Calculations(start, d, b, e, 30);
            string[] result = calculations.AvailablePeriods();
            Assert.IsNotNull(result);

            string[] timeSlots = {
            "9:23-9:53",
            "9:53-10:23",
            "10:23-10:53",
            "10:53-11:23",
            "11:23-11:53",
            "11:53-12:23",
            "12:23-12:53",
            "12:53-13:23",
            "13:23-13:53",
            "13:53-14:23",
            "14:23-14:53",
            "14:53-15:23",
            "15:23-15:53",
            "15:53-16:23",
            "16:23-16:53",
            "16:53-17:23",
            "17:23-17:53",
            "17:53-18:23",
            "18:23-18:53"
            };

            for (int i = 0; i < timeSlots.Length; i++)
            {
                Assert.AreEqual(result[i], timeSlots[i]);
            }
        }

        [TestMethod]
        public void TestMethod8()
        {
            TimeSpan[] start = new TimeSpan[2];
            start[1] = new TimeSpan(15, 30, 0);
            start[0] = new TimeSpan(8, 0, 0);
            int[] d = new int[2];
            d[1] = 10;
            d[0] = 50;

            TimeSpan b = new TimeSpan(1, 0, 0);

            TimeSpan e = new TimeSpan(22, 0, 0);
            Calculations calculations = new Calculations(start, d, b, e, 30);
            string[] result = calculations.AvailablePeriods();
            Assert.IsNotNull(result);

            string[] timeSlots = {
            "1:00-1:30",
            "1:30-2:00",
            "2:00-2:30",
            "2:30-3:00",
            "3:00-3:30",
            "3:30-4:00",
            "4:00-4:30",
            "4:30-5:00",
            "5:00-5:30",
            "5:30-6:00",
            "6:00-6:30",
            "6:30-7:00",
            "7:00-7:30",
            "7:30-8:00",
            "8:50-9:20",
            "9:20-9:50",
            "9:50-10:20",
            "10:20-10:50",
            "10:50-11:20",
            "11:20-11:50",
            "11:50-12:20",
            "12:20-12:50",
            "12:50-13:20",
            "13:20-13:50",
            "13:50-14:20",
            "14:20-14:50",
            "14:50-15:20",
            "15:40-16:10",
            "16:10-16:40",
            "16:40-17:10",
            "17:10-17:40",
            "17:40-18:10",
            "18:10-18:40",
            "18:40-19:10",
            "19:10-19:40",
            "19:40-20:10",
            "20:10-20:40",
            "20:40-21:10",
            "21:10-21:40"
            };

            for (int i = 0; i < timeSlots.Length; i++)
            {
                Assert.AreEqual(result[i], timeSlots[i]);
            }
        }

        [TestMethod]
        public void TestMethod9()
        {
            TimeSpan[] start = new TimeSpan[2];
            start[1] = new TimeSpan(15, 30, 0);
            start[0] = new TimeSpan(8, 0, 0);
            int[] d = new int[2];
            d[1] = 10;
            d[0] = 50;

            TimeSpan b = new TimeSpan(22, 0, 0);

            TimeSpan e = new TimeSpan(18, 0, 0);
            Calculations calculations = new Calculations(start, d, b, e, 30);
            string[] result = calculations.AvailablePeriods();
            Assert.IsNull(result);

        }

        [TestMethod]
        public void TestMethod10()
        {
            TimeSpan[] start = new TimeSpan[2];
            start[1] = new TimeSpan(15, 30, 0);
            start[0] = new TimeSpan(8, 0, 0);
            int[] d = new int[2];
            d[1] = 10;
            d[0] = 50;

            TimeSpan b = new TimeSpan(8, 0, 0);

            TimeSpan e = new TimeSpan(8, 0, 0);
            Calculations calculations = new Calculations(start, d, b, e, 30);
            string[] result = calculations.AvailablePeriods();
            Assert.IsNull(result);
        }
    }
}