using System.Collections;

namespace ClassLibrary1
{
    public class Calculations
    {
        TimeSpan[] startTimes;
        int[] durations;
        TimeSpan beginWorkingTim;
        TimeSpan endWorkingTime;
        int consultationTime;

        public Calculations(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTim, TimeSpan endWorkingTime, int consultationTime)
        {
            this.startTimes = startTimes;
            this.durations = durations;
            this.beginWorkingTim = beginWorkingTim;
            this.endWorkingTime = endWorkingTime;
            this.consultationTime = consultationTime;
        }

        public String[] AvailablePeriods()
        {
            List<String> periods = new List<String>();
            TimeSpan currentTime = beginWorkingTim;
            int index = 0;
            while (currentTime.Add(new TimeSpan(0, consultationTime, 0)) <= endWorkingTime)
            {
                if (index < startTimes.Length && currentTime.Add(new TimeSpan(0, consultationTime, 0)).TotalMilliseconds > startTimes[index].TotalMilliseconds && startTimes[index].Add(new TimeSpan(0, durations[index], 0)).TotalMilliseconds >= beginWorkingTim.TotalMilliseconds && startTimes[index].Add(new TimeSpan(0, durations[index], 0)).TotalMilliseconds <= endWorkingTime.TotalMilliseconds) {
                    currentTime = startTimes[index].Add(new TimeSpan(0, durations[index], 0));
                    index++;
                }
                periods.Add(currentTime.Hours + ":" + (currentTime.Minutes < 10? "0" + currentTime.Minutes : currentTime.Minutes) + "-" + currentTime.Add(new TimeSpan(0, consultationTime, 0)).Hours + ":" + (currentTime.Add(new TimeSpan(0, consultationTime, 0)).Minutes < 10 ? "0" + currentTime.Add(new TimeSpan(0, consultationTime, 0)).Minutes : currentTime.Add(new TimeSpan(0, consultationTime, 0)).Minutes));
                currentTime = currentTime.Add(new TimeSpan(0, consultationTime, 0));
            }
            String[] result = periods.ToArray();
            if(result.Length == 0) {
                return null;
            }
            return result;
        }
    }
}