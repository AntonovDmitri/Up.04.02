using ClassLibrary1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            TimeSpan[] start = new TimeSpan[1];
            start[0] = new TimeSpan(15,30,0);
            int[] d = new int[1];
            d[0] = 10;

            TimeSpan b = new TimeSpan(8, 0, 0);

            TimeSpan e = new TimeSpan(18, 0, 0);
            Calculations calculations = new Calculations(start, d, b, e, 30);
            calculations.AvailablePeriods();
        }
    }
}